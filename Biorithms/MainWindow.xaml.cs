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

namespace Biorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public struct Biorithm
        {
           public double Phys;
           public double Emotion;
           public double Intel;
        };


        public Biorithm Bio;
        public double[] P = { 23, 28, 33 };
        public int T;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt1 = DateTime.ParseExact(DatePicker1.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dt2 = DateTime.ParseExact(DatePicker2.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan x = dt2 - dt1;
            T = (int)x.TotalDays;



           


            Bio.Phys = (Math.Sin(2 * 3.14 * T / P[0])) * 100;
            Bio.Emotion = (Math.Sin(2 * 3.14 * T / P[1])) * 100;
            Bio.Intel = (Math.Sin(2 * 3.14 * T / P[2])) * 100;

            textBlock.Text = "Физический биоритм " + String.Format("{0:0.00}",Bio.Phys) + "%" 
                + "\nЭмоциональный биоритм " + String.Format("{0:0.00}", Bio.Emotion) + "%" 
                + "\nИнтеллектуальный биоритм " + String.Format("{0:0.00}", Bio.Intel) + "%";

        }
    }

   


}
