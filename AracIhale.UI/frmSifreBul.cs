using AracIhale.CORE;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmSifreBul : Form
    {
        public frmSifreBul(string formName)
        {
            InitializeComponent();
            frmName = formName;
        }
        UnitOfWork unitOfWork = new UnitOfWork();
        Validation validation=new Validation();
        string frmName;
        /// <summary>
        /// Formdan gelen verilen kontrol edildikten sonra kullanıcı adı ve kullanıcı adına bağlı email uyuşuyor ise kullanıcının mail adresine şifresi gönderiliyor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (frmName == "Anasayfa")
            {
                if (validation.IsValidateName(txtKullaniciAd, 2, 150, errorProvider1) && validation.IsValidateEmail(txtMail, errorProvider1))
                {
                    KullaniciVM kullanici = unitOfWork.KullaniciRepository.KullaniciGetir(txtKullaniciAd.Text);
                    string mail = unitOfWork.KullaniciIletisimRepository.GetEmailByUserName(txtKullaniciAd.Text);
                    if (txtMail.Text == mail)
                    {
                        SmtpClient client = new SmtpClient("smtp-relay.sendinblue.com", 587);
                        client.EnableSsl = true;
                        client.Timeout = 10000;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("ahmet_barcin@hotmail.com", "NscCdSt9M4G2ymQq");
                        MailMessage msg = new MailMessage();
                        msg.To.Add(txtMail.Text);
                        msg.From = new MailAddress("ahmet_barcin@hotmail.com");
                        msg.Subject = "Slytherin Arac Ihale";
                        msg.Body = $"Sevgili :{kullanici.Ad} Unuttuğunuz Şifreniz : {kullanici.Sifre} Mutlu Alışverişler Dileriz :)";
                        client.Send(msg);
                        MessageBox.Show("Mail Adresinize Şifreniz Gönderilmiştir Lütfen Kontrol Ediniz. Eğer Gelmedi İse Lütfen Gereksiz yada Spam Kutusunu Kontrol Ediniz.");
                    }
                    else
                    {
                        errorProvider1.SetError(btnGonder, "Girilen Kullanıcı Adı ve Mail Bağlantılı Değil!");
                    }
                }
            }
            else 
            {
                if (validation.IsValidateName(txtKullaniciAd, 2, 150, errorProvider1) && validation.IsValidateEmail(txtMail, errorProvider1))
                {
                    CalisanVM calisan = unitOfWork.CalisanRepository.KullaniciGetir(txtKullaniciAd.Text);
                    string mail = unitOfWork.CalisanIletisimRepository.GetEmailByUserName(txtKullaniciAd.Text);
                    if (txtMail.Text == mail)
                    {
                        SmtpClient client = new SmtpClient("smtp-relay.sendinblue.com", 587);
                        client.EnableSsl = true;
                        client.Timeout = 10000;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("ahmet_barcin@hotmail.com", "NscCdSt9M4G2ymQq");
                        MailMessage msg = new MailMessage();
                        msg.To.Add(txtMail.Text);
                        msg.From = new MailAddress("ahmet_barcin@hotmail.com");
                        msg.Subject = "Slytherin Arac Ihale";
                        msg.Body = $"Sevgili :{calisan.Ad} Unuttuğunuz Şifreniz : {calisan.Sifre} Mutlu Alışverişler Dileriz :)";
                        client.Send(msg);
                        MessageBox.Show("Mail Adresinize Şifreniz Gönderilmiştir Lütfen Kontrol Ediniz. Eğer Gelmedi İse Lütfen Gereksiz yada Spam Kutusunu Kontrol Ediniz.");
                    }
                    else
                    {
                        errorProvider1.SetError(btnGonder, "Girilen Kullanıcı Adı ve Mail Bağlantılı Değil!");
                    }
                }
            }
            
        }
    }
}
