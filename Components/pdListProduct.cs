using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Components
{
    public partial class pdListProduct : Form
    {
        public pdListProduct()
        {
            InitializeComponent();
            loadDTRV();
        }


        //load Datadridview
        private void loadDTRV()
        {
            db.Categories.Load();
            db.Products.Load();
            dgvCategory.DataSource = db.Categories.Local.ToBindingList();
            dgvProduct.DataSource = db.Products.Local.ToBindingList();
            deletePdtxt();
            deleteCatetxt();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pdListProduct_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ccbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Model1 db = new Model1();

        //Product
        private Product product = new Product();
        private void deletePdtxt()
        {
            txtProductName.Clear();
            txtIDCate.Clear();
            txtPrice.Clear();
            txtProductName.Focus();
            dgvProduct.Columns["Category"].Visible = false;
        }
            // add product
        private void btnAddPD_Click(object sender, EventArgs e)
        {
            try{
                product.nameProduct = txtProductName.Text.Trim();
                product.idCategory = Int32.Parse(txtIDCate.Text.Trim());
                product.priceProduct = double.Parse(txtPrice.Text.Trim());
                db.Products.Add(product);
                db.SaveChanges();
                dgvProduct.DataSource = db.Products.Local.ToBindingList();
                deletePdtxt();
            }
            catch
            {
                MessageBox.Show("Fail!");
            }
        }
            // edit product
        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(dgvProduct.CurrentRow.Cells["IDProduct"].Value.ToString());
                product = db.Products.Where(x => x.id == id).FirstOrDefault();
                txtProductName.Text = product.nameProduct;
                txtPrice.Text = product.priceProduct.ToString();
                txtIDCate.Text = product.idCategory.ToString();
                txtProductName.Focus();
            }
        }        
        private void btnEditPD_Click(object sender, EventArgs e)
        {
            product.nameProduct = txtProductName.Text.Trim();
            product.idCategory = Int32.Parse(txtIDCate.Text.Trim());
            product.priceProduct = double.Parse(txtPrice.Text.Trim());
            if (product.id == 0) //INSERT
                db.Products.Add(product);
            else // EDIT
                db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            dgvProduct.DataSource = db.Products.Local.ToBindingList();
            deletePdtxt();
            MessageBox.Show("Sucess!");
        }
            // remove product
        private void btnRemovePD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var entry = db.Entry(product);
                if (entry.State == EntityState.Detached)
                    db.Products.Attach(product);
                db.Products.Remove(product);
                db.SaveChanges();
                dgvProduct.DataSource = db.Products.Local.ToBindingList();
                deletePdtxt();
                MessageBox.Show("Sucessfully!");
            }
        }
            //delete all
        private void btnDeleteAllPD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Products.RemoveRange(db.Products);
                db.SaveChanges();
                dgvProduct.DataSource = db.Products.Local.ToBindingList();
                deletePdtxt();
                MessageBox.Show("Sucessfully!"); ;
            }
        }
            //find product
        private void iconSearchPD_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProduct.Rows.Clear();
                foreach (Product item in db.Products)
                {
                    if (txtSearchPD.Text == item.nameProduct)
                    {
                        dgvProduct.DataSource = item;
                    }
                }
        }
            catch
            {
                MessageBox.Show("Not Find!");
            }
        }

        //End Product

        //Category
        private Category category = new Category();
        private void deleteCatetxt()
        {
            txtCategoryName.Clear();
            txtCategoryName.Focus();
            dgvCategory.Columns["Products"].Visible = false;
        }


        // add category
        private void btnAddCTY_Click(object sender, EventArgs e)
        {
            try
            {
                category.nameCategory = txtCategoryName.Text.Trim();
                db.Categories.Add(category);
                db.SaveChanges();
                dgvCategory.DataSource = db.Categories.Local.ToBindingList();
                deleteCatetxt();
            }
            catch
            {
                MessageBox.Show("Fail!");
            }

        } 
            // edit category
        private void dgvCategory_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCategory.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(dgvCategory.CurrentRow.Cells["ID"].Value.ToString());
                category = db.Categories.Where(x => x.id == id).FirstOrDefault();
                txtCategoryName.Text = category.nameCategory;
            }
        }
        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            category.nameCategory = txtCategoryName.Text.Trim();
            if (category.id == 0) //INSERT
                db.Categories.Add(category);
            else // EDIT
                db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
            dgvCategory.DataSource = db.Categories.Local.ToBindingList();
            deleteCatetxt();
            MessageBox.Show("Sucess!");
        }


            // remove category
        private void btnRemoveCate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var entry = db.Entry(category);
                if (entry.State == EntityState.Detached)
                    db.Categories.Attach(category);
                db.Categories.Remove(category);
                db.SaveChanges();
                dgvCategory.DataSource = db.Categories.Local.ToBindingList();
                deleteCatetxt();
                MessageBox.Show("Sucessfully!");
            }
        }

        //find cate
        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProduct.Rows.Clear();
                foreach (Product item in db.Products)
                {
                    if (txtSearch.Text.Trim() == item.nameProduct)
                    {

                    }
                }
            }
            catch
            {
                MessageBox.Show("Not Find!");
            }
        }

    }
        //End Category
}

//try
//{

//}
//catch
//{
//    MessageBox.Show("Fail!");
//}
