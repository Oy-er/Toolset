using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace 工具集.Pages
{
    public sealed partial class GCDPage : Page
    {
        public GCDPage()
        {
            InitializeComponent();
        }

        private static long GCD(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                long t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            long a = (long)Math.Round(NumberA.Value);
            long b = (long)Math.Round(NumberB.Value);
            long gcd = GCD(a, b);
            ResultText.Text = $"GCD({a}, {b}) = {gcd}";
        }
    }
}
