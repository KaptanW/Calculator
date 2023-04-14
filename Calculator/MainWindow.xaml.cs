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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        public MainWindow()
        {
            InitializeComponent();
            Resultlabel.Content = 0;

            acbutton.Click += Acbutton_Click;
            negativebutton.Click += Negativebutton_Click;
            percentagebutton.Click += Percentagebutton_Click  ;
            resultbutton.Click += Resultbutton_Click;
        }

        private void Resultbutton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Percentagebutton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Resultlabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber /100;
                Resultlabel.Content = lastNumber.ToString();
            }
        }

        private void Negativebutton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(Resultlabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                Resultlabel.Content = lastNumber.ToString();
            }
        }

        private void Acbutton_Click(object sender, RoutedEventArgs e)
        {
            Resultlabel.Content = "0";
        }

        private void Operationbutton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Resultlabel.Content.ToString(), out lastNumber))
            {
                Resultlabel.Content = "0";
            }
        }

            private void Numberbutton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;
            selectedValue = int.Parse((sender as Button).Content.ToString()); 
            firstNumber(selectedValue);
        }


        void firstNumber(int button)
        {
            if (Resultlabel.Content.ToString() == "0")
            {
                Resultlabel.Content = button.ToString();
            }
            else
            {
                Resultlabel.Content += button.ToString();
            }
        }
    }
}
