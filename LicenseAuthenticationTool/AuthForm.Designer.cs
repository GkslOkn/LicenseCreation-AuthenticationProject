namespace LicenseAuthenticationTool
{
    partial class AuthForm
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
            buttonSelectFile = new Button();
            buttonAuthLic = new Button();
            label1 = new Label();
            textBoxInputId = new TextBox();
            SuspendLayout();
            // 
            // buttonSelectFile
            // 
            buttonSelectFile.Location = new Point(12, 382);
            buttonSelectFile.Name = "buttonSelectFile";
            buttonSelectFile.Size = new Size(200, 50);
            buttonSelectFile.TabIndex = 0;
            buttonSelectFile.Text = "Select License File";
            buttonSelectFile.UseVisualStyleBackColor = true;
            buttonSelectFile.Click += buttonSelectFile_Click;
            // 
            // buttonAuthLic
            // 
            buttonAuthLic.Location = new Point(766, 195);
            buttonAuthLic.Name = "buttonAuthLic";
            buttonAuthLic.Size = new Size(200, 50);
            buttonAuthLic.TabIndex = 1;
            buttonAuthLic.Text = "Authenticate License";
            buttonAuthLic.UseVisualStyleBackColor = true;
            buttonAuthLic.Click += buttonAuthLic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 2;
            label1.Text = "Customer ID";
            // 
            // textBoxInputId
            // 
            textBoxInputId.Location = new Point(12, 37);
            textBoxInputId.Name = "textBoxInputId";
            textBoxInputId.Size = new Size(250, 31);
            textBoxInputId.TabIndex = 4;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 444);
            Controls.Add(textBoxInputId);
            Controls.Add(label1);
            Controls.Add(buttonAuthLic);
            Controls.Add(buttonSelectFile);
            Name = "AuthForm";
            Text = "License Authentication Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSelectFile;
        private Button buttonAuthLic;
        private Label label1;
        private TextBox textBoxInputId;
    }
}
