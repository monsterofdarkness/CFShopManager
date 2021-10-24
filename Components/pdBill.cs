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
    public partial class pdBill : Form
    {
        public pdBill()
        {
            InitializeComponent();
            loadDTRV();
            fillCBB();
        }

        private Model1 db = new Model1();
        private Bill bills;
        private BillInfo billifo;
        private void loadDTRV()
        {
            db.Products.Load();
            db.BillInfoes.Load();
            db.Bills.Load();
            dgvMenu.DataSource = db.Products.Local.ToBindingList();
            dgvMenu.Columns["Category"].Visible = false;
            dgvListBills.DataSource = db.Bills.Local.ToBindingList();
            txtIDPD.Clear();
            txtQuantity.Clear();
            txtIDPD.Focus();
            deleteListBillTxt();
        }

        //fill combox form database

        private void fillCBB()
        {
            foreach(TableCF item in db.TableCFs)
            {
                cbTable.Items.Add(item.id);
            }

            foreach (Employee item in db.Employees)
            {
                cbEmployee.Items.Add(item.id);
            }
        }

        // Bills

        private void deleteListBillTxt()
        {
            txtIDCus.Clear();
            lbPriceBill.Text = "Price Bill: ";
            txtDisscountBill.Text = "0";
            lbAmount.Text = "AMOUNT: ";
            cbEmployee.ValueMember = "";
            cbTable.ValueMember = "";
            txtIDCus.Focus();
            dgvListBills.Columns["Customer"].Visible = false;
            dgvListBills.Columns["Employee"].Visible = false;
            dgvListBills.Columns["TableCF"].Visible = false;
            dgvListBills.Columns["BillInfoes"].Visible = false;
            dgvListBills.Columns["Revenue"].Visible = false;
        }
        public void bunifuButton7_Click(object sender, EventArgs e)
        {
            dgvBill.Rows.Clear();
            bills = new Bill();
            try
            {
                bills.idEm = Int32.Parse(cbEmployee.Text.Trim());
                bills.idCus = Int32.Parse(txtIDCus.Text.Trim());
                bills.idTable = Int32.Parse(cbTable.Text.Trim());
                bills.statusBill = 0;
                bills.DateCheckIn = DateTime.Now;

                db.Bills.Add(bills);
                db.SaveChanges();
                dgvListBills.DataSource = db.Bills.Local.ToBindingList();
                dgvBill.ClearSelection();
            }
            catch
            {
                MessageBox.Show("Fail");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {     
            bills.PriceBill = 0;
            bills.Amount = 0;
            foreach (BillInfo item in db.BillInfoes)
            {
                if(bills.id == item.idBill)
                {
                    bills.PriceBill += item.TotalMoney;
                }
            }
            lbPriceBill.Text = "Price Bill: " + bills.PriceBill.ToString();

            bills.Discount = float.Parse(txtDisscountBill.Text);

            bills.Amount = bills.PriceBill - bills.PriceBill*(bills.Discount / 100);
            lbAmount.Text = "AMOUNT: " + bills.Amount.ToString();

            db.Entry(bills).State = EntityState.Modified;
            db.SaveChanges();
            dgvListBills.DataSource = db.Bills.Local.ToBindingList();
            MessageBox.Show("Sucess!");
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            bills.statusBill = 1;
            bills.DateCheckOut = DateTime.Now;
            db.Entry(bills).State = EntityState.Modified;
            db.SaveChanges();
            dgvListBills.DataSource = db.Bills.Local.ToBindingList();
            deleteListBillTxt();
            MessageBox.Show("Sucess!");
        }        
        private void btnDeleteLB_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var entry = db.Entry(bills);
                    if (entry.State == EntityState.Detached)
                        db.Bills.Attach(bills);
                    db.Bills.Remove(bills);
                    db.SaveChanges();
                    dgvListBills.DataSource = db.Bills.Local.ToBindingList();
                    deleteBillTxt();
                    MessageBox.Show("Sucessfully!");
                }
            } 
            catch
            {
                MessageBox.Show("Fail!");
            }

        }
        private void dgvListBills_Click(object sender, EventArgs e)
        {
            if (dgvListBills.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(dgvListBills.CurrentRow.Cells["id"].Value.ToString());
                bills = db.Bills.Where(x => x.id == id).FirstOrDefault();
                txtIDCus.Text = bills.idCus.ToString();
            }
        }
        //Bill in4
        private void deleteBillTxt()
        {
            txtIDPD.Clear();
            txtQuantity.Clear();
            txtIDPD.Focus();
        }

        private float getPricePDS()
        {
            int idpdb = Int32.Parse(txtIDPD.Text);
            var count = db.Products.Count();
            foreach (Product item in db.Products)
            {
                if(idpdb == item.id)
                {
                    return (float)item.priceProduct;
                }
            }
            return 0;
        }

        private string getNamePDS()
        {
            int idpdb = Int32.Parse(txtIDPD.Text);
            var count = db.Products.Count();
            foreach (Product item in db.Products)
            {
                if (idpdb == item.id)
                {
                    return item.nameProduct;
                }
            }
            return "NoName";
        }

        private string getNameCate()
        {
            int idcate = 0;
            int idpdb = Int32.Parse(txtIDPD.Text);
            foreach(Product item in db.Products)
            {
                if (idpdb == item.id)
                {
                    idcate = item.idCategory;
                }
            }

            foreach (Category item in db.Categories)
            {
                if (idcate == item.id)
                {
                    return item.nameCategory;
                }
            }
            return "NoName";
        }

        private void dgvBill_Click(object sender, EventArgs e)
        {
            BillInfo billifo = new BillInfo();
            if (dgvBill.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(dgvBill.CurrentRow.Cells["IDBill"].Value.ToString());
                billifo = db.BillInfoes.Where(x => x.idBill == id).FirstOrDefault();
                txtIDPD.Text = billifo.idProduct.ToString();
                txtQuantity.Text = billifo.Quantity.ToString();
            }
        }
        private void btnAddtoBill_Click(object sender, EventArgs e)
        {
            billifo = new BillInfo();
            billifo.idProduct = Int32.Parse(txtIDPD.Text);
            billifo.Quantity = Int32.Parse(txtQuantity.Text);
            billifo.TotalMoney = 1.0 * getPricePDS() * billifo.Quantity;
            billifo.PricePDS = 1.0 * getPricePDS();
            billifo.idBill = bills.id;
            db.BillInfoes.Add(billifo);
            db.SaveChanges();
            //Insert to dgv
            dgvBill.Rows.Add(billifo.idBill, billifo.idProduct, getNamePDS(), billifo.PricePDS, billifo.Quantity, billifo.TotalMoney);
            deleteBillTxt();
        }

        private void btnDeletePD_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var entry = db.Entry(billifo);
                    if (entry.State == EntityState.Detached)
                        db.BillInfoes.Attach(billifo);
                    db.BillInfoes.Remove(billifo);
                    db.SaveChanges();
                    if (dgvBill.SelectedRows.Count > 0)
                    {
                        dgvBill.Rows.RemoveAt(this.dgvBill.SelectedRows[0].Index);
                    }
                    deleteBillTxt();
                    MessageBox.Show("Sucessfully!");
                }
            } 
            catch
            {
                MessageBox.Show("Fail!");
            }

        }
        // Print bill
        private float pripd, total;
        private string namepd;
        private int quan;
        private int pos = 280;
        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
               printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
                {
                    e.Graphics.DrawString("********** Welcome to GOOD COFFEE **********", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(45, 40));
                    e.Graphics.DrawString("**************** Your bill *****************", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(60, 50));
                    e.Graphics.DrawString("Time check in     :  " + this.bills.DateCheckIn, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(30, 120));
                    e.Graphics.DrawString("Time check out   :  " + this.bills.DateCheckOut, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(30, 130));
                    e.Graphics.DrawString("ID BILL               :  " + this.bills.id, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(30, 110));
                    e.Graphics.DrawString("TABLE                :  " + this.bills.idTable, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(30, 140));
                    e.Graphics.DrawString("ID EMPLOYEE    :  " + this.bills.idEm, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(30, 150));
                    e.Graphics.DrawString("ID CUSTOMER    :  " + this.bills.idCus, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(30, 160));
                    e.Graphics.DrawString("PRICE BILL       :  " + this.bills.PriceBill, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(30, 200));
                    e.Graphics.DrawString("DISSCOUNT      :  " + this.bills.Discount + " %", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(30, 210));
                    e.Graphics.DrawString("AMOUNT           :  " + this.bills.Amount, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(30, 220));

                    e.Graphics.DrawString("Product", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(20, 260));
                    e.Graphics.DrawString("SL", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(100, 260));
                    e.Graphics.DrawString("PricePDS", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(120, 260));
                    e.Graphics.DrawString("TotalMoney", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(190, 260));

                    foreach (DataGridViewRow row in dgvBill.Rows)
                    {

                        pripd = Convert.ToInt32(row.Cells["PricePDS"].Value);
                        quan = Convert.ToInt32(row.Cells["Quantity"].Value);
                        total = Convert.ToInt32(row.Cells["TotalMoney"].Value);
                        namepd = Convert.ToString(row.Cells["ProductName"].Value);

                        e.Graphics.DrawString("" + namepd, new Font("Arial", 4, FontStyle.Bold), Brushes.Black, new Point(20, pos + 20));
                        e.Graphics.DrawString("" + quan, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(100, pos + 20));
                        e.Graphics.DrawString("" + pripd, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(120, pos + 20));
                        e.Graphics.DrawString("" + total, new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(190, pos + 20));
                        pos += 20;
                    }

                    e.Graphics.DrawString("**************** THANKS YOU! *****************", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(60, 560));
                    e.Graphics.DrawString("************** SEE YOU AGAIN! ****************", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(60, 575));
                }
        //End bill

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pdBill_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }



        
    }
}
