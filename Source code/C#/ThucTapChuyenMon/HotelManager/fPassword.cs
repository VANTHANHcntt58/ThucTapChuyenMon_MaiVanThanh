using HotelManager.DAO;
using HotelManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fPassword : Form
    {
        public fPassword(string userName)
        {
            InitializeComponent();
            //LoadProfile(userName);

        }
        string Password;

        public void UpdatePassword(string username, string password)
        {
            AccountDAO.Instance.UpdatePassword(username, password);
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.HashPass(txbPass.Text) ==Password&&txbNewPass.Text!=String.Empty&&txbReNewPass.Text!=String.Empty)
            {
                if(txbNewPass.Text==txbReNewPass.Text)
                {
                    UpdatePassword(txbUserName.Text, txbNewPass.Text);
                    MessageBox.Show( "Cập nhật mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbPass.Text = txbNewPass.Text = txbReNewPass.Text = String.Empty;
                    //LoadProfile(txbUserName.Text);
                }
                else
                {
                    MessageBox.Show( "Mật khẩu mới không hợp lệ.\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbNewPass.Text = txbReNewPass.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show( "Mật khẩu không hợp lệ.\nVui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPass.Text=txbNewPass.Text = txbReNewPass.Text = String.Empty;
            }   
        }

    
        private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnClose__Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
