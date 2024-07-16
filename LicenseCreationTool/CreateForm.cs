using System;
using System.Security.Cryptography;

namespace LicenseCreationTool
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void buttonCreateLic_Click(object sender, EventArgs e)
        {
            License CustomerLicense = new License()
            {
                CustomerName = textBoxCustomerName.Text,
                CustomerId = Convert.ToInt32(textBoxCustomerId.Text),
                LicenseExpDate = Convert.ToDateTime(dtPickerExpDate.Text)
            };

            string LicInfoCombined = $"{CustomerLicense.CustomerName}?{CustomerLicense.CustomerId}?{CustomerLicense.LicenseExpDate}";
            string EncryptedLicense = String.Empty;

            using (Aes aesEncryptor = Aes.Create())
            {
                aesEncryptor.GenerateKey();
                aesEncryptor.GenerateIV();
                byte[] aesKey = aesEncryptor.Key;
                byte[] aesIv = aesEncryptor.IV;

                Environment.SetEnvironmentVariable("aesEncryptKey",Convert.ToBase64String(aesKey),EnvironmentVariableTarget.User);
                Environment.SetEnvironmentVariable("aesEncryptIv", Convert.ToBase64String(aesIv), EnvironmentVariableTarget.User);

                EncryptedLicense = Encryptor.AESEncrypt(LicInfoCombined, aesKey, aesIv);
            }

            CustomerLicense.SaveLicenseFile(EncryptedLicense);
            MessageBox.Show($"License Created.\nCustomer Name: {CustomerLicense.CustomerName}\nCustomer ID: {CustomerLicense.CustomerId}\nLicense Expiration Date: {CustomerLicense.LicenseExpDate}", "License Created", MessageBoxButtons.OK);
        }
    }
}
