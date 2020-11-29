namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtOilSeal = new System.Windows.Forms.TextBox();
            this.txtQuntity = new System.Windows.Forms.TextBox();
            this.txtStatusCod = new System.Windows.Forms.TextBox();
            this.txtSupplir = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnIncrees = new System.Windows.Forms.Button();
            this.btnDecrees = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oilseal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StausCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oil seal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quntity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Staus Code :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Supplier :";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(170, 42);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(100, 20);
            this.txtItemID.TabIndex = 5;
            // 
            // txtOilSeal
            // 
            this.txtOilSeal.Location = new System.Drawing.Point(170, 70);
            this.txtOilSeal.Name = "txtOilSeal";
            this.txtOilSeal.Size = new System.Drawing.Size(100, 20);
            this.txtOilSeal.TabIndex = 5;
            // 
            // txtQuntity
            // 
            this.txtQuntity.Location = new System.Drawing.Point(170, 97);
            this.txtQuntity.Name = "txtQuntity";
            this.txtQuntity.Size = new System.Drawing.Size(100, 20);
            this.txtQuntity.TabIndex = 5;
            this.txtQuntity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuntity_KeyPress);
            // 
            // txtStatusCod
            // 
            this.txtStatusCod.Location = new System.Drawing.Point(170, 124);
            this.txtStatusCod.Name = "txtStatusCod";
            this.txtStatusCod.Size = new System.Drawing.Size(100, 20);
            this.txtStatusCod.TabIndex = 5;
            // 
            // txtSupplir
            // 
            this.txtSupplir.Location = new System.Drawing.Point(170, 150);
            this.txtSupplir.Name = "txtSupplir";
            this.txtSupplir.Size = new System.Drawing.Size(100, 20);
            this.txtSupplir.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(41, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnIncrees
            // 
            this.btnIncrees.Location = new System.Drawing.Point(78, 224);
            this.btnIncrees.Name = "btnIncrees";
            this.btnIncrees.Size = new System.Drawing.Size(75, 23);
            this.btnIncrees.TabIndex = 6;
            this.btnIncrees.Text = "Increes";
            this.btnIncrees.UseVisualStyleBackColor = true;
            this.btnIncrees.Click += new System.EventHandler(this.btnIncrees_Click);
            // 
            // btnDecrees
            // 
            this.btnDecrees.Location = new System.Drawing.Point(177, 224);
            this.btnDecrees.Name = "btnDecrees";
            this.btnDecrees.Size = new System.Drawing.Size(75, 23);
            this.btnDecrees.TabIndex = 6;
            this.btnDecrees.Text = "Decrees";
            this.btnDecrees.UseVisualStyleBackColor = true;
            this.btnDecrees.Click += new System.EventHandler(this.btnDecrees_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.Oilseal,
            this.Quntity,
            this.StausCode,
            this.Supplier});
            this.dgvStock.Location = new System.Drawing.Point(290, 70);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(543, 219);
            this.dgvStock.TabIndex = 7;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(661, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Search:";
            // 
            // itemID
            // 
            this.itemID.DataPropertyName = "itemID";
            this.itemID.HeaderText = "Item Id";
            this.itemID.Name = "itemID";
            // 
            // Oilseal
            // 
            this.Oilseal.DataPropertyName = "Oilseal";
            this.Oilseal.HeaderText = "Oil Seal ";
            this.Oilseal.Name = "Oilseal";
            // 
            // Quntity
            // 
            this.Quntity.DataPropertyName = "Quntity";
            this.Quntity.HeaderText = "Quntity";
            this.Quntity.Name = "Quntity";
            // 
            // StausCode
            // 
            this.StausCode.DataPropertyName = "StausCode";
            this.StausCode.HeaderText = "Staus Code";
            this.StausCode.Name = "StausCode";
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(203, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 362);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.btnDecrees);
            this.Controls.Add(this.btnIncrees);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSupplir);
            this.Controls.Add(this.txtStatusCod);
            this.Controls.Add(this.txtQuntity);
            this.Controls.Add(this.txtOilSeal);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtOilSeal;
        private System.Windows.Forms.TextBox txtQuntity;
        private System.Windows.Forms.TextBox txtStatusCod;
        private System.Windows.Forms.TextBox txtSupplir;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnIncrees;
        private System.Windows.Forms.Button btnDecrees;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oilseal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StausCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.Button btnClear;
    }
}

