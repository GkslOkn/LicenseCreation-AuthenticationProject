namespace LicenseAuthenticationTool
{
    public partial class AuthForm : Form
    {
        string licFilePath = string.Empty;
        string licFileContent = string.Empty;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog licenseReader = new OpenFileDialog();
            licenseReader.Filter = "License Files | *.lic";
            licenseReader.Title = "Please Select a License File";
            if(licenseReader.ShowDialog() == DialogResult.OK)
            {
                licFilePath = licenseReader.FileName;

                try
                {
                    licFileContent = File.ReadAllText(licFilePath);
                    MessageBox.Show("File Content:" + licFileContent,"File Content",MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Has Occurred: " + ex.Message, "ERROR",MessageBoxButtons.OK);
                }
            }
        }

        private void buttonAuthLic_Click(object sender, EventArgs e)
        {
            License CustomerLicense = new License();

            string? retrievedAesKeyString = Environment.GetEnvironmentVariable("aesEncryptKey", EnvironmentVariableTarget.User);
            string? retrievedAesIvString = Environment.GetEnvironmentVariable("aesEncryptIv", EnvironmentVariableTarget.User);

            byte[] aesKey = Convert.FromBase64String(retrievedAesKeyString);
            byte[] aesIv = Convert.FromBase64String(retrievedAesIvString);

            string decryptedLicContent = Decryptor.AESDecrypt(licFileContent, aesKey, aesIv);

            CustomerLicense.LicenseStringSplitter(decryptedLicContent);

            bool toActivate = CustomerLicense.LicenseChecker(Convert.ToInt32(textBoxInputId.Text));
            if (toActivate)
            {
                MessageBox.Show($"License Activated for: {CustomerLicense.CustomerName}", "License Activated", MessageBoxButtons.OK);

                CustomerLicense.AddLicenseToDatabase();
            }
            else
            {
                MessageBox.Show("Wrong License File or Expired License File. Please Try Again.", "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}