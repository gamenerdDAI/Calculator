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

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            textBlock.Text += btn.Content.ToString();
            //MessageBox.Show(btn.Content.ToString());
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            string expression = textBlock.Text;
            textBlock.Text = "";
            MessageBox.Show(expression);
        }
    }
}
