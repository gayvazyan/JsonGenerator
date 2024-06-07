using Json.More;
using Json.Schema;
using Json.Schema.Generation;
using JsonGenerator.UI.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;

namespace JsonGenerator.UI
{
    public partial class MainForm : Form
    {

        public BindingList<string> TemplateNames { get; set; } = new BindingList<string>();
        private ConfigModel _config { get; set; } = new ConfigModel();

        private string _desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string _directory { get; set; }
        public string _className { get; set; } = string.Empty;
        public string _projectRoot { get; set; } = string.Empty;

        public Assembly[] Assamblies { get; set; } = AppDomain.CurrentDomain.GetAssemblies();

        public MainForm()
        {
            InitializeComponent();
            tabControl.TabPages.Clear();

            _config.BaseDirectoryName = ConfigurationManager.AppSettings["BaseDirectoryName"];
            _config.BaseFolderName = ConfigurationManager.AppSettings["BaseFolderName"];
            _config.JsonExampleFolderName = ConfigurationManager.AppSettings["JsonExampleFolderName"];
            _config.JsonSchemasFolderName = ConfigurationManager.AppSettings["JsonSchemasFolderName"];

            _directory = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty);
            // _projectRoot = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.FullName ?? string.Empty;
        }

        private void comboBoxTemplateNames_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTemplateNames.SelectedIndex == 0 || comboBoxTemplateNames.SelectedIndex == -1)
            {
                comboBoxTemplateNames.SelectedIndex = -1;
                btnGeneretExample.Enabled = false;
                btnGeneretSchema.Enabled = false;
                btnGeneretExample.BackColor = SystemColors.Window;
                btnGeneretSchema.BackColor = SystemColors.Window;
            }
            else
            {
                btnGeneretExample.Enabled = true;
                btnGeneretSchema.Enabled = true;
                btnGeneretExample.BackColor = Color.LightGreen;
                btnGeneretSchema.BackColor = Color.LightGreen;
            }

            richTextBoxJsonExample.Text = string.Empty;
            richTextBoxJsonExample.Visible = false;

            richTextBoxJsonSchem.Text = string.Empty;
            richTextBoxJsonSchem.Visible = false;

            if (comboBoxTemplateNames != null)
                _className = comboBoxTemplateNames?.SelectedValue?.ToString() ?? string.Empty;

        }
        private BindingList<string> GetTemplateNames(string folderPath)
        {
            try
            {

                if (Directory.Exists(folderPath))
                {
                    TemplateNames.Clear();
                    TemplateNames.Add(string.Empty);
                    var di = new DirectoryInfo(folderPath);
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        if (fi.Exists && string.Equals(fi.Extension, ".cs"))
                        {
                            string className = fi.Name;
                            TemplateNames.Add(className.Remove(className.Length - 3));
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Log detailed information or show a message to the user
                MessageBox.Show($"Access to the path '{folderPath}' is denied. Please check your permissions.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other potential exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TemplateNames;
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Դուք իսկապե՞ս ցանկանում եք դուրս գալ համակարգից", "Ելք համակարգից", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                Application.Exit();

        }
        private void ConfigMenuItem_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(tabPageConfig))
            {
                tabControl.TabPages.Add(tabPageConfig);
            }
            tabControl.SelectedTab = tabPageConfig;

            textBoxBaseDirectory.Text = _config.BaseDirectoryName;
            textBoxBaseFolderName.Text = _config.BaseFolderName;
            textBoxJsonName.Text = _config.JsonExampleFolderName;
            textBoxSchemaName.Text = _config.JsonSchemasFolderName;
        }
        private void GeneralMenuItem_Click(object sender, EventArgs e)
        {
            _directory = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty);

            comboBoxTemplateNames.DataSource = null;
           comboBoxTemplateNames.DataSource = GetTemplateNames(Path.Combine(_directory, "Classes"));
            //comboBoxTemplateNames.DataSource = GetTemplateNames(Path.Combine(_projectRoot, "Models", "EmrFormTemplatesSchema"));

            if (!tabControl.TabPages.Contains(tabPageGeneral))
                tabControl.TabPages.Add(tabPageGeneral);

            tabControl.SelectedTab = tabPageGeneral;
        }
        private void textBoxBaseDirectory_KeyPress(object sender, KeyPressEventArgs e)
        {
            saveBaseDirectory.Enabled = true;
            saveBaseDirectory.BackColor = Color.LightGreen;
        }
        private void ChangeSettingsValue(string key, string newValue)
        {
            _directory = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty);

            string configFilePath = Path.Combine(_directory, "Configs", "App.config");

            // Load the configuration file
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFilePath;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            // Get the appSettings section
            AppSettingsSection appSettings = (AppSettingsSection)config.GetSection("appSettings");

            // Modify the BaseDirectory key value

            if (appSettings.Settings[key] != null)
            {
                appSettings.Settings[key].Value = newValue;
            }
            else
            {
                appSettings.Settings.Add(key, newValue);
            }

            // Save the configuration file
            config.Save(ConfigurationSaveMode.Modified);

            // Refresh the appSettings section to reflect the changes
            ConfigurationManager.RefreshSection("appSettings");

            // Verify the change
            switch (key)
            {
                case "BaseDirectoryName":
                    textBoxBaseDirectory.Text = _config.BaseDirectoryName = newValue;
                    break;
                case "BaseFolderName":
                    textBoxBaseFolderName.Text = _config.BaseFolderName = newValue;
                    break;
                case "JsonExampleFolderName":
                    textBoxJsonName.Text = _config.JsonExampleFolderName = newValue;
                    break;
                case "JsonSchemasFolderName":
                    textBoxSchemaName.Text = _config.JsonSchemasFolderName = newValue;
                    break;
                default:
                    break;
            }
        }
        private void saveBaseDirectory_Click(object sender, EventArgs e)
        {
            ChangeSettingsValue("BaseDirectoryName", textBoxBaseDirectory.Text);

            saveBaseDirectory.Enabled = false;
            saveBaseDirectory.BackColor = SystemColors.Window;
        }
        private void textBoxBaseFolderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveBaseFolderName.Enabled = true;
            SaveBaseFolderName.BackColor = Color.LightGreen;
        }
        private void textBoxJsonName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveJsonFolderName.Enabled = true;
            SaveJsonFolderName.BackColor = Color.LightGreen;
        }
        private void textBoxSchemaName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveSchemaFolderName.Enabled = true;
            SaveSchemaFolderName.BackColor = Color.LightGreen;
        }
        private void SaveBaseFolderName_Click(object sender, EventArgs e)
        {
            ChangeSettingsValue("BaseFolderName", textBoxBaseFolderName.Text);

            string directory = Path.Combine(_config.BaseDirectoryName, _config.BaseFolderName ?? string.Empty);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);


            SaveBaseFolderName.Enabled = false;
            SaveBaseFolderName.BackColor = SystemColors.Window;
        }
        private void SaveJsonFolderName_Click(object sender, EventArgs e)
        {
            ChangeSettingsValue("JsonExampleFolderName", textBoxJsonName.Text);

            string directory = Path.Combine(_config.BaseDirectoryName, _config.BaseFolderName ?? string.Empty);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (!Directory.Exists(Path.Combine(directory, _config.JsonExampleFolderName)))
                Directory.CreateDirectory(Path.Combine(directory, _config.JsonExampleFolderName));

            SaveJsonFolderName.Enabled = false;
            SaveJsonFolderName.BackColor = SystemColors.Window;
        }
        private void SaveSchemaFolderName_Click(object sender, EventArgs e)
        {
            ChangeSettingsValue("JsonSchemasFolderName", textBoxSchemaName.Text);

            string directory = Path.Combine(_config.BaseDirectoryName, _config.BaseFolderName ?? string.Empty);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (!Directory.Exists(Path.Combine(directory, _config.JsonSchemasFolderName)))
                Directory.CreateDirectory(Path.Combine(directory, _config.JsonSchemasFolderName));

            SaveSchemaFolderName.Enabled = false;
            SaveSchemaFolderName.BackColor = SystemColors.Window;
        }
        private void btnGeneretSchema_Click(object sender, EventArgs e)
        {
            Type classType =  AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()).FirstOrDefault(t => string.Equals(t.Name, _className));

            ///AppDomain.CurrentDomain.GetAssemblies()

            if (classType == null)
            {
                // Path to the assembly you want to load (DLL file)

                string dllDirectoryPath = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty, "Dlls");


                string dllFileName = _className + ".dll";

                string assemblyPath = Path.Combine(dllDirectoryPath, dllFileName);

                // Check if the file exists
                if (!File.Exists(assemblyPath))
                {
                    MessageBox.Show($"The assembly file was not found at: {assemblyPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Load the assembly
                    Assembly loadedAssembly = Assembly.LoadFrom(assemblyPath);

                    // Display some information about the loaded assembly
                    Console.WriteLine($"Assembly FullName: {loadedAssembly.FullName}");

                    // List all types in the assembly
                    Type type = loadedAssembly.GetTypes().FirstOrDefault(t => string.Equals(t.Name, _className));

                    CreateFileForSchema(type, _className);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading the assembly: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                CreateFileForSchema(classType, _className);
            }

            btnGeneretSchema.Enabled = false;
            btnGeneretSchema.BackColor = SystemColors.Window;
        }
        private void CreateFileForSchema(Type modelType, string fileName)
        {
            var schemaBuilder = new JsonSchemaBuilder();
            var schema = schemaBuilder.FromType(modelType).Build();
            var schemaDoc = schema.ToJsonDocument();

            _directory = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty);

            var schemaFileName = Path.Combine(_directory, _config.JsonSchemasFolderName ?? string.Empty, $"{fileName}_schema.json");

            if (!Directory.Exists(Path.GetDirectoryName(schemaFileName)))
                Directory.CreateDirectory(Path.GetDirectoryName(schemaFileName) ?? string.Empty);

            var rawText = schemaDoc.RootElement.GetRawText();
            File.WriteAllText(schemaFileName, rawText);
            richTextBoxJsonSchem.Text = rawText;
            richTextBoxJsonSchem.Visible = true;
        }
        private void btnGeneretExample_Click(object sender, EventArgs e)
        {
            Type classType = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()).FirstOrDefault(t => string.Equals(t.Name, _className));


            if (classType == null)
            {
                Assembly loadedAssembly;
                // Path to the assembly you want to load (DLL file)

                string dllDirectoryPath = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty, "Dlls");


                string dllFileName = _className + ".dll";

                string assemblyPath = Path.Combine(dllDirectoryPath, dllFileName);

                // Check if the file exists
                if (!File.Exists(assemblyPath))
                {
                    MessageBox.Show($"The assembly file was not found at: {assemblyPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Load the assembly
                   loadedAssembly = Assembly.LoadFrom(assemblyPath);

                    // Display some information about the loaded assembly
                    Console.WriteLine($"Assembly FullName: {loadedAssembly.FullName}");

                    // List all types in the assembly
                    Type type = loadedAssembly.GetTypes().FirstOrDefault(t => string.Equals(t.Name, _className));

                    MethodInfo method = GetType().GetMethod("CreateFileForExampleJson", BindingFlags.NonPublic | BindingFlags.Instance);
                    MethodInfo genericMethod = method.MakeGenericMethod(type);
                    genericMethod.Invoke(this, new object[] { _className });

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading the assembly: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MethodInfo method = GetType().GetMethod("CreateFileForExampleJson", BindingFlags.NonPublic | BindingFlags.Instance);
                MethodInfo genericMethod = method.MakeGenericMethod(classType);
                genericMethod.Invoke(this, new object[] { _className });
            }

            btnGeneretExample.Enabled = false;
            btnGeneretExample.BackColor = SystemColors.Window;
        }
        private void CreateFileForExampleJson<TModel>(string fileName)
        {
            var fake = AutoBogus.AutoFaker.Generate<TModel>();
            var fakeJson = JsonConvert.SerializeObject(fake, Formatting.Indented);

            _directory = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty);

            var jsonFileName = Path.Combine(_directory, _config.JsonExampleFolderName ?? string.Empty, $"{fileName}_example.json");

            if (!Directory.Exists(Path.GetDirectoryName(jsonFileName)))
                Directory.CreateDirectory(Path.GetDirectoryName(jsonFileName) ?? string.Empty);

            File.WriteAllText(jsonFileName, fakeJson);
            richTextBoxJsonExample.Text = fakeJson;
            richTextBoxJsonExample.Visible = true;
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
        private void btnDeleteAllConfig_Click(object sender, EventArgs e)
        {
            ChangeSettingsValue("BaseDirectoryName", string.Empty);
            ChangeSettingsValue("BaseFolderName", string.Empty);
            ChangeSettingsValue("JsonExampleFolderName", string.Empty);
            ChangeSettingsValue("JsonSchemasFolderName", string.Empty);
        }
        private void btnSetDefultConfigs_Click(object sender, EventArgs e)
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            ChangeSettingsValue("BaseDirectoryName", desktopPath);
            ChangeSettingsValue("BaseFolderName", "Codemax");
            ChangeSettingsValue("JsonExampleFolderName", "Examples");
            ChangeSettingsValue("JsonSchemasFolderName", "Schemas");

            string directory = Path.Combine(desktopPath, "Codemax");

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (!Directory.Exists(Path.Combine(directory, "Examples")))
                Directory.CreateDirectory(Path.Combine(directory, "Examples"));

            if (!Directory.Exists(Path.Combine(directory, "Schemas")))
                Directory.CreateDirectory(Path.Combine(directory, "Schemas"));

        }
        private void btnInsertDefoultClasses_Click(object sender, EventArgs e)
        {
            _directory = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty);

            string sourceDirectory = Path.Combine(_directory, "Classes");

            Assamblies = AppDomain.CurrentDomain.GetAssemblies();

            progressBarClassCopy.Visible = true;

            if (!Directory.Exists(sourceDirectory))
                Directory.CreateDirectory(sourceDirectory);

            var di = new DirectoryInfo(sourceDirectory);
            TemplateNames.Clear();
            TemplateNames.Add(string.Empty);

            foreach (FileInfo fi in di.GetFiles())
            {
                if (fi.Exists && string.Equals(fi.Extension, ".cs"))
                {

                    Application.DoEvents();
                    Thread.Sleep(200);

                    string className = fi.Name;
                    TemplateNames.Add(className.Remove(className.Length - 3));
                }
            }

            progressBarClassCopy.Visible = false;

            _directory = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty);

            comboBoxTemplateNames.DataSource = null;
            comboBoxTemplateNames.DataSource = GetTemplateNames(Path.Combine(_directory, "Classes"));

            btnInsertDefoultClasses.Enabled = false;
            btnInsertDefoultClasses.BackColor = Color.Transparent;

            MessageBox.Show("Գործողությունը հաջողությամբ կատարվեց", "Կրկնօրինակում", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "*.cs|*.cs";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    labelClassPath.Text = openFileDialog.FileName;
                    btnSaveClass.Enabled = true;
                    btnInsertDefoultClasses.Enabled = true;
                    btnInsertDefoultClasses.BackColor = Color.LightGreen;
                    btnSaveClass.BackColor = Color.LightGreen;
                }
            }
        }
        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            string filePath = labelClassPath.Text;
            _directory = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty);

            // Construct the destination file path
            string destinationDirectory = Path.Combine(_directory, "Classes");

            if (!Directory.Exists(destinationDirectory))
                Directory.CreateDirectory(destinationDirectory);

            // Copy the file to the destination directory
            string destinationFilePath = Path.Combine(destinationDirectory, Path.GetFileName(filePath));
            File.Copy(filePath, destinationFilePath, true); // Overwrite if the file already exists

            GenerateDllFile(filePath);

            btnSaveClass.Enabled = false;
            labelClassPath.Text = string.Empty;
            btnSaveClass.BackColor = Color.Transparent;
            MessageBox.Show("Գործողությունը հաջողությամբ կատարվեց", "Կրկնօրինակում", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void checkBoxInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInsert.Checked)
            {
                btnInsertClasses.Visible = true;
                labelInsertClassesPath.Visible = true;
                btnSave.Visible = true;
            }
            else
            {
                btnInsertClasses.Visible = false;
                labelInsertClassesPath.Visible = false;
                btnSave.Visible = false;
                btnSave.BackColor = Color.Transparent;
                labelInsertClassesPath.Text = string.Empty;
                btnSave.Enabled= false;
            }
        }

        private void btnInsertClasses_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Use the selected directory path here
                    string selectedDirectoryPath = folderBrowserDialog.SelectedPath;
                    labelInsertClassesPath.Visible = true;
                    labelInsertClassesPath.Text = selectedDirectoryPath; // Update your label or use the path as needed
                    btnSave.Enabled = true;
                    btnSave.BackColor = Color.LightGreen;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _directory = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty);

            string destinationDirectory = Path.Combine(_directory, "Classes");
            string sourceDirectory = labelInsertClassesPath.Text;

            if (!Directory.Exists(destinationDirectory))
                Directory.CreateDirectory(destinationDirectory);

            progressBarInsert.Visible = true;

            // Get all.cs files in the source directory
            string[] csFiles = Directory.GetFiles(sourceDirectory, "*.cs");

            // Copy each.cs file to the destination directory
            int cout = 0;
            foreach (string filePath in csFiles)
            {
                string fileName = Path.GetFileName(filePath);
                string destinationPath = Path.Combine(destinationDirectory, fileName);
                Application.DoEvents();
                Thread.Sleep(200);

                // Check if the file already exists in the destination directory
                if (!File.Exists(destinationPath))
                {
                    File.Copy(filePath, destinationPath, true);
                    cout++;
                }
                    
            }
            progressBarInsert.Visible = false;

            _directory = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty);

           comboBoxTemplateNames.DataSource = null;
           comboBoxTemplateNames.DataSource = GetTemplateNames(Path.Combine(_directory, "Classes"));

            MessageBox.Show("Գործողությունը ավարտվեց, պատճենվեց " + cout + " ֆայլ", "Կրկնօրինակում", MessageBoxButtons.OK, MessageBoxIcon.Information);

            checkBoxInsert.Checked = false;
        }
   
        private void GenerateDllFile(string filePath)
        {
            string code = File.ReadAllText(filePath);

            string fileName = Path.GetFileNameWithoutExtension(filePath);

            var syntaxTree = CSharpSyntaxTree.ParseText(code);

            var references = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => !a.IsDynamic)
                .Select(a => MetadataReference.CreateFromFile(a.Location))
                .Cast<MetadataReference>()
                .ToList();

            var compilation = CSharpCompilation.Create(
                "DynamicLibrary",
                new[] { syntaxTree },
                references,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            string dllDirectoryPath = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty, "Dlls");

            if (!Directory.Exists(dllDirectoryPath))
                Directory.CreateDirectory(dllDirectoryPath);

            string dllFileName = fileName + ".dll";

            string dllPath = Path.Combine(dllDirectoryPath, dllFileName);

            EmitResult result = compilation.Emit(dllPath);


            if (!result.Success)
            {
                StringBuilder diagnosticList = new StringBuilder();
                foreach (Diagnostic diagnostic in result.Diagnostics)
                {
                    diagnosticList.Append(diagnostic.ToString());   
                }
                MessageBox.Show($"Compilation failed: {diagnosticList.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
