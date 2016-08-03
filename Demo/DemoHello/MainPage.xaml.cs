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

namespace DemoHello
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void txtname_GotFocus(object sender, RoutedEventArgs e)
        {
            String num1 = textBlock1.Text;
            String num2 = textBlock2.Text;
            int sum1 = Int32.Parse(num1);
            int sum2 = Int32.Parse(num2);
    
            int grade = sum1 + sum2;
            String gradeString;
            if (grade == 4)
            {
                gradeString = "A";
            }
            else if (grade == 3)
            {
                gradeString = "B";
            }
            else if (grade == 2)
            {
                gradeString = "C";
            }
            else if (grade == 1)
            {
                gradeString = "D";
            }
            else if (grade == 0)
            {
                gradeString = "F";
            }
            else
            {
                gradeString = "Incorrect number";
            }


            MessageBox.Show(Convert.ToString(gradeString));
        }
    }
}