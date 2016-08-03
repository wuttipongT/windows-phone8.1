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

namespace WindowsPhoneApplication2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        private int[] number = { 12, 45, 50, 16, 30, 40, 100 };
        public MainPage()
        {
            for (int i = 0; i < number.Length; i++) {
                topic.Text = Convert.ToString(number[i]);
            }
            InitializeComponent();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(inputText.Text);

            for (int i = 0; i < number.Length;i++) { 
                if(input == number[i]){
                    MessageBox.Show("Find Data");
                }
                else {
                    MessageBox.Show("Can not find");
                }
            }
            Array.Sort(number);
            
        }

    }
}