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

namespace WpfApp67
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

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(TbNumber.Text);
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt16(ListBoxData.Items[0]);
                int maxScore = 0;
                bool hasZeroScore = false;

                for (int i = 1; i <= n; i++)
                {
                    int score = Convert.ToInt16(ListBoxData.Items[i]);
                    if (score == 0)
                    {
                        hasZeroScore = true;
                    }
                    if (score > maxScore)
                    {
                        maxScore = score;
                    }
                }
                TextBlockAnswer.Text = $"{maxScore}";
                TextBlockAnswer.Text += hasZeroScore? "\nYES" : "\nNO";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
