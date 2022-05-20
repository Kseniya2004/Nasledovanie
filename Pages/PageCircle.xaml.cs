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
using Nasledovanie.Classes;

namespace Nasledovanie.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCircle.xaml
    /// </summary>
    public partial class PageCircle : Page
    {
        public PageCircle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Circle c;
            double p, s;
            lstTable.Items.Clear();
            c = new Circle(double.Parse(txtR.Text));
            p = c.Perimetr();
            s = c.Square();            
            
            lstTable.Items.Add($"Радиус={txtR.Text}");
            lstTable.Items.Add($"Периметр = {Math.Round(p,2)}");
            lstTable.Items.Add($"Площадь = {Math.Round(s,2)}");


        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            clsFrame.frmObject.Navigate(new PageRectangle());
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstTable.Items.Clear();
        }
    }
}
