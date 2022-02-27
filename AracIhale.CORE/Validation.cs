using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracIhale.CORE
{
    public class Validation
    {
        private string Message { get; set; }
        public Validation()
        {
            InitializeLocalValues();
        }
        public bool IsValidateEmail(TextBox textBoxMail,ErrorProvider errorProvider)
        {
            bool validate = false;
            string email = textBoxMail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                validate = true;
            }
            else
            {
                errorProvider.SetError(textBoxMail, "Hatalı Mail");
            }
            return validate;
        }
        private void InitializeLocalValues()
        {
            List<Char> tempForbiddenCharacters = new List<char>();
            List<int> tempNumbers = new List<int>();
            List<char> tempLetters = new List<char>();
            for (int i = 33; i < 255; i++)
            {
                if (!char.IsLetterOrDigit(Convert.ToChar(i)))
                {
                    tempForbiddenCharacters.Add(Convert.ToChar(i));
                }
                else if (char.IsLetter(Convert.ToChar(i)))
                {
                    tempLetters.Add(Convert.ToChar(i));
                }
                else
                {
                    tempNumbers.Add(Convert.ToChar(i));
                }
            }
            forbiddenCharacters = new char[tempForbiddenCharacters.Count];
            for (int i = 0; i < tempForbiddenCharacters.Count; i++)
            {
                forbiddenCharacters[i] = tempForbiddenCharacters[i];
            }

        }
        char[] forbiddenCharacters;
        public bool IsValidateName(TextBox textBox, int min, int max, ErrorProvider errorProvider)
        {
            bool validate = false;
            if (!NullorEmptyControl(textBox, errorProvider) && !WhiteSpaceControl(textBox,errorProvider)& LengthControl(textBox, errorProvider, min, max) && !IsForbiddenCharacters(textBox,errorProvider)&&!IsContainsNumber(textBox,errorProvider) )
            {
                validate = true;
                errorProvider.Clear();
            }
            return validate;
        }
        public bool IsValidatePassword(TextBox textBox, int min, int max, ErrorProvider errorProvider)
        {
            bool validate = false;
            if (!NullorEmptyControl(textBox, errorProvider) && LengthControl(textBox, errorProvider, min, max) && UserNameCharacterControl(textBox, errorProvider))
            {
                validate = true;
                errorProvider.Clear();
            }
            return validate;
        }

        public bool IsValidatePhoneNumber(TextBox textBox, ErrorProvider errorProvider)
        {
            bool validate = true;
            string numara = textBox.Text;
            foreach (var item in numara)
            {
                if (!char.IsDigit(item))
                {
                    validate = false;
                    break;
                }
            }
            string temp= numara.TrimStart('0');
            if (temp!=numara)
            {
                Message = "Lütfen Numaranın Başına 0 Koymadan ve Boşluk Bırakmadan Yazınız";
                errorProvider.SetError(textBox, Message);
                validate = false;
            }
            return validate;
        }
        private bool IsContainsNumber(TextBox textBox,ErrorProvider errorProvider)
        {
            bool validate = false;
            foreach (char item in textBox.Text)
            {
                if (char.IsDigit(item))
                {
                    validate = true;
                    Message = "Sayı İçeremez";
                    break;
                }
            }
            errorProvider.SetError(textBox, Message);
            return validate;
        }
        private bool IsForbiddenCharacters(TextBox textBox,ErrorProvider errorProvider)
        {
            bool validate = false;
            int count = 0;
            foreach (char item in forbiddenCharacters)
            {
                for (int i = 0; i < textBox.Text.Length; i++)
                {
                    if (textBox.Text[i] == item)
                    {
                        validate = true;
                        count++;
                        Message="Geçersiz Karakter Var";
                        break;
                    }
                }
                if (count>0)
                {
                    break;
                }
            }
            errorProvider.SetError(textBox, Message);
            return validate;
        }
        private bool NullorEmptyControl(TextBox textBox, ErrorProvider errorProvider)
        {
            bool validate = false;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                Message = "Boş Geçilemez";
                validate = true;
            }
            errorProvider.SetError(textBox, Message);
            return validate;
        }
        private bool WhiteSpaceControl(TextBox textBox,ErrorProvider errorProvider)
        {
            bool validate = false;
            string str = textBox.Text.Trim();
            if (str.Length!=textBox.Text.Length)
            {
                Message = "Başta Yada Sonda Boşluk Karakteri Kullanılamaz";
                validate = true;
            }
            errorProvider.SetError(textBox, Message);
            return validate;
        }
        private bool MinLengthControl(TextBox textBox, ErrorProvider errorProvider, int min = 1)
        {
            bool validate = false;
            if (textBox.Text.Length < min)
            {
                Message = min + " Karakterden Az Girilemez";
            }
            else
            {
                validate = true;
            }
            errorProvider.Clear();
            errorProvider.SetError(textBox, Message);
            return validate;
        }
        private bool MaxLengthControl(TextBox textBox, ErrorProvider errorProvider, int max = 254)
        {
            bool validate = false;
            if (textBox.Text.Length > max)
            {
                Message = max + " Karakterden Fazla Girilemez";
            }
            else
            {
                validate = true;
            }
            errorProvider.SetError(textBox, Message);
            return validate;
        }
        private bool LengthControl(TextBox textBox, ErrorProvider errorProvider, int min = 1, int max = 254)
        {
            bool validate = false;
            if (textBox.Text.Length < min)
            {
                Message = min + " Karakterden Az Girilemez";
            }
            else if (textBox.Text.Length > max)
            {
                Message = max + " Karakterden Fazla Girilemez";
            }
            else
            {
                validate = true;
            }
            errorProvider.SetError(textBox, Message);
            return validate;
        }
        public bool IsValidateUserName(TextBox text, ErrorProvider errorProvider,int min=1,int max=254)
        {
            bool validate = false;
            if (!NullorEmptyControl(text, errorProvider) && LengthControl(text, errorProvider, min, max) && UserNameCharacterControl(text, errorProvider))
            {
                validate = true;
                errorProvider.Clear();
            }
            return validate;
        }
        public bool IsValidatePassWord(TextBox text, ErrorProvider errorProvider, int min = 1, int max = 30)
        {
            bool validate = false;
            if (!NullorEmptyControl(text, errorProvider) && LengthControl(text, errorProvider, min, max) && UserNameCharacterControl(text, errorProvider))
            {
                validate = true;
                errorProvider.Clear();
            }
            return validate;
        }
        private bool UserNameCharacterControl(TextBox userName, ErrorProvider errorProvider)
        {
            bool validate = false;
            int control = 0;
            userName.Text=userName.Text.TrimEnd();
            for (int i = 0; i < userName.Text.Length; i++)
            {
                if (char.IsWhiteSpace(userName.Text[i]))
                {
                    Message = "Kullanıcı Adında Boşluk Olamaz";
                }
                else if (!char.IsLetterOrDigit(userName.Text[i]))
                {
                    if (userName.Text[i] == '-' || userName.Text[i] == '_' || userName.Text[i] == '.')
                    {
                        control++;
                    }
                    else
                    {
                        Message = "Kullanıcı Adında Harf ve Sayı Dışında Sadece ('-','_','.') Karakterleri Bulunabilir";
                    }
                }
                else
                {
                    control++;
                }
            }
            if (control == userName.Text.Length)
            {
                validate = true;
            }
            errorProvider.SetError(userName, Message);
            return validate;
        }

        public bool IsValidateMoney(TextBox money, ErrorProvider errorProvider)
        {
            bool validate = false;
            var TryParseOut = 0.0M;

            if (string.IsNullOrEmpty(money.Text))
            {
                Message = "Bu kısım boş geçilemez";
                errorProvider.SetError(money, Message);
            }

            else
            {
                if (!decimal.TryParse(money.Text, out TryParseOut))
                {
                    Message = "Format hatası. Lütfen sayı giriniz.";
                    errorProvider.SetError(money, Message);
                }
                else 
                {
                    if (money.Text.Contains('.'))
                    {
                        Message = "Format hatası. Lütfen virgül kullanınız.";
                        errorProvider.SetError(money, Message);
                    }
                    else 
                    {
                        if (TryParseOut < 0)
                        {
                            validate = false;
                            Message = "Eksi Para Hatası. Lütfen Eksi Değer Girmeyiniz.";
                            errorProvider.SetError(money, Message);

                        }
                        else 
                        {
                            validate = true;
                        }
                    }
                    
                }
            }

            return validate;
        }

        public bool IsValidateNull(GroupBox groupBox, ErrorProvider errorProvider, DateTimePicker basTarih, DateTimePicker bitTarih, DateTimePicker basSaat, DateTimePicker bitSaat )
        {
            bool validate = true;
            errorProvider.Clear();

            if (basTarih.Value > bitTarih.Value)
            {
                validate = false;
                Message = "Başlangıç Tarihi Bitiş Tarihinden Sonra Olamaz";
                errorProvider.SetError(basTarih, Message);
                errorProvider.SetError(bitTarih, Message);
            }
            else if (basSaat.Value.ToShortTimeString() == bitSaat.Value.ToShortTimeString() && basTarih.Value == bitTarih.Value)
            {
                validate = false;
                Message = "Başlangıç saati bitiş saatine eşit olamaz";
                errorProvider.SetError(basSaat, Message);
                errorProvider.SetError(bitSaat, Message);
            }
            else if (basSaat.Value >= bitSaat.Value && basTarih.Value == bitTarih.Value)
            {
                validate = false;
                Message = "Başlangıç saati bitiş saatinden büyük olamaz";
                errorProvider.SetError(basSaat, Message);
                errorProvider.SetError(bitSaat, Message);
            }

            foreach (Control item in groupBox.Controls)
            {                
                TextBox txt = item as TextBox;
                ComboBox cmb = item as ComboBox;
             
                if (txt != null)
                {                    
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        Message = "İhale Adı Giriniz.";
                        validate = false;
                        errorProvider.SetError(txt, Message);
                    }
                }
                if (cmb != null)
                {
                    if (cmb.SelectedIndex == 0)
                    {
                        Message = "Lütfen Bilgileri Doldurun.";
                        validate = false;
                        errorProvider.SetError(cmb, Message);
                    }
                }                   
            }
            return validate;
        }

        public bool IsTextBoxNullOrWhiteSpace(TextBox txt, ErrorProvider errorProvider, string message)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, message);
                return false;
            }

            return true;
        }
        public bool IsValidateCombobox(List<ComboBox> comboBoxes, ErrorProvider errorProvider)
        {
            bool validate = true;
            errorProvider.Clear();
            foreach (ComboBox cmb in comboBoxes)
            {
                if (cmb.SelectedIndex < 0)
                {
                    validate = false;
                    Message = "Lütfen bir seçim yapınız.";
                    errorProvider.SetError(cmb, Message);
                    break;
                }
            }
            return validate;
        }
        public bool IsValidateNumericUpDown(NumericUpDown numericUpDown, ErrorProvider errorProvider)
        {
            bool validate = true;
            if (numericUpDown.Value <= 0)
            {
                validate = false;
                Message = "Lütfen geçerli bir sayı giriniz.";
                errorProvider.SetError(numericUpDown, Message);
            }
            return validate;
        }
        public bool IsValidateNumericUpDown(List<NumericUpDown> numericUpDowns, ErrorProvider errorProvider)
        {
            bool validate = true;
            foreach (var nm in numericUpDowns)
            {
                if (nm.Value <= 0)
                {
                    validate = false;
                    Message = "Lütfen geçerli bir sayı giriniz.";
                    errorProvider.SetError(nm, Message);
                    break;
                }
            }
            return validate;
        }
        public bool IsValidateNull(GroupBox groupBox, ErrorProvider errorProvider)
        {
            bool validate = true;
            errorProvider.Clear();

            foreach (Control item in groupBox.Controls)
            {
                TextBox txt = item as TextBox;
                ComboBox cmb = item as ComboBox;

                if (txt != null)
                {
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        Message = "Lütfen Bilgileri Doldurun.";
                        validate = false;
                        errorProvider.SetError(txt, Message);
                    }
                }
                if (cmb != null)
                {
                    if (cmb.SelectedIndex == 0)
                    {
                        Message = "Lütfen Bilgileri Doldurun.";
                        validate = false;
                        errorProvider.SetError(cmb, Message);
                    }
                }
            }
            return validate;
        }
    }
}
