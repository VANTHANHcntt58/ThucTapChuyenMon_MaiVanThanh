using HotelManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fBill : Form
    {
        #region Constructor & Properties
        private readonly fPrintBill fPrintBill = new fPrintBill();

        public fBill()
        {
            InitializeComponent();
            dataGridViewBill.Font = new Font("Segoe UI", 9.75F);
            LoadFullBill(GetFullBill());
            comboboxID.DisplayMember = "ID";
          
        }

        #endregion

        #region Load
        private void LoadFullBill(DataTable table)
        {
            BindingSource source = new BindingSource();
            ChangePrice(table);
            source.DataSource = table;
            dataGridViewBill.DataSource = source;
            bindingBill.BindingSource = source;
            comboboxID.DataSource = source;

            txbDateCreate.DataBindings.Clear();
            txbName.DataBindings.Clear();
            txbPrice.DataBindings.Clear();
            txbStatusRoom.DataBindings.Clear();
            txbUser.DataBindings.Clear();
            txbDiscount.DataBindings.Clear();
            txbFinalPrice.DataBindings.Clear();

            txbDateCreate.DataBindings.Add("Text", source, "DateOfCreate");
            txbName.DataBindings.Add("Text", source, "roomName");
            txbPrice.DataBindings.Add("Text", source, "totalPrice");
            txbStatusRoom.DataBindings.Add("Text", source, "Name");
            txbUser.DataBindings.Add("Text", source, "StaffSetUp");
            txbDiscount.DataBindings.Add("Text", source, "discount");
            txbFinalPrice.DataBindings.Add("Text", source, "finalprice");
        }

        #endregion

        #region Change Text
        private void ChangePrice(DataTable table)
        {
            table.Columns.Add("totalPrice_New", typeof(string));
            table.Columns.Add("finalprice_New", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["finalprice_New"] = ((int)table.Rows[i]["finalprice"]).ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
                table.Rows[i]["totalPrice_New"] = ((int)table.Rows[i]["totalPrice"]).ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
            }
            table.Columns.Remove("finalprice");
            table.Columns.Remove("totalPrice");
            table.Columns["totalPrice_New"].ColumnName = "totalPrice";
            table.Columns["finalprice_New"].ColumnName = "finalprice";

        }
        private void BtnSeenBill_Click(object sender, EventArgs e)
        {
            if (comboboxID.Text != string.Empty)
            {
                if (!txbStatusRoom.Text.Contains("Ch"))
                {
                    fPrintBill.SetPrintBill(int.Parse(comboboxID.Text), txbDateCreate.Text);
                    fPrintBill.ShowDialog();
                }
                else
                    MessageBox.Show("Hoá đơn chưa thanh toán\nBạn không có quyền truy cập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
         #endregion


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search()
        {
            LoadFullBill(GetSearchBill(txbSearch.Text, cbBillSearch.SelectedIndex));
        }
        private DataTable GetFullBill()
        {
            return BillDAO.Instance.LoaddFullBill();
        }
        private DataTable GetSearchBill(string text, int mode)
        {
            return BillDAO.Instance.SearchBill(text, mode);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Text = txbSearch.Text.Trim();
            if (txbSearch.Text != string.Empty)
            {
                txbDateCreate.Text = string.Empty;
                txbName.Text = string.Empty;
                txbPrice.Text = string.Empty;
                txbStatusRoom.Text = string.Empty;
                txbUser.Text = string.Empty;

                btnSearch.Visible = false;
                btnCancel.Visible = true;
                Search();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadFullBill(GetFullBill());
            btnCancel.Visible = false;
            btnSearch.Visible = true;
        }

       
        private void TxbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnSearch_Click(sender, null);
            else
                if (e.KeyChar == 27 && btnCancel.Visible == true)
                btnCancel_Click(sender, null);
        }
        private void FBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27 && btnCancel.Visible == true)
                btnCancel_Click(sender, null);
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            fEmail fEmail = new fEmail();
            fEmail.ShowDialog();
            this.Show();
            Show();
        }
    }
}
