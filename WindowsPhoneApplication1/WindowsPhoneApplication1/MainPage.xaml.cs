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

namespace WindowsPhoneApplication1
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
            String sc1 = textBox1.Text;
            String sc2 = textBox2.Text;
            int num1 = Convert.ToInt32(sc1);
            int num2 = Convert.ToInt32(sc2);
            int grade = num1 + num2;
            String gradeString = "" ;

            if (grade >= 80)
            {
                gradeString = "A";
            }
            else if (grade >= 70)
            {
                gradeString = "B";
            }
            else if (grade >= 60)
            {
                gradeString = "C";
            }
            else if (grade >= 50)
            {
                gradeString = "D";
            }
            else {
                gradeString = "F";
            }
            Gread.Text = gradeString;

        }
    }
}