using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Ticari_Otomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            TxtMail.Text = mail;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SmtpClient istemci = new SmtpClient();
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            istemci.Credentials = new NetworkCredential("eposta@gmail.com","123");
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("eposta@gmail.com", "Emirhan");

            mail.To.Add(TxtMail.Text);
            mail.Subject = TxtKonu.Text;
            mail.IsBodyHtml = true;
            mail.Body = TxtMesaj.Text;
            istemci.Send(mail);


        }
    }
}
