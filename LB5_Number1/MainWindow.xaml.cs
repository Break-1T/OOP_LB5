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
            if (CoordinateX.Text != null || CoordinateY.Text != null || Length.Text != null)
            {
                try
                {
                    CreatePoint createPoint = new CreatePoint(Convert.ToDouble(CoordinateX.Text), Convert.ToDouble(CoordinateY.Text), Convert.ToDouble(Length.Text));
                    CreateSquare createSquare = new CreateSquare(createPoint);
                    if (createPoint.X == 311 && createPoint.Y == 240)
                        ShowZeroCoordinates(createSquare);
                    else
                        ShowCoordinates(createSquare);
                    DrawSquare(createSquare);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
                return;

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

            CoordinateX.Text = null;
            CoordinateY.Text = null;
            Length.Text = null;
        }
        private void DrawSquare(CreateSquare createSquare)
        {
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
        private void ShowCoordinates(CreateSquare createSquare)
        {
            ResultA.Text = $"({createSquare.PointA().X-311d}; {-(createSquare.PointA().Y-240d)})";
            ResultB.Text = $"({createSquare.PointB().X-311d}; {-(createSquare.PointB().Y-240d)})";
            ResultC.Text = $"({createSquare.PointC().X-311d}; {-(createSquare.PointC().Y-240d)})";
            ResultD.Text = $"({createSquare.PointD().X-311d}; {-(createSquare.PointD().Y-240d)})";
        }
        private void ShowZeroCoordinates(CreateSquare createSquare)
        {
            ResultA.Text = "(0;0)";
            ResultB.Text = "(0;0)";
            ResultC.Text = "(0;0)";
            ResultD.Text = "(0;0)";
        }
    }
}
