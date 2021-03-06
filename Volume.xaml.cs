﻿using System;
using System.Globalization;
using System.Windows;
using Microsoft.Phone.Controls;

namespace TrigMeter
{
    public partial class Volume : PhoneApplicationPage
    {
        private double num;

        public Volume()
        {
            InitializeComponent();
        }

        private void Calc3(object sender, RoutedEventArgs e)
        {
            if (D1.Text.Trim().Length != 0 && double.TryParse(D1.Text, out num))
                R1.Text = (Math.Abs(float.Parse(D1.Text)*float.Parse(D1.Text)*float.Parse(D1.Text))).ToString();
            else
            {
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
            }
        }

        private void Clr3(object sender, RoutedEventArgs e)
        {
            D1.Text = "";
            R1.Text = " ";
        }

        private void Calc5(object sender, RoutedEventArgs e)
        {
            if (A1.Text.Trim().Length != 0 && A2.Text.Trim().Length != 0 && A3.Text.Trim().Length != 0
                && double.TryParse(A1.Text, out num) && double.TryParse(A2.Text, out num) &&
                double.TryParse(A3.Text, out num))
                R3.Text = (Math.Abs(float.Parse(A1.Text)*float.Parse(A2.Text)*float.Parse(A3.Text))).ToString();
            else
            {
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
            }
        }

        private void Clr5(object sender, RoutedEventArgs e)
        {
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            R3.Text = "";
        }

        private void Calc6(object sender, RoutedEventArgs e)
        {
            if (B1.Text.Trim().Length != 0 && B3.Text.Trim().Length != 0
                && double.TryParse(B1.Text, out num) && double.TryParse(B3.Text, out num))
                R4.Text = Math.Abs(float.Parse(B1.Text)*Math.PI*float.Parse(B3.Text)*float.Parse(B3.Text)).ToString();
            else
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
        }

        private void Clr6(object sender, RoutedEventArgs e)
        {
            B1.Text = "";
            B3.Text = "";
            R4.Text = "";
        }

        private void Calc7(object sender, RoutedEventArgs e)

        {
            var num1 =new double();
            var num2=new double();

            if (I2.Text.Trim().Length != 0 && I1.Text.Trim().Length != 0 && double.TryParse(I2.Text, out num1) && double.TryParse(I1.Text, out num2))
            {
                R6.Text = ((double)1.0 / (double) 3.0 * num1 * num2).ToString();
            }
               
            else
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
        }

        private void Clr7(object sender, RoutedEventArgs e)
        {
            I1.Text = " ";
            I2.Text = "";
            R6.Text = "";
       
        }

        private void CalcX(object sender, RoutedEventArgs e)
        {
            if (X1.Text.Trim().Length != 0 && FX.Text.Trim().Length != 0
                && double.TryParse(X1.Text, out num) && double.TryParse(FX.Text, out num))
                RX.Text =
                    Math.Abs((double)1.0 / (double)3.0 * float.Parse(X1.Text) * float.Parse(FX.Text) * float.Parse(FX.Text) * Math.PI).ToString();
            else
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
        }

        private void ClrX(object sender, RoutedEventArgs e)
        {
            FX.Text = "";
            X1.Text = "";
            RX.Text = "";
        }

        private void CalcW(object sender, RoutedEventArgs e)
        {
            if (FW.Text.Trim().Length != 0 && double.TryParse(FW.Text, out num))
                RW.Text =
                    Math.Abs((double)4.0 / (double)3.0 * float.Parse(FW.Text) * float.Parse(FW.Text) * float.Parse(FW.Text) * Math.PI).ToString();
            else
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
        }

        private void ClrW(object sender, RoutedEventArgs e)
        {
            FW.Text = "";
            RW.Text = "";
        }

        private void CalcZ(object sender, RoutedEventArgs e)
        {
            if (FZ.Text.Trim().Length != 0 && FZ2.Text.Trim().Length != 0 && FZ1.Text.Trim().Length != 0
                && double.TryParse(FZ.Text, out num) && double.TryParse(FZ1.Text, out num) &&
                double.TryParse(FZ2.Text, out num))
                RZ.Text =
                    Math.Abs((double)4.0 / (double)3.0 * float.Parse(FZ.Text) * float.Parse(FZ1.Text) * float.Parse(FZ2.Text) * Math.PI).ToString();
            else
                MessageBox.Show("No data!", "", MessageBoxButton.OK);
        }

        private void ClrZ(object sender, RoutedEventArgs e)
        {
            FZ.Text = "";
            FZ1.Text = "";
            FZ2.Text = "";
            RZ.Text = "";
        }
    }
}