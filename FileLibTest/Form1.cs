using FileLib;
using System.Resources;

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
            file.Create(checkBoxCreate.Checked);
            labelCreate.Text = file.Exists.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CFile file = new CFile(textBoxFileName.Text, textBoxDirectory.Text);
            file.Delete();
            labelDelete.Text = (!file.Exists).ToString();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            CFile file = new CFile(textBoxFileName.Text, textBoxDirectory.Text);
            bool? result = file.WriteText(richTextBox1.Text, checkBoxWrite.Checked);
            labelWrite.Text = result.ToString();
            richTextBox1.Clear();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            CFile file = new CFile(textBoxFileName.Text, textBoxDirectory.Text);
            string? result = file.ReadText();
            richTextBox1.Clear();
            richTextBox1.Text = result;
        }
    }
}