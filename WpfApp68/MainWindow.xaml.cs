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

namespace WpfApp68
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt16(ListBoxData.Items[0]);
            int maxNumberEndingIn3 = 0;
            for (int i = 0; i < n; i++)
            {
                
                int number = Convert.ToInt16(ListBoxData.Items[1]);
                if (number % 10 == 3 && number > maxNumberEndingIn3)
                {
                    maxNumberEndingIn3 = number;
                }
            }
            TextBlockAnswer.Text=$"Максимальное число оканчивающееся на 3, равно {maxNumberEndingIn3}";
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
