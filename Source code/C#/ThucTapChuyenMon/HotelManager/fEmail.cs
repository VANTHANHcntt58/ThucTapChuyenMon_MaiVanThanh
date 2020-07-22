using HotelManager.DAO;
using HotelManager.DTO;
using System;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace HotelManager
{
    public partial class fEmail : Form
    {
        #region Constructor
        public fEmail()
        {
            InitializeComponent();
            
        }
        #endregion    
        Attachment attachment = null;
        private void btnClose__Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbFile.Text = dialog.FileName;
            }
        }
        void GuiMail(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            if (attachment != null) 
            {
                mess.Attachments.Add(attachment);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential(txbUserName.Text, txbPass.Text);

            client.Send(mess);
        }
        private void btnSentEmail_Click(object sender, EventArgs e)
        {
            attachment = null;
            try
            {
                FileInfo file = new FileInfo(txbFile.Text);
                attachment = new Attachment(txbFile.Text);
            }
            catch { }
           /* StreamReader sr = new StreamReader(txbToCustomer.Text);

            string email;*/

            if (!CheckFillInText(new Control[] { txbMess, txbPass, txbSubject, txbToCustomer, txbUserName }))
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                GuiMail(txbUserName.Text, txbToCustomer.Text, txbSubject.Text, txbMess.Text, attachment);
                MessageBox.Show("Gửi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lỗi khi gửi mail!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool CheckFillInText(Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control.Text == string.Empty)
                    return false;
            }
            return true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbToCustomer.Text = dialog.FileName;
            }
        }
    }
}
