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

namespace Money_Calculator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Konstruktor
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region CalculateSum
        private float CalculateSum()
        {
            float value_first = 0.01f, value_second = 0.02f, value_third = 0.05f, value_fourth = 0.1f, value_fiveth = 0.2f, value_sixth = 0.5f, value_seventh = 1f, value_eighth = 2f;
            float sum_first = value_first * int.Parse(FirstTextBlock.Text);
            float sum_second = value_second * int.Parse(SecondTextBlock.Text);
            float sum_third = value_third * int.Parse(ThirdTextBlock.Text);
            float sum_fourth = value_fourth * int.Parse(FourthTextBlock.Text);
            float sum_fiveth = value_fiveth * int.Parse(FivethTextBlock.Text);
            float sum_sixth = value_sixth * int.Parse(SixthTextBlock.Text);
            float sum_seventh = value_seventh * int.Parse(SeventhTextBlock.Text);
            float sum_eighth = value_eighth * int.Parse(EighthTextBlock.Text);
            return sum_first + sum_second + sum_third + sum_fourth + sum_fiveth + sum_sixth + sum_seventh + sum_eighth;
        }
        #endregion

        #region Outcome

        private void OutcomeNumber()
        {
            if(CalculateSum() != 0)
            {
                Outcome.Text = CalculateSum().ToString() + "zł";
            }
            else
            {
                Outcome.Text = ":(";
            }
        }

        #endregion

        #region Click
        private void Count_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CalculateSum();
                OutcomeNumber();
            }
            catch (Exception ex)
            {

            }
        }
    #endregion
    }
}
