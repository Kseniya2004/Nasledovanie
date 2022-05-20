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
    /// Логика взаимодействия для PageTriangle.xaml
    /// </summary>
    public partial class PageTriangle : Page
    {
        public PageTriangle()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            clsFrame.frmObject.Navigate(new PageRectangle());
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Triangle t;
            double p, s;
            lstTable.Items.Clear();
            t = new Triangle(double.Parse(txta.Text), double.Parse(txtb.Text), double.Parse(txtc.Text));
            if (t.Exists)
            {
                p = t.Perimetr();
                s = t.Square();
                lstTable.Items.Add($"Стороны a = {txta.Text}, b = {txtb.Text}, c = {txtc.Text}");
                lstTable.Items.Add($"Периметр = {Math.Round(p, 2)}");
                lstTable.Items.Add($"Площадь = {Math.Round(s, 2)}");
            }
            else
            { 
                lstTable.Items.Add($"Стороны a = {txta.Text}, b = {txtb.Text}, c = {txtc.Text}");
                lstTable.Items.Add("С заданными длинами сторон треугольник не может быть построен");
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstTable.Items.Clear();
        }
    }
}
