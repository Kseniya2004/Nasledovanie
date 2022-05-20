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
using Rectangle = Nasledovanie.Classes.Rectangle;

namespace Nasledovanie.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageRectangle.xaml
    /// </summary>
    public partial class PageRectangle : Page
    {
        public PageRectangle()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            clsFrame.frmObject.Navigate(new PageCircle());
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Rectangle r;
            double p, s;
            lstTable.Items.Clear();
            r = new Rectangle(double.Parse(txtA.Text),double.Parse(txtB.Text));
            p = r.Perimetr();
            s = r.Square();

            lstTable.Items.Add($"Стороны a = {txtA.Text}, b = {txtB.Text}");
            lstTable.Items.Add($"Периметр = {Math.Round(p, 2)}");
            lstTable.Items.Add($"Площадь = {Math.Round(s, 2)}");
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
             clsFrame.frmObject.Navigate(new PageTriangle());
                    
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstTable.Items.Clear();
        }
    }
}
