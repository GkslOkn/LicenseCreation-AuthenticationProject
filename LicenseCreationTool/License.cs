using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseCreationTool
{
    public class License
    {
        public string? CustomerName { get; set; }
        public int CustomerId { get; set; }
        public DateTime LicenseExpDate { get; set; }

        public void SaveLicenseFile(string licContent)
        {
            SaveFileDialog licenseSaver = new SaveFileDialog();
            licenseSaver.Filter = "License Files | *.lic | All Files | *.*";
            licenseSaver.Title = "Please Select a Directory to Save License File";
            licenseSaver.DefaultExt = "lic";
            licenseSaver.AddExtension = true;

            if(licenseSaver.ShowDialog() == DialogResult.OK)
            {
                string saveLicPath = licenseSaver.FileName;

                try
                {
                    File.WriteAllText(saveLicPath, licContent);

                    MessageBox.Show("License Filed Saved Successfully", "License Saved", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An Error Has Occurred: {ex.Message}", "ERROR", MessageBoxButtons.OK);
                }
            }
        }

    }
}
