using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Data.SqlClient;

namespace LicenseAuthenticationTool
{
    public class License
    {
        public string? CustomerName { get; set; }
        public int CustomerId { get; set; }
        public DateTime LicenseExpDate { get; set; }

        public void LicenseStringSplitter(string strToSplit)
        {
            string[] licInfo = strToSplit.Split('?');

            CustomerName = licInfo[0];
            CustomerId = Convert.ToInt32(licInfo[1]);
            LicenseExpDate = DateTime.Parse(licInfo[2]);
        }

        public bool LicenseChecker(int inputCustomerId)
        {
            bool checkResult = (inputCustomerId == CustomerId) ? LicenseDateChecker() : false;
            return checkResult;
        }

        public bool LicenseDateChecker()
        {
            bool checkDateResult = (DateTime.Now <= LicenseExpDate) ? true : false;
            return checkDateResult;
        }

        public void AddLicenseToDatabase()
        {
            string connQuery = "Server=DMGM0341698;Database=interndb;Trusted_Connection=True;TrustServerCertificate=True;";
            string insertQuery = "INSERT INTO dbo.LicenseDataTable (CustomerName, CustomerId, LicenseExpDate) VALUES (@customerName, @customerId, @licenseExpirationDate)";

            using (SqlConnection dbConnection = new SqlConnection(connQuery))
            {
                dbConnection.Open();

                using (SqlCommand dbCommand = new SqlCommand(insertQuery, dbConnection))
                {
                    dbCommand.Parameters.AddWithValue("@customerName", CustomerName);
                    dbCommand.Parameters.AddWithValue("@customerId", CustomerId);
                    dbCommand.Parameters.AddWithValue("@licenseExpirationDate", LicenseExpDate);

                    int rows = dbCommand.ExecuteNonQuery();
                    MessageBox.Show($"{rows} rows affected by query.", "Query", MessageBoxButtons.OK);
                }
            }
        }
    }
}

// 
//      
// }
//
//
