
namespace JsonGenerator.UI
{
    public partial class JsonViwerForm : Form
    {
        public JsonViwerForm(string formattedJson, string title)
        {
            InitializeComponent();

            richJsonViewer.Text = formattedJson;
            this.Text = title;
        }
    }
}
