using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Popups;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        string operand1 = string.Empty;
        string operand2 = string.Empty;
        string result;
        char operation;

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + "0";
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + "2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + "9";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operand1 = txtAnswer.Text;
            operation = '+';
            txtAnswer.Text = string.Empty;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operand1 = txtAnswer.Text;
            operation = '-';
            txtAnswer.Text = string.Empty;
        }
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operand1 = txtAnswer.Text;
            operation = '*';
            txtAnswer.Text = string.Empty;
        }
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operand1 = txtAnswer.Text;
            operation = '/';
            txtAnswer.Text = string.Empty;
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            operand2 = txtAnswer.Text;

            double oper1, oper2;
            double.TryParse(operand1, out oper1);
            double.TryParse(operand2, out oper2);


            switch (operation)
            {
                case '+':
                    result = (oper1 + oper2).ToString();
                    break;

                case '-':
                    result = (oper1 - oper2).ToString();
                    break;

                case '*':
                    result = (oper1 * oper2).ToString();
                    break;

                case '/':
                    if (oper2 != 0)
                    {
                        result = (oper1 / oper2).ToString();
                    }
                    else
                    {
                        MessageDialog msgbox = new MessageDialog("Sorry, cannot divide by zero.");
                    }
                    break;
            }
            txtAnswer.Text = result.ToString();

        }
    }
}
