using Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Configurations
{
    public static class ConfigarationManager
    {

        public static CfgDTO InitializeCFG()
        {
            try
            {
                CfgDTO cfgDetails = new CfgDTO();
                DataSet dbConDataSet;
#pragma warning disable CS0168 // The variable 'database' is declared but never used
                string database;
#pragma warning restore CS0168 // The variable 'database' is declared but never used
                string dataSource = string.Empty;
                string userID = string.Empty;
                string password = string.Empty;
                string initialCatalog = string.Empty;
                string con = string.Empty;
#pragma warning disable CS0168 // The variable 'oSqlConnectionStringBuilder' is declared but never used
                SqlConnectionStringBuilder oSqlConnectionStringBuilder;
#pragma warning restore CS0168 // The variable 'oSqlConnectionStringBuilder' is declared but never used
                dbConDataSet = new DataSet();
                dbConDataSet.ReadXml(@"C:\int\CONFIG.CFG");

                database = dbConDataSet.Tables[0].Rows[0]["Database"].ToString();
                dataSource = dbConDataSet.Tables[0].Rows[0]["DataSource"].ToString();
                userID = dbConDataSet.Tables[0].Rows[0]["UserID"].ToString();
                password = dbConDataSet.Tables[0].Rows[0]["Password"].ToString();
                initialCatalog = dbConDataSet.Tables[0].Rows[0]["InitialCatalogue"].ToString();
                con = dbConDataSet.Tables[0].Rows[0]["con"].ToString();

                cfgDetails.DataSource = dataSource;
                cfgDetails.UserID = userID;
                cfgDetails.Password = password;
                cfgDetails.InitialCatalog = initialCatalog;
                cfgDetails.con = con;
                return cfgDetails;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string get_connetion()
        {
            CfgDTO oCfgDTO = new CfgDTO();
            oCfgDTO = InitializeCFG();
            return oCfgDTO.con;
        }
    }
}
