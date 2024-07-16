namespace LicenseCreationTool
{
    partial class CreateForm
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
            labelCustomerName = new Label();
            labelCustomerId = new Label();
            labelExpTime = new Label();
            textBoxCustomerName = new TextBox();
            textBoxCustomerId = new TextBox();
            dtPickerExpDate = new DateTimePicker();
            buttonCreateLic = new Button();
            SuspendLayout();
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(12, 9);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(141, 25);
            labelCustomerName.TabIndex = 0;
            labelCustomerName.Text = "Customer Name";
            // 
            // labelCustomerId
            // 
            labelCustomerId.AutoSize = true;
            labelCustomerId.Location = new Point(12, 182);
            labelCustomerId.Name = "labelCustomerId";
            labelCustomerId.Size = new Size(112, 25);
            labelCustomerId.TabIndex = 1;
            labelCustomerId.Text = "Customer ID";
            // 
            // labelExpTime
            // 
            labelExpTime.AutoSize = true;
            labelExpTime.Location = new Point(12, 373);
            labelExpTime.Name = "labelExpTime";
            labelExpTime.Size = new Size(132, 25);
            labelExpTime.TabIndex = 2;
            labelExpTime.Text = "Expiration Date";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(12, 37);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(250, 31);
            textBoxCustomerName.TabIndex = 3;
            // 
            // textBoxCustomerId
            // 
            textBoxCustomerId.Location = new Point(12, 210);
            textBoxCustomerId.Name = "textBoxCustomerId";
            textBoxCustomerId.Size = new Size(250, 31);
            textBoxCustomerId.TabIndex = 4;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(12, 401);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(300, 31);
            dtPickerExpDate.TabIndex = 5;
            // 
            // buttonCreateLic
            // 
            buttonCreateLic.Location = new Point(766, 200);
            buttonCreateLic.Name = "buttonCreateLic";
            buttonCreateLic.Size = new Size(200, 50);
            buttonCreateLic.TabIndex = 6;
            buttonCreateLic.Text = "Create License";
            buttonCreateLic.UseVisualStyleBackColor = true;
            buttonCreateLic.Click += buttonCreateLic_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 444);
            Controls.Add(buttonCreateLic);
            Controls.Add(dtPickerExpDate);
            Controls.Add(textBoxCustomerId);
            Controls.Add(textBoxCustomerName);
            Controls.Add(labelExpTime);
            Controls.Add(labelCustomerId);
            Controls.Add(labelCustomerName);
            Name = "CreateForm";
            Text = "License Creation Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCustomerName;
        private Label labelCustomerId;
        private Label labelExpTime;
        private TextBox textBoxCustomerName;
        private TextBox textBoxCustomerId;
        private DateTimePicker dtPickerExpDate;
        private Button buttonCreateLic;
    }
}
