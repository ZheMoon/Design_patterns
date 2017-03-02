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

namespace calc
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        object cp;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void N1_Click(object sender, RoutedEventArgs e)
        {
            showit.Text += ((Button)sender).Content.ToString();
        }

        private void Op_Click(object sender, RoutedEventArgs e)
        {
            string oper = ((Button)sender).Content.ToString();
            string[] strArr = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "=", "." };
            if (!strArr.Contains(oper))
            {
                string op = ((Button)sender).Name.ToString();
                cp = Factory.getCalc(op);
                ((Compute)cp).Num1 = Convert.ToDouble(showit.Text);
                showit.Text = "";
            }
            else
            {
                ((Compute)cp).Num2 = Convert.ToDouble(showit.Text);
                showit.Text = ((Compute)cp).GetResult().ToString();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            cp = null;
            showit.Text = "";
        }
    }
}
