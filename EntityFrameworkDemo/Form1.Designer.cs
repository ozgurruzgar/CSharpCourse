
namespace EntityFrameworkDemo
{
    partial class Form1
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nameTbx = new System.Windows.Forms.TextBox();
            this.stockAmountTbx = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.unitPriceTbx = new System.Windows.Forms.TextBox();
            this.GbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.stockAmountLbl = new System.Windows.Forms.Label();
            this.unitPriceLbl = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btn_GtById = new System.Windows.Forms.Button();
            this.gbxUpdate.SuspendLayout();
            this.GbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 424);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(188, 30);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.nameTbx);
            this.gbxUpdate.Controls.Add(this.stockAmountTbx);
            this.gbxUpdate.Controls.Add(this.lblname);
            this.gbxUpdate.Controls.Add(this.lblStockAmount);
            this.gbxUpdate.Controls.Add(this.lblUnitPrice);
            this.gbxUpdate.Controls.Add(this.unitPriceTbx);
            this.gbxUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxUpdate.Location = new System.Drawing.Point(451, 216);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(384, 202);
            this.gbxUpdate.TabIndex = 12;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(259, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 59);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // nameTbx
            // 
            this.nameTbx.Location = new System.Drawing.Point(110, 29);
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(125, 26);
            this.nameTbx.TabIndex = 2;
            // 
            // stockAmountTbx
            // 
            this.stockAmountTbx.Location = new System.Drawing.Point(110, 154);
            this.stockAmountTbx.Name = "stockAmountTbx";
            this.stockAmountTbx.Size = new System.Drawing.Size(125, 26);
            this.stockAmountTbx.TabIndex = 6;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(57, 32);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(47, 18);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(5, 157);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(99, 18);
            this.lblStockAmount.TabIndex = 5;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(36, 91);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(68, 18);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // unitPriceTbx
            // 
            this.unitPriceTbx.Location = new System.Drawing.Point(110, 88);
            this.unitPriceTbx.Name = "unitPriceTbx";
            this.unitPriceTbx.Size = new System.Drawing.Size(125, 26);
            this.unitPriceTbx.TabIndex = 4;
            // 
            // GbxAdd
            // 
            this.GbxAdd.Controls.Add(this.btnAdd);
            this.GbxAdd.Controls.Add(this.tbxName);
            this.GbxAdd.Controls.Add(this.tbxStockAmount);
            this.GbxAdd.Controls.Add(this.nameLbl);
            this.GbxAdd.Controls.Add(this.stockAmountLbl);
            this.GbxAdd.Controls.Add(this.unitPriceLbl);
            this.GbxAdd.Controls.Add(this.tbxUnitPrice);
            this.GbxAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GbxAdd.Location = new System.Drawing.Point(12, 216);
            this.GbxAdd.Name = "GbxAdd";
            this.GbxAdd.Size = new System.Drawing.Size(384, 202);
            this.GbxAdd.TabIndex = 11;
            this.GbxAdd.TabStop = false;
            this.GbxAdd.Text = "Add a Product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(259, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 59);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(110, 29);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(125, 26);
            this.tbxName.TabIndex = 2;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(110, 154);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(125, 26);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(57, 32);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(47, 18);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            // 
            // stockAmountLbl
            // 
            this.stockAmountLbl.AutoSize = true;
            this.stockAmountLbl.Location = new System.Drawing.Point(5, 157);
            this.stockAmountLbl.Name = "stockAmountLbl";
            this.stockAmountLbl.Size = new System.Drawing.Size(99, 18);
            this.stockAmountLbl.TabIndex = 5;
            this.stockAmountLbl.Text = "Stock Amount";
            // 
            // unitPriceLbl
            // 
            this.unitPriceLbl.AutoSize = true;
            this.unitPriceLbl.Location = new System.Drawing.Point(36, 91);
            this.unitPriceLbl.Name = "unitPriceLbl";
            this.unitPriceLbl.Size = new System.Drawing.Size(68, 18);
            this.unitPriceLbl.TabIndex = 3;
            this.unitPriceLbl.Text = "Unit Price";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(110, 88);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(125, 26);
            this.tbxUnitPrice.TabIndex = 4;
            // 
            // DgvProducts
            // 
            this.DgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Location = new System.Drawing.Point(12, 12);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.RowHeadersWidth = 51;
            this.DgvProducts.RowTemplate.Height = 29;
            this.DgvProducts.Size = new System.Drawing.Size(823, 188);
            this.DgvProducts.TabIndex = 10;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(215, 428);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(32, 20);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Ara";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(249, 424);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(202, 27);
            this.tbxSearch.TabIndex = 15;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btn_GtById
            // 
            this.btn_GtById.Location = new System.Drawing.Point(467, 422);
            this.btn_GtById.Name = "btn_GtById";
            this.btn_GtById.Size = new System.Drawing.Size(166, 29);
            this.btn_GtById.TabIndex = 16;
            this.btn_GtById.Text = "GetById";
            this.btn_GtById.UseVisualStyleBackColor = true;
            this.btn_GtById.Click += new System.EventHandler(this.btn_GtById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 460);
            this.Controls.Add(this.btn_GtById);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.GbxAdd);
            this.Controls.Add(this.DgvProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.GbxAdd.ResumeLayout(false);
            this.GbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox nameTbx;
        private System.Windows.Forms.TextBox stockAmountTbx;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox unitPriceTbx;
        private System.Windows.Forms.GroupBox GbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label stockAmountLbl;
        private System.Windows.Forms.Label unitPriceLbl;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btn_GtById;
    }
}

