using System.IO;
using System.Text.RegularExpressions;

namespace JsonGenerator.UI
{
    public partial class MainForm : Form
    {

        public List<string> TemplateNames { get; set; } = new List<string>();
        private string _desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        

        public MainForm()
        {
            InitializeComponent();
           

            comboBoxTemplateNames.DataSource = GetTemplateNames(Path.Combine(_desktopPath, "Codemax", "Classes")); 
        }

        private List<string> GetTemplateNames(string folderPath)
        {
            try
            {
                if (Directory.Exists(folderPath))
                {
                    var di = new DirectoryInfo(folderPath);

                    foreach (FileInfo fi in di.GetFiles())
                    {
                        if (fi.Exists && string.Equals(fi.Extension,".cs"))
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

    }
}
