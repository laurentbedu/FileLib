using FileLib;

namespace FileLibTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CFile file = new CFile(textBoxFileName.Text, textBoxDirectory.Text);
            file.Create();
            labelCreate.Text = file.Exists.ToString();
        }
    }
}