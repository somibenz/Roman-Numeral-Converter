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

namespace Problem_Roman_Numeral_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num;
        int output;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                num = int.Parse(textBox.Text);
                if (num == 1)
                {
                    label.Content = "I";
                }
                if (num == 2)
                {
                    label.Content = "II";
                }
                if (num == 3)
                {
                    label.Content = "III";
                }
                if (num == 4)
                {
                    label.Content = "IV";
                }
                if (num == 5)
                {
                    label.Content = "V";
                }
                if (num == 6)
                {
                    label.Content = "VI";
                }
                if (num == 7)
                {
                    label.Content = "VII";
                }
                if (num == 8)
                {
                    label.Content = "VIII";
                }
                if (num == 9)
                {
                    label.Content = "IX";
                }
                if (num == 10)
                {
                    label.Content = "X";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("please enter a number");
            }

        }
    }
}
