using Json.More;
using Json.Schema;
using Json.Schema.Generation;
using JsonGenerator.UI.Models;
using JsonGenerator.UI.Models.EmrFormTemplatesSchema;
using Newtonsoft.Json;
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

        public MainForm()
        {
            InitializeComponent();
            tabControl.TabPages.Clear();

            _config.BaseDirectory = ConfigurationManager.AppSettings["BaseDirectory"];
            _config.BaseFolderName = ConfigurationManager.AppSettings["BaseFolderName"];
            _config.ClassesFolderName = ConfigurationManager.AppSettings["ClassesFolderName"];
            _config.JsonsFolderName = ConfigurationManager.AppSettings["JsonsFolderName"];
            _config.SchemasFolderName = ConfigurationManager.AppSettings["SchemasFolderName"];

            _directory = Path.Combine(_desktopPath, _config.BaseFolderName ?? string.Empty);

            comboBoxTemplateNames.DataSource = GetTemplateNames(Path.Combine(_desktopPath, _config.BaseFolderName, _config.ClassesFolderName));
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

            textBoxBaseDirectory.Text = _config.BaseDirectory;
            textBoxBaseFolderName.Text = _config.BaseFolderName;
            textBoxClassName.Text = _config.ClassesFolderName;
            textBoxJsonName.Text = _config.JsonsFolderName;
            textBoxSchemaName.Text = _config.SchemasFolderName;
        }

        private void GeneralMenuItem_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(tabPageGeneral))
            {
                tabControl.TabPages.Add(tabPageGeneral);
            }
            tabControl.SelectedTab = tabPageGeneral;
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.Contains(tabPageHelp))
            {
                tabControl.TabPages.Add(tabPageHelp);
            }
            tabControl.SelectedTab = tabPageHelp;
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
                case "BaseDirectory":
                    _config.BaseDirectory = ConfigurationManager.AppSettings[key];
                    break;
                case "BaseFolderName":
                    _config.BaseFolderName = ConfigurationManager.AppSettings[key];
                    break;
                case "ClassesFolderName":
                    _config.ClassesFolderName = ConfigurationManager.AppSettings[key];
                    break;
                case "JsonsFolderName":
                    _config.JsonsFolderName = ConfigurationManager.AppSettings[key];
                    break;
                case "SchemasFolderName":
                    _config.SchemasFolderName = ConfigurationManager.AppSettings[key];
                    break;
                default:
                    break;
            }
        }

        private void saveBaseDirectory_Click(object sender, EventArgs e)
        {
            ChangeSettingsValue("BaseDirectory", textBoxBaseDirectory.Text);
            saveBaseDirectory.Enabled = false;
            saveBaseDirectory.BackColor = SystemColors.Window;
        }

        private void textBoxBaseFolderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveBaseFolderName.Enabled = true;
            SaveBaseFolderName.BackColor = Color.LightGreen;
        }

        private void textBoxClassName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveClassFolderName.Enabled = true;
            SaveClassFolderName.BackColor = Color.LightGreen;
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
            SaveBaseFolderName.Enabled = false;
            SaveBaseFolderName.BackColor = SystemColors.Window;
        }

        private void SaveClassFolderName_Click(object sender, EventArgs e)
        {
            ChangeSettingsValue("ClassesFolderName", textBoxClassName.Text);
            SaveClassFolderName.Enabled = false;
            SaveClassFolderName.BackColor = SystemColors.Window;
        }

        private void SaveJsonFolderName_Click(object sender, EventArgs e)
        {
            ChangeSettingsValue("JsonsFolderName", textBoxJsonName.Text);
            SaveJsonFolderName.Enabled = false;
            SaveJsonFolderName.BackColor = SystemColors.Window;
        }

        private void SaveSchemaFolderName_Click(object sender, EventArgs e)
        {
            ChangeSettingsValue("SchemasFolderName", textBoxSchemaName.Text);
            SaveSchemaFolderName.Enabled = false;
            SaveSchemaFolderName.BackColor = SystemColors.Window;
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
        }

        private void btnGeneretSchema_Click(object sender, EventArgs e)
        {
            var nameOfTheForm = nameof(OutpatientTreatmentProgramAdmissionAndFinancialAgreement);
            _ = CreateFileForSchema<OutpatientTreatmentProgramAdmissionAndFinancialAgreement>(nameOfTheForm);

            string CreateFileForSchema<TModel>(string fileName)
            {
                var schemaBuilder = new JsonSchemaBuilder();
                var schema = schemaBuilder.FromType<TModel>().Build();
                var schemaDoc = schema.ToJsonDocument();

                var schemaFileName = Path.Combine(_directory, "Schemas", $"{fileName}_schema.json");

                var rawText = schemaDoc.RootElement.GetRawText();

                if (!Directory.Exists(Path.GetDirectoryName(schemaFileName)))
                    Directory.CreateDirectory(Path.GetDirectoryName(schemaFileName));

                File.WriteAllText(schemaFileName, rawText);
                richTextBoxJsonSchem.Text = rawText;
                richTextBoxJsonSchem.Visible = true;
                return rawText;
            }

            btnGeneretSchema.Enabled = false;
            btnGeneretSchema.BackColor = SystemColors.Window;
        }

        private void btnGeneretExample_Click(object sender, EventArgs e)
        {
            var nameOfTheForm = nameof(OutpatientTreatmentProgramAdmissionAndFinancialAgreement);
            _ = CreateFileForExampleJson<OutpatientTreatmentProgramAdmissionAndFinancialAgreement>(nameOfTheForm);


            string CreateFileForExampleJson<TModel>(string fileName)
            {
                var fake = AutoBogus.AutoFaker.Generate<TModel>();
                var fakeJson = JsonConvert.SerializeObject(fake, Formatting.Indented);
                var jsonFileName = Path.Combine(_directory, "Jsons", $"{fileName}_example.json");

                if (!Directory.Exists(Path.GetDirectoryName(jsonFileName)))
                    Directory.CreateDirectory(Path.GetDirectoryName(jsonFileName));

                File.WriteAllText(jsonFileName, fakeJson);
                richTextBoxJsonExample.Text = fakeJson;
                richTextBoxJsonExample.Visible = true;
                return fakeJson;
            }

            btnGeneretExample.Enabled = false;
            btnGeneretExample.BackColor = SystemColors.Window;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
