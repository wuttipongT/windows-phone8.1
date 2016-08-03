using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PhoneAppLab7
{
    
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
           
            InitializeComponent();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(inputText.Text);
            int[] number = { 12, 45, 50, 16, 30, 40, 100 };
            int i;
            for (i = 0; i < number.Length; i++) {
                if(number[i] == input){
                    break;
                }
            }
            if (i == number.Length) {MessageBox.Show("Cound not Fond! index as " + Convert.ToString(i)); }
            else { MessageBox.Show("Fond Data! index"); }

            Array.Sort(number);
            String max = Convert.ToString(number[number.Length - 1]);
            String min = Convert.ToString(number[0]);
            maxValue.Text = max;
            minValue.Text = min;
            average.Text = Convert.ToString((number[number.Length-1]+number[0])/2);

        }
    }
}