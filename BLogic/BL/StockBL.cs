using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using Model.Model;
using Common.Configurations;
using System.Data;

namespace BLogic.BL
{
    public class StockBL
    {
        private StringBuilder sb = new StringBuilder();
        static string connection = ConfigarationManager.get_connetion();
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Inventoryconn"].ConnectionString);
        SqlConnection conn = new SqlConnection(connection);

        public bool InsertItem(StockDTO oStockDTO)
        {
            bool result = false;
            try
            {
                sb.Clear();
                sb.Append("INSERT INTO [StockTbl]");
                sb.Append(" VALUES (");
                sb.Append(" @itemID,");
                sb.Append(" @Oilseal,");
                sb.Append(" @Quntity,");
                sb.Append(" @StausCode,");
                sb.Append(" @Supplier");
                sb.Append(" )");

                using (SqlCommand command = new SqlCommand(sb.ToString(), conn))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("itemID", oStockDTO.itemID);
                    command.Parameters.AddWithValue("Oilseal", oStockDTO.Oilseal);
                    command.Parameters.AddWithValue("Quntity", oStockDTO.Quntity);
                    command.Parameters.AddWithValue("StausCode", oStockDTO.StausCode);
                    command.Parameters.AddWithValue("Supplier", oStockDTO.Supplier);

                    conn.Open();
                    if (command.ExecuteNonQuery() > 0)
                        result = true;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<StockDTO> LoadStock()
        {
            List<StockDTO> stockList = new List<StockDTO>();

            try
            {
                sb.Clear();
                sb.Append("SELECT itemID, Oilseal, Quntity,StausCode,Supplier");
                sb.Append(" FROM [StockTbl]");

                SqlCommand command = new SqlCommand(sb.ToString(), conn);
                conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader != null && reader.Read())
                        {
                            StockDTO oStock= new StockDTO();
                            oStock.itemID = reader["itemID"].ToString();
                            oStock.Oilseal = reader["Oilseal"].ToString();
                            oStock.Quntity = Convert.ToInt32(reader["Quntity"].ToString());
                            oStock.StausCode = reader["StausCode"].ToString();
                            oStock.Supplier = reader["Supplier"].ToString();
                            stockList.Add(oStock);
                        }
                    }


               
                return stockList;
                
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool UpdateStock(StockDTO oStockDTO)
        {
            bool result = false;
            try
            {
                sb.Clear();
                sb.Append("UPDATE  [StockTbl]");
                sb.Append(" SET ");
                sb.Append(" Oilseal=@Oilseal,");
                sb.Append(" Quntity=@Quntity,");
                sb.Append(" StausCode=@StausCode,");
                sb.Append(" Supplier=@Supplier");
                sb.Append(" WHERE itemID =@itemID");

                using (SqlCommand command = new SqlCommand(sb.ToString(), conn))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("itemID", oStockDTO.itemID);
                    command.Parameters.AddWithValue("Oilseal", oStockDTO.Oilseal);
                    command.Parameters.AddWithValue("Quntity", oStockDTO.Quntity);
                    command.Parameters.AddWithValue("StausCode", oStockDTO.StausCode);
                    command.Parameters.AddWithValue("Supplier", oStockDTO.Supplier);

                    conn.Open();
                    if (command.ExecuteNonQuery() > 0)
                        result = true;

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int getItemQuntity(string itemId)
        {
            int quntity = 0;
            try
            {
                sb.Clear();
                sb.Append("SELECT Quntity");
                sb.Append(" FROM [StockTbl]");
                sb.Append(" WHERE itemID =@itemID");

                using (SqlCommand command = new SqlCommand(sb.ToString(), conn))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("itemID", itemId);

                    conn.Open();
                    quntity = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return quntity;
        }

        public bool increesStock(string itemId,int quntity)
        {
            bool result = false;
            int Oldquntity = getItemQuntity(itemId);

            try
            {
                sb.Clear();
                sb.Append("UPDATE  [StockTbl]");
                sb.Append(" SET ");
                sb.Append(" Quntity=@Quntity");
                sb.Append(" WHERE itemID =@itemID");

                using (SqlCommand command = new SqlCommand(sb.ToString(), conn))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("itemID", itemId);
                    command.Parameters.AddWithValue("Quntity", Oldquntity+ quntity);

                    conn.Open();
                    if (command.ExecuteNonQuery() > 0)
                        result = true;

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool decreesStock(string itemId, int quntity)
        {
            bool result = false;
            int Oldquntity = getItemQuntity(itemId);

            try
            {
                sb.Clear();
                sb.Append("UPDATE  [StockTbl]");
                sb.Append(" SET ");
                sb.Append(" Quntity=@Quntity");
                sb.Append(" WHERE itemID =@itemID");

                using (SqlCommand command = new SqlCommand(sb.ToString(), conn))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("itemID", itemId);
                    command.Parameters.AddWithValue("Quntity", Oldquntity - quntity);

                    conn.Open();
                    if (Oldquntity >= quntity)
                    {
                        if (command.ExecuteNonQuery() > 0)
                            result = true;
                    }
                    
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public List<StockDTO> searchItem(string itemId)
        {
            List<StockDTO> oStocks = new List<StockDTO>();
            try
            {
                sb.Clear();
                sb.Append("SELECT itemID, Oilseal, Quntity,StausCode,Supplier");
                sb.Append(" FROM [StockTbl]");
                sb.Append(" WHERE itemID Like '%"+ itemId + "%'");

                SqlCommand command = new SqlCommand(sb.ToString(), conn);

                conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        StockDTO oStock = new StockDTO();
                        oStock.itemID = reader["itemID"].ToString();
                        oStock.Oilseal = reader["Oilseal"].ToString();
                        oStock.Quntity = Convert.ToInt32(reader["Quntity"].ToString());
                        oStock.StausCode = reader["StausCode"].ToString();
                        oStock.Supplier = reader["Supplier"].ToString();
                        oStocks.Add(oStock);
                    }
                }



                return oStocks;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        
    }
}
