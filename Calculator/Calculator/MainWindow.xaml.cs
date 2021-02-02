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
    /// 

   
    
    public partial class MainWindow : Window
    {
        public float Value1 = 0;
        public float Value2 = 0;
        public float Value3 = 0;
        public bool HasFirstValue = false;

        public bool doPlus = false;
        public bool doMin = false;
        public bool doMulti = false;
        public bool doDiv = false;
        public MainWindow()
        {
            InitializeComponent();
        }




        private void Button_Click_Min(object sender, RoutedEventArgs e)
        {
            HasFirstValue = true;
            doMin = true;
            Value1 = float.Parse(ValueIO.Text);
            if (Value1 == float.Parse(ValueIO.Text))
            {
                ValueIO.Text = "0";
            }
        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
                HasFirstValue = true;
                doPlus = true;
                Value1 = float.Parse(ValueIO.Text);
                if(Value1 == float.Parse(ValueIO.Text))
                {
                    ValueIO.Text = "0";
                }
        }
        private void Button_Click_Multiply(object sender, RoutedEventArgs e)
        {
            HasFirstValue = true;
            doMulti = true;
            Value1 = float.Parse(ValueIO.Text);
            if (Value1 == float.Parse(ValueIO.Text))
            {
                ValueIO.Text = "0";
            }
        }

        private void Button_Click_Divide(object sender, RoutedEventArgs e)
        {
            HasFirstValue = true;
            doDiv = true;
            Value1 = float.Parse(ValueIO.Text);
            if (Value1 == float.Parse(ValueIO.Text))
            {
                ValueIO.Text = "0";
            }
        }
        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            if(doPlus && HasFirstValue)
            {
                doPlus = false;
                Value2 = float.Parse(ValueIO.Text);
                if(Value2 == float.Parse(ValueIO.Text))
                {
                    ValueIO.Text = Convert.ToString(Value1 + Value2);
                    Value1 = float.Parse(ValueIO.Text);
                    Value2 = 0;
                }
            }

            if(doMin && HasFirstValue)
            {
                doMin = false;
                Value2 = float.Parse(ValueIO.Text);
                if (Value2 == float.Parse(ValueIO.Text))
                {
                    ValueIO.Text = Convert.ToString(Value1 - Value2);
                    Value1 = float.Parse(ValueIO.Text);
                    Value2 = 0;
                }
            }

            if (doMulti && HasFirstValue)
            {
                doMulti = false;
                Value2 = float.Parse(ValueIO.Text);
                if (Value2 == float.Parse(ValueIO.Text))
                {
                    ValueIO.Text = Convert.ToString(Value1 * Value2);
                    Value1 = float.Parse(ValueIO.Text);
                    Value2 = 0;
                }
            }

            if (doDiv && HasFirstValue)
            {
                doDiv = false;
                Value2 = float.Parse(ValueIO.Text);
                if (Value2 == float.Parse(ValueIO.Text))
                {
                    ValueIO.Text = Convert.ToString(Value1 / Value2);
                    Value1 = float.Parse(ValueIO.Text);
                    Value2 = 0;
                }
            }
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Value1 = 0;
            Value2 = 0;
            ValueIO.Text = "0";


            HasFirstValue = false;

            doPlus = false;
            doMin = false;
            doMulti = false;
            doDiv = false;
    }




        // Value Input Buttons 0 to 9
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if(ValueIO.Text != "0")
            {
                ValueIO.Text = ValueIO.Text + 0;
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ValueIO.Text == "0")
            {
                ValueIO.Text = "1";
            }
            else
            {
                ValueIO.Text = ValueIO.Text + 1;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ValueIO.Text == "0")
            {
                ValueIO.Text = "2";
            }
            else
            {
                ValueIO.Text = ValueIO.Text + 2;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ValueIO.Text == "0")
            {
                ValueIO.Text = "3";
            }
            else
            {
                ValueIO.Text = ValueIO.Text + 3;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (ValueIO.Text == "0")
            {
                ValueIO.Text = "4";
            }
            else
            {
                ValueIO.Text = ValueIO.Text + 4;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (ValueIO.Text == "0")
            {
                ValueIO.Text = "5";
            }
            else
            {
                ValueIO.Text = ValueIO.Text + 5;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (ValueIO.Text == "0")
            {
                ValueIO.Text = "6";
            }
            else
            {
                ValueIO.Text = ValueIO.Text + 6;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (ValueIO.Text == "0")
            {
                ValueIO.Text = "7";
            }
            else
            {
                ValueIO.Text = ValueIO.Text + 7;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (ValueIO.Text == "0")
            {
                ValueIO.Text = "8";
            }
            else
            {
                ValueIO.Text = ValueIO.Text + 8;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (ValueIO.Text == "0")
            {
                ValueIO.Text = "9";
            }
            else
            {
                ValueIO.Text = ValueIO.Text + 9;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {
            if (ValueIO.Text.Contains("."))
            {
                return;
            }
            else
            {
                ValueIO.Text = ValueIO.Text + ".";
            }
            
        }
    }
}
