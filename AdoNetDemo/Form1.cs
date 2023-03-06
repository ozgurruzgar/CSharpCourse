using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            DgvProducts.DataSource = _productDal.GetAll();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = nameLbl.Text,
                UnitPrice = decimal.Parse(unitPriceLbl.Text),
                StockAmount = int.Parse(stockAmountLbl.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Added.");
        }

        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = DgvProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPrice.Text = DgvProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmount.Text = DgvProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(DgvProducts.CurrentRow.Cells[0].Value),
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = int.Parse(tbxStockAmount.Text)
            };
            _productDal.Update(product);
            LoadProducts();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DgvProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            MessageBox.Show("deleted.");
        }

    }
}

