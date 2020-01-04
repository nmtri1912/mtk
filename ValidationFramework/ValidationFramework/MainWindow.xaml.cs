using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ValidationFramework.LanguageFactory;
using ValidationFramework.TypeShow;
using ValidationFramework.Validation;
using ValidationFramework.ValidationExtension;

namespace ValidationFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LanguageFac lFac = LanguageFac.getInstance();
        private LanguageNotification lNotify;
        ListValidator lv = new ListValidator();
        ShowBehavior sb;
        #region Prototype Check
        Validator creditCheck;
        Validator phoneCheck;
        Validator emailCheck;
        Validator emailDocComCheck;
        Validator passwordCheck;

        #endregion
        public MainWindow()
        {
            InitializeComponent();

            lNotify = lFac.getNotificationType("vi");
            creditCheck = new CreditCard();
            phoneCheck = new Phone();
            emailCheck = new IsEmail();
            emailDocComCheck = new IsEmailExtension(new IsEmail());
            passwordCheck = new IsPassword();
        }

        private void comboValidationLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboValidationLanguage.SelectedIndex == 0)
            {
                lNotify = lFac.getNotificationType("vi");
            }
            else
            {
                lNotify = lFac.getNotificationType("en");
            }
        }

        private void comboShowType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboShowType.SelectedIndex == 0)
            {
                sb = new MessBox();
            }
            else
            {
                sb = new Popup();
            }
        }

        private void CreditCard_LostFocus(object sender, RoutedEventArgs e)
        {
            //5485660034693048
            creditCheck = new CreditCard();
            if (!creditCheck.check(textCreditCardName.Text, lNotify))
            {
                labelCreditCard.Content = creditCheck.Message;
                textCreditCardName.BorderBrush = Brushes.Red;
            }
            else
            {
                labelCreditCard.Content = "";
                textCreditCardName.BorderBrush = Brushes.LightGreen;
            }
        }

        private void PhoneNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            phoneCheck = new Phone();
            if (!phoneCheck.check(textPhoneNumber.Text, lNotify))
            {
                labelPhoneNumber.Content = phoneCheck.Message;
                textPhoneNumber.BorderBrush = Brushes.Red;
            }
            else
            {
                labelPhoneNumber.Content = "";
                textPhoneNumber.BorderBrush = Brushes.LightGreen;
            }
        }

        private void Email_LostFocus(object sender, RoutedEventArgs e)
        {
            emailCheck = new IsEmail();
            if (!emailCheck.check(textEmail.Text, lNotify))
            {
                labelEmail.Content = emailCheck.Message;
                textEmail.BorderBrush = Brushes.Red;
            }
            else
            {
                labelEmail.Content = "";
                textEmail.BorderBrush = Brushes.LightGreen;
            }
        }

        private void EmailDocCom_LostFocus(object sender, RoutedEventArgs e)
        {

            emailDocComCheck = new IsEmailExtension(new IsEmail());
            if (!emailDocComCheck.check(textEmailDocCom.Text, lNotify))
            {
                labelEmailDocCom.Content = emailDocComCheck.Message;
                textEmailDocCom.BorderBrush = Brushes.Red;
            }
            else
            {
                labelEmailDocCom.Content = "";
                textEmailDocCom.BorderBrush = Brushes.LightGreen;
            }
        }

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            passwordCheck = new IsPassword();
            if (!passwordCheck.check(pwbPassword.Password, lNotify))
            {
                labelPassword.Content = passwordCheck.Message;
                pwbPassword.BorderBrush = Brushes.Red;
            }
            else
            {
                labelPassword.Content = "";
                pwbPassword.BorderBrush = Brushes.LightGreen;
            }
        }

        private void buttonSubmit_Click(object sender, RoutedEventArgs e)
        {
            lv = new ListValidator();
            creditCheck = new CreditCard();
            phoneCheck = new Phone();
            emailCheck = new IsEmail();
            emailDocComCheck = new IsEmailExtension(new IsEmail());
            passwordCheck = new IsPassword();

            creditCheck.check(textCreditCardName.Text, lNotify);
            phoneCheck.check(textPhoneNumber.Text, lNotify);
            emailCheck.check(textEmail.Text, lNotify);
            emailDocComCheck.check(textEmailDocCom.Text, lNotify);
            passwordCheck.check(pwbPassword.Password, lNotify);

            lv.AddValidator(creditCheck);
            lv.AddValidator(phoneCheck);
            lv.AddValidator(emailCheck);
            lv.AddValidator(emailDocComCheck);
            lv.AddValidator(passwordCheck);

            lv.SetShowBehavior(sb);
            lv.show();
        }
    }
}
