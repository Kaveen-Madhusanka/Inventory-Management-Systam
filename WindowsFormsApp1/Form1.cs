using BLogic.BL;
using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        #region Variabeles

        StockBL oStockBL = new StockBL();

        #endregion Variabeles 

        #region Initialize

        public Form1()
        {
            InitializeComponent();
        }


        #endregion Initialize 

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStock();
            dgvStock.AutoGenerateColumns = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
            LoadStock();
        }

        private void btnIncrees_Click(object sender, EventArgs e)
        {
            IncreesQuntity();
            LoadStock();
        }

        private void btnDecrees_Click(object sender, EventArgs e)
        {
            DecreesQuntity();
            LoadStock();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateItem();
            LoadStock();
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                loadTextBox(e.RowIndex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void txtQuntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #endregion Events 

        #region Methods
        private void AddItem()
        {
            try
            {
                if (!txtItemID.Text.Trim().Equals(string.Empty))
                {
                    StockDTO oStockDTO = new StockDTO();
                    oStockDTO.itemID = txtItemID.Text.Trim();
                    oStockDTO.Oilseal = txtOilSeal.Text.Trim();
                    oStockDTO.Quntity = Convert.ToInt32(txtQuntity.Text.Trim());
                    oStockDTO.StausCode = txtStatusCod.Text.Trim();
                    oStockDTO.Supplier = txtSupplir.Text.Trim();
                    if (oStockBL.InsertItem(oStockDTO))
                    {
                        ClearControls();
                        MessageBox.Show("Item inserted successfully.!");
                    }
                }
                else
                {
                    txtItemID.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadStock()
        {
           dgvStock.DataSource= oStockBL.LoadStock();
        }

        private void IncreesQuntity()
        {
            if (txtQuntity.Text != string.Empty)
            {
                try
                {
                    if (oStockBL.increesStock(txtItemID.Text,Convert.ToInt32(txtQuntity.Text)))
                    {
                        ClearControls();
                        MessageBox.Show("Item Increesed successfully.!");
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }

        private void DecreesQuntity()
        {
            if (txtQuntity.Text != string.Empty)
            {
                try
                {
                    if (oStockBL.decreesStock(txtItemID.Text, Convert.ToInt32(txtQuntity.Text)))
                    {
                        ClearControls();
                        MessageBox.Show("Item Decreesed successfully.!");
                    }
                    else
                    {
                        MessageBox.Show("Quntity is not enough in hand.!");
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }

        private void UpdateItem()
        {
            try
            {
                if (!txtItemID.Text.Trim().Equals(string.Empty))
                {
                    StockDTO oStockDTO = new StockDTO();
                    oStockDTO.itemID = txtItemID.Text.Trim();
                    oStockDTO.Oilseal = txtOilSeal.Text.Trim();
                    oStockDTO.Quntity = Convert.ToInt32(txtQuntity.Text.Trim());
                    oStockDTO.StausCode = txtStatusCod.Text.Trim();
                    oStockDTO.Supplier = txtSupplir.Text.Trim();
                    if (oStockBL.UpdateStock(oStockDTO))
                    {
                        ClearControls();
                        MessageBox.Show("Item Updated successfully.!");
                    }
                }
                else
                {
                    txtItemID.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void loadTextBox(int i)
        {
            try
            {
                txtItemID.Text = dgvStock.Rows[i].Cells[0].Value.ToString();
                txtOilSeal.Text = dgvStock.Rows[i].Cells[1].Value.ToString();
                txtQuntity.Text = dgvStock.Rows[i].Cells[2].Value.ToString();
                txtStatusCod.Text = dgvStock.Rows[i].Cells[3].Value.ToString();
                txtSupplir.Text = dgvStock.Rows[i].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SearchItem()
        {
            dgvStock.DataSource = oStockBL.searchItem(txtSearch.Text);
        }

        private void ClearControls()
        {
            txtItemID.Text = string.Empty;
            txtOilSeal.Text = string.Empty;
            txtQuntity.Text = string.Empty;
            txtStatusCod.Text = string.Empty;
            txtSupplir.Text = string.Empty;
        }


        #endregion Methods 


    }
}
