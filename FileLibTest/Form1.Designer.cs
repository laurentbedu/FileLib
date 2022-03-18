namespace FileLibTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelCreate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelDelete = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.labelWrite = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.checkBoxCreate = new System.Windows.Forms.CheckBox();
            this.checkBoxWrite = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(716, 35);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(94, 29);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(12, 32);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(389, 27);
            this.textBoxDirectory.TabIndex = 1;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(407, 32);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(219, 27);
            this.textBoxFileName.TabIndex = 2;
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.Location = new System.Drawing.Point(816, 39);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(45, 20);
            this.labelCreate.TabIndex = 3;
            this.labelCreate.Text = "result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "FileName";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(716, 70);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(816, 74);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(45, 20);
            this.labelDelete.TabIndex = 7;
            this.labelDelete.Text = "result";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(389, 130);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(493, 78);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(94, 29);
            this.buttonWrite.TabIndex = 9;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // labelWrite
            // 
            this.labelWrite.AutoSize = true;
            this.labelWrite.Location = new System.Drawing.Point(593, 82);
            this.labelWrite.Name = "labelWrite";
            this.labelWrite.Size = new System.Drawing.Size(45, 20);
            this.labelWrite.TabIndex = 10;
            this.labelWrite.Text = "result";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(409, 111);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(94, 29);
            this.buttonRead.TabIndex = 11;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // checkBoxCreate
            // 
            this.checkBoxCreate.AutoSize = true;
            this.checkBoxCreate.Location = new System.Drawing.Point(632, 35);
            this.checkBoxCreate.Name = "checkBoxCreate";
            this.checkBoxCreate.Size = new System.Drawing.Size(78, 24);
            this.checkBoxCreate.TabIndex = 12;
            this.checkBoxCreate.Text = "écraser";
            this.checkBoxCreate.UseVisualStyleBackColor = true;
            // 
            // checkBoxWrite
            // 
            this.checkBoxWrite.AutoSize = true;
            this.checkBoxWrite.Location = new System.Drawing.Point(409, 81);
            this.checkBoxWrite.Name = "checkBoxWrite";
            this.checkBoxWrite.Size = new System.Drawing.Size(78, 24);
            this.checkBoxWrite.TabIndex = 13;
            this.checkBoxWrite.Text = "écraser";
            this.checkBoxWrite.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.checkBoxWrite);
            this.Controls.Add(this.checkBoxCreate);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.labelWrite);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCreate;
        private TextBox textBoxDirectory;
        private TextBox textBoxFileName;
        private Label labelCreate;
        private Label label1;
        private Label label2;
        private Button buttonDelete;
        private Label labelDelete;
        private RichTextBox richTextBox1;
        private Button buttonWrite;
        private Label labelWrite;
        private Button buttonRead;
        private CheckBox checkBoxCreate;
        private CheckBox checkBoxWrite;
    }
}