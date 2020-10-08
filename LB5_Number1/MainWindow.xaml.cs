using LB5_Number1.SquareSolution;
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

namespace LB5_Number1
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

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            CreateSquare createSquare = new CreateSquare(new CreatePoint(Convert.ToDouble(CoordinateX.Text), Convert.ToDouble(CoordinateY.Text), Convert.ToDouble(Length.Text)));
            ResultA.Text = $"({createSquare.PointA().X}; {createSquare.PointA().Y})";
            ResultB.Text = $"({createSquare.PointB().X}; {createSquare.PointB().Y})";
            ResultC.Text = $"({createSquare.PointC().X}; {createSquare.PointC().Y})";
            ResultD.Text = $"({createSquare.PointD().X}; {createSquare.PointD().Y})";
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
