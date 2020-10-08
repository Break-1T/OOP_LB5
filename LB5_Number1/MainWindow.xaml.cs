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

            #region Вывод координат
            ResultA.Text = $"({createSquare.PointA().X}; {createSquare.PointA().Y})";
            ResultB.Text = $"({createSquare.PointB().X}; {createSquare.PointB().Y})";
            ResultC.Text = $"({createSquare.PointC().X}; {createSquare.PointC().Y})";
            ResultD.Text = $"({createSquare.PointD().X}; {createSquare.PointD().Y})";
            #endregion
            DrawSquare();

        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            ResultA.Text = null;
            ResultB.Text = null;
            ResultC.Text = null;
            ResultD.Text = null;

            //First line AB
            LineA.X1 = 0;
            LineA.X2 = 0;
            LineA.Y1 = 0;
            LineA.Y2 = 0;
            //Second Line BC
            LineB.X1 = 0;
            LineB.X2 = 0;
            LineB.Y1 = 0;
            LineB.Y2 = 0;
            //Third Line CD
            LineC.X1 = 0;
            LineC.X2 = 0;
            LineC.Y1 = 0;
            LineC.Y2 = 0;
            //Fourth Line CA
            LineD.X1 = 0;
            LineD.X2 = 0;
            LineD.Y1 = 0;
            LineD.Y2 = 0;
        }
        private void DrawSquare()
        {
            CreateSquare createSquare = new CreateSquare(new CreatePoint(Convert.ToDouble(CoordinateX.Text), Convert.ToDouble(CoordinateY.Text), Convert.ToDouble(Length.Text)));
            //First line AB
            LineA.X1 = createSquare.PointA().X;
            LineA.X2 = createSquare.PointB().X;
            LineA.Y1 = createSquare.PointA().Y;
            LineA.Y2 = createSquare.PointB().Y;
            //Second Line BC
            LineB.X1 = createSquare.PointB().X;
            LineB.X2 = createSquare.PointC().X;
            LineB.Y1 = createSquare.PointB().Y;
            LineB.Y2 = createSquare.PointC().Y;
            //Third Line CD
            LineC.X1 = createSquare.PointC().X;
            LineC.X2 = createSquare.PointD().X;
            LineC.Y1 = createSquare.PointC().Y;
            LineC.Y2 = createSquare.PointD().Y;
            //Fourth Line CA
            LineD.X1 = createSquare.PointD().X;
            LineD.X2 = createSquare.PointA().X;
            LineD.Y1 = createSquare.PointD().Y;
            LineD.Y2 = createSquare.PointA().Y;

        }
    }
}
