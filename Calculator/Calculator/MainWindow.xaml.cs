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

        public bool Euro = false;
        public bool Pct = false;


        public string ActualValue;

        public string EuroPrefix = "€ ";
        public string PctPrefix = "% ";
        public MainWindow()
        {
            InitializeComponent();
        }


        private void GetRidPrefix()
        {
            
            if(ValueIO.Text.Contains("€") && Euro)
            {
                string[] vs = ValueIO.Text.Split('€', ' ');
                ActualValue = vs[vs.Length - 1];
            }
            if(ValueIO.Text.Contains("%") && Pct)
            {
                string[] vs = ValueIO.Text.Split('%', ' ');
                ActualValue = vs[vs.Length - 1];
            }
            if(!ValueIO.Text.Contains("%") && !Pct && !ValueIO.Text.Contains("€") && !Euro)
            {
                ActualValue = ValueIO.Text;
            }
            
        }



        private void Button_Click_Min(object sender, RoutedEventArgs e)
        {
            GetRidPrefix();
            HasFirstValue = true;
            doMin = true;
            Value1 = float.Parse(ActualValue);
            ValueIn.Content = Value1;
            if (Value1 == float.Parse(ActualValue))
            {
                if (!Euro && !Pct)
                {
                    ValueIO.Text = "0";
                }
                else
                {
                    if (Euro)
                    {
                        ValueIO.Text = EuroPrefix + "0";
                    }
                    if (Pct)
                    {
                        ValueIO.Text = PctPrefix + "0";
                    }
                }
            }
        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            GetRidPrefix();
            HasFirstValue = true;
            doPlus = true;
            Value1 = float.Parse(ActualValue);
            ValueIn.Content = Value1;
            if (Value1 == float.Parse(ActualValue))
            {
                if (!Euro && !Pct)
                {
                    ValueIO.Text = "0";
                }
                else
                {
                    if (Euro)
                    {
                        ValueIO.Text = EuroPrefix + "0";
                    }
                    if (Pct)
                    {
                        ValueIO.Text = PctPrefix + "0";
                    }
                }
            }
        }
        private void Button_Click_Multiply(object sender, RoutedEventArgs e)
        {
            GetRidPrefix();
            HasFirstValue = true;
            doMulti = true;
            Value1 = float.Parse(ActualValue);
            ValueIn.Content = Value1;
            if (Value1 == float.Parse(ActualValue))
            {
                if (!Euro && !Pct)
                {
                    ValueIO.Text = "0";
                }
                else
                {
                    if (Euro)
                    {
                        ValueIO.Text = EuroPrefix + "0";
                    }
                    if (Pct)
                    {
                        ValueIO.Text = PctPrefix + "0";
                    }
                }
            }
        }

        private void Button_Click_Divide(object sender, RoutedEventArgs e)
        {
            GetRidPrefix();
            HasFirstValue = true;
            doDiv = true;
            Value1 = float.Parse(ActualValue);
            ValueIn.Content = Value1;
            if (Value1 == float.Parse(ActualValue))
            {
                if (!Euro && !Pct)
                {
                    ValueIO.Text = "0";
                }
                else
                {
                    if (Euro)
                    {
                        ValueIO.Text = EuroPrefix + "0";
                    }
                    if (Pct)
                    {
                        ValueIO.Text = PctPrefix + "0";
                    }
                }
            }
        }
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            GetRidPrefix();
            Value2 = float.Parse(ActualValue);
            if (Value2 == float.Parse(ActualValue))
            {
                var SplitPercentage = Value1 / Value2;
                ValueIO.Text = Convert.ToString(SplitPercentage);
            }
        }
        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            GetRidPrefix();
            if (doPlus && HasFirstValue)
            {
                doPlus = false;
                Value2 = float.Parse(ActualValue);
                if(Value2 == float.Parse(ActualValue))
                {
                    if (!Euro && !Pct)
                    {
                        ValueIO.Text = Convert.ToString(Value1 + Value2);
                    }
                    else
                    {
                        if (Euro)
                        {
                            ValueIO.Text = EuroPrefix + Convert.ToString(Value1 + Value2);
                        }
                        if (Pct)
                        {

                        }
                        
                    }
                    
                    Value1 = float.Parse(ActualValue);
                    ValueIn.Content = "";
                    Value2 = 0;
                }
            }

            if(doMin && HasFirstValue)
            {
                doMin = false;
                Value2 = float.Parse(ActualValue);
                if (Value2 == float.Parse(ActualValue))
                {
                    if (!Euro && !Pct)
                    {
                        ValueIO.Text = Convert.ToString(Value1 - Value2);
                    }
                    else
                    {
                        if (Euro)
                        {
                            ValueIO.Text = EuroPrefix + Convert.ToString(Value1 - Value2);
                        }
                        if (Pct)
                        {

                        }

                    }
                    Value1 = float.Parse(ActualValue);
                    ValueIn.Content = "";
                    Value2 = 0;
                }
            }

            if (doMulti && HasFirstValue)
            {
                doMulti = false;
                Value2 = float.Parse(ActualValue);
                if (Value2 == float.Parse(ActualValue))
                {
                    if (!Euro && !Pct)
                    {
                        ValueIO.Text = Convert.ToString(Value1 * Value2);
                    }
                    else
                    {
                        if (Euro)
                        {
                            ValueIO.Text = EuroPrefix + Convert.ToString(Value1 * Value2);
                        }
                        if (Pct)
                        {

                        }

                    }
                    Value1 = float.Parse(ActualValue);
                    ValueIn.Content = "";
                    Value2 = 0;
                }
            }

            if (doDiv && HasFirstValue)
            {
                doDiv = false;
                Value2 = float.Parse(ActualValue);
                if (Value2 == float.Parse(ActualValue))
                {
                    if (!Euro && !Pct)
                    {
                        ValueIO.Text = Convert.ToString(Value1 / Value2);
                    }
                    else
                    {
                        if (Euro)
                        {
                            ValueIO.Text = EuroPrefix + Convert.ToString(Value1 / Value2);
                        }
                        if (Pct)
                        {

                        }

                    }
                    Value1 = float.Parse(ActualValue);
                    ValueIn.Content = "";
                    Value2 = 0;
                }
            }
        }


        private void Clear()
        {
            Value1 = 0;
            Value2 = 0;
            ValueIO.Text = "0";
            ValueIn.Content = "";


            HasFirstValue = false;

            doPlus = false;
            doMin = false;
            doMulti = false;
            doDiv = false;
            GetRidPrefix();
        }
        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Clear();
        }




        // Value Input Buttons 0 to 9
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (!Euro)
            {
                if (ValueIO.Text == "0")
                {
                    
                }
                else
                {
                    ValueIO.Text = ValueIO.Text + 0;
                }
            }
            if (Euro)
            {
                GetRidPrefix();
                if (ActualValue == "0")
                {
                    //ValueIO.Text = EuroPrefix + "0";
                }
                else
                {
                    ValueIO.Text = ValueIO.Text + "0";
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
           if (!Euro)
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
           if (Euro)
           {
              GetRidPrefix();
              if (ActualValue == "0")
              {
                  ValueIO.Text = EuroPrefix + "1";
              }
              else
              {
                  ValueIO.Text = ValueIO.Text + "1";
              }
           }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!Euro)
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
            if (Euro)
            {
                GetRidPrefix();
                if (ActualValue == "0")
                {
                    ValueIO.Text = EuroPrefix + "2";
                }
                else
                {
                    ValueIO.Text = ValueIO.Text + "2";
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!Euro)
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
            if (Euro)
            {
                GetRidPrefix();
                if (ActualValue == "0")
                {
                    ValueIO.Text = EuroPrefix + "3";
                }
                else
                {
                    ValueIO.Text = ValueIO.Text + "3";
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (!Euro)
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
            if (Euro)
            {
                GetRidPrefix();
                if (ActualValue == "0")
                {
                    ValueIO.Text = EuroPrefix + "4";
                }
                else
                {
                    ValueIO.Text = ValueIO.Text + "4";
                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (!Euro)
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
            if (Euro)
            {
                GetRidPrefix();
                if (ActualValue == "0")
                {
                    ValueIO.Text = EuroPrefix + "5";
                }
                else
                {
                    ValueIO.Text = ValueIO.Text + "5";
                }
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (!Euro)
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
            if (Euro)
            {
                GetRidPrefix();
                if (ActualValue == "0")
                {
                    ValueIO.Text = EuroPrefix + "6";
                }
                else
                {
                    ValueIO.Text = ValueIO.Text + "6";
                }
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (!Euro)
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
            if (Euro)
            {
                GetRidPrefix();
                if (ActualValue == "0")
                {
                    ValueIO.Text = EuroPrefix + "7";
                }
                else
                {
                    ValueIO.Text = ValueIO.Text + "7";
                }
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (!Euro)
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
            if (Euro)
            {
                GetRidPrefix();
                if (ActualValue == "0")
                {
                    ValueIO.Text = EuroPrefix + "8";
                }
                else
                {
                    ValueIO.Text = ValueIO.Text + "8";
                }
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (!Euro)
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
            if (Euro)
            {
                GetRidPrefix();
                if (ActualValue == "0")
                {
                    ValueIO.Text = EuroPrefix + "9";
                }
                else
                {
                    ValueIO.Text = ValueIO.Text + "9";
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {
            if (!ValueIO.Text.Contains("."))
            {
                ValueIO.Text = ValueIO.Text + ".";
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Clear();
            Euro = !Euro;
            
            if (!ValueIO.Text.Contains("€"))
            {
                ValueIO.Text = "€ " + ValueIO.Text;
                return;
            }
            else
            {
                string[] vs = ValueIO.Text.Split('€', ' ');
                ValueIO.Text = vs[vs.Length - 1];
            }
        }

      
    }
}
