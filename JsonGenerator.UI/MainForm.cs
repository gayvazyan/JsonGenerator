using Json.More;
using Json.Schema;
using Json.Schema.Generation;
using JsonGenerator.UI.Models;
using JsonGenerator.UI.Models.EmrFormTemplatesSchema;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;

namespace JsonGenerator.UI
{
    public partial class MainForm : Form
    {

        public List<string> TemplateNames { get; set; } = new List<string>();
        private ConfigModel _config { get; set; } = new ConfigModel();

        private string _desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string _directory { get; set; }
        public string _className { get; set; } = string.Empty;

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
        private List<string> GetTemplateNames(string folderPath)
        {
            try
            {
                if (Directory.Exists(folderPath))
                {
                    var di = new DirectoryInfo(folderPath);

                    TemplateNames.Add(string.Empty);

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
            catch (UnauthorizedAccessException ex)
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
            var projectRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            comboBoxTemplateNames.DataSource = GetTemplateNames(Path.Combine(_directory, "Classes"));
            //comboBoxTemplateNames.DataSource = GetTemplateNames(Path.Combine(projectRoot.Remove(projectRoot.Length - 3), "Models", "EmrFormTemplatesSchema"));

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
            var projectRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string configFilePath = Path.Combine(projectRoot.Remove(projectRoot.Length - 3), "App.config");

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
            Type classType = Assamblies.SelectMany(a => a.GetTypes()).FirstOrDefault(t => string.Equals(t.Name, _className));

            if (classType != null)
                CreateFileForSchema(classType, _className);

            btnGeneretSchema.Enabled = false;
            btnGeneretSchema.BackColor = SystemColors.Window;
        }
        private void CreateFileForSchema(Type modelType, string fileName)
        {
            var schemaBuilder = new JsonSchemaBuilder();
            var schema = schemaBuilder.FromType(modelType).Build();
            var schemaDoc = schema.ToJsonDocument();

            var schemaFileName = Path.Combine(_directory, _config.JsonSchemasFolderName ?? string.Empty, $"{fileName}_schema.json");

            var rawText = schemaDoc.RootElement.GetRawText();
            File.WriteAllText(schemaFileName, rawText);
            richTextBoxJsonSchem.Text = rawText;
            richTextBoxJsonSchem.Visible = true;
        }
        private void btnGeneretExample_Click(object sender, EventArgs e)
        {
            Type classType = Assamblies.SelectMany(a => a.GetTypes()).FirstOrDefault(t => string.Equals(t.Name, _className));

            if (classType != null)
            {
                // Using reflection to call the generic method
                MethodInfo method = GetType().GetMethod("CreateFileForExampleJson", BindingFlags.NonPublic | BindingFlags.Instance);
                MethodInfo genericMethod = method.MakeGenericMethod(classType);
                genericMethod.Invoke(this, new object[] { _className });

                //CreateFileForExampleJson<TModel>(_className);
            }

            btnGeneretExample.Enabled = false;
            btnGeneretExample.BackColor = SystemColors.Window;
        }
        private void CreateFileForExampleJson<TModel>(string fileName)
        {
            var fake = AutoBogus.AutoFaker.Generate<TModel>();
            var fakeJson = JsonConvert.SerializeObject(fake, Formatting.Indented);
            var jsonFileName = Path.Combine(_directory, _config.JsonExampleFolderName ?? string.Empty, $"{fileName}_example.json");

            if (!Directory.Exists(Path.GetDirectoryName(jsonFileName)))
                Directory.CreateDirectory(Path.GetDirectoryName(jsonFileName));

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

            comboBoxTemplateNames.DataSource = TemplateNames;

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

            // Construct the destination file path
             string destinationFilePath = Path.Combine(_directory, "Classes");

            if (!Directory.Exists(destinationFilePath))
                Directory.CreateDirectory(destinationFilePath);

            // Copy the file to the destination directory
            File.Copy(filePath, destinationFilePath, true); // Overwrite if the file already exists

            btnSaveClass.Enabled = false;
            labelClassPath.Text = string.Empty;
            btnSaveClass.BackColor = Color.Transparent;
            MessageBox.Show("Գործողությունը հաջողությամբ կատարվեց", "Կրկնօրինակում", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateClasses_Click(object sender, EventArgs e)
        {
            string destinationDirectory = Path.Combine(_directory, "Classes");

            if (!Directory.Exists(destinationDirectory))
                Directory.CreateDirectory(destinationDirectory);

            string sourceDirectory = string.Empty;

            progressBarUpdate.Visible = true;

            // Get all.cs files in the source directory
            string[] csFiles = Directory.GetFiles(sourceDirectory, "*.cs");

            // Copy each.cs file to the destination directory
            foreach (string filePath in csFiles)
            {
                string fileName = Path.GetFileName(filePath);
                string destinationPath = Path.Combine(destinationDirectory, fileName);
                Application.DoEvents();
                Thread.Sleep(200);

                // Check if the file already exists in the destination directory
                if (!File.Exists(destinationPath))
                    File.Copy(filePath, destinationPath, true);
            }

            progressBarUpdate.Visible = false;

            MessageBox.Show("Գործողությունը հաջողությամբ կատարվեց", "Կրկնօրինակում", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
