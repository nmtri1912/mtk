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
using ValidationFramework.Validation;
using ValidationFramework.ValidationExtension;

namespace ValidationFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LanguageFac lFac;
        private LanguageNotification lNotify;
        IsEmail n2;
        Validator deco;
        public MainWindow()
        {
            InitializeComponent();
            lFac = LanguageFac.getInstance();
            lNotify = lFac.getNotificationType("vi");
            n2 = new IsEmail();
            deco = new IsEmailExtension(n2);
        }



        

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(deco.Message);
        }


        private void txt1_LostFocus(object sender, RoutedEventArgs e)
        {
            error1.Content = "";
            deco.check(textBox.Text, lNotify);

            error1.Content = deco.Message;
        }
    }
}
