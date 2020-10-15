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

                    ShowCoordinates(createSquare);
                    DrawSquare(createSquare);
                }
                catch
                {
                    throw new Exception("Произошла ошибка");
                }
            }
            else
                return;
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            //Координаты точек
            ResultAX.Text = null;
            ResultBX.Text = null;
            ResultCX.Text = null;
            ResultDX.Text = null;
            ResultAY.Text = null;
            ResultBY.Text = null;
            ResultCY.Text = null;
            ResultDY.Text = null;

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

            //Ввод координат и длина
            CoordinateX.Text = "0";
            CoordinateY.Text = "0";
            Length.Text = "0";
        }

        private void DrawSquare(CreateSquare createSquare)
        {
            //First line AB
            LineA.X1 = createSquare.GetPointA().X;
            LineA.X2 = createSquare.GetPointB().X;
            LineA.Y1 = createSquare.GetPointA().Y;
            LineA.Y2 = createSquare.GetPointB().Y;
            //Second Line BC
            LineB.X1 = createSquare.GetPointB().X;
            LineB.X2 = createSquare.GetPointC().X;
            LineB.Y1 = createSquare.GetPointB().Y;
            LineB.Y2 = createSquare.GetPointC().Y;
            //Third Line CD
            LineC.X1 = createSquare.GetPointC().X;
            LineC.X2 = createSquare.GetPointD().X;
            LineC.Y1 = createSquare.GetPointC().Y;
            LineC.Y2 = createSquare.GetPointD().Y;
            //Fourth Line CA
            LineD.X1 = createSquare.GetPointD().X;
            LineD.X2 = createSquare.GetPointA().X;
            LineD.Y1 = createSquare.GetPointD().Y;
            LineD.Y2 = createSquare.GetPointA().Y;

        }
        private void ShowCoordinates(CreateSquare createSquare)
        {
            ResultAX.Text = $"{createSquare.GetPointA().X-311d}";
            ResultBX.Text = $"{createSquare.GetPointB().X-311d}";
            ResultCX.Text = $"{createSquare.GetPointC().X-311d}";
            ResultDX.Text = $"{createSquare.GetPointD().X-311d}";

            ResultAY.Text = $"{-(createSquare.GetPointA().Y - 240d)}";
            ResultBY.Text = $"{-(createSquare.GetPointB().Y - 240d)}";
            ResultCY.Text = $"{-(createSquare.GetPointC().Y - 240d)}";
            ResultDY.Text = $"{-(createSquare.GetPointD().Y - 240d)}";
        }
        private void Grid_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    {
                        CreatePoint createPoint = new CreatePoint(Convert.ToDouble(ResultAX.Text), Convert.ToDouble(ResultAY.Text), Convert.ToDouble(Length.Text));
                        CreateSquare createSquare = new CreateSquare(createPoint);

                        ShowCoordinates(createSquare.MoveLeft());
                        DrawSquare(createSquare.MoveLeft());
                        break;
                    }

                case Key.Right:
                    {
                        CreatePoint createPoint = new CreatePoint(Convert.ToDouble(ResultAX.Text), Convert.ToDouble(ResultAY.Text), Convert.ToDouble(Length.Text));
                        CreateSquare createSquare = new CreateSquare(createPoint);

                        ShowCoordinates(createSquare.MoveRight());
                        DrawSquare(createSquare.MoveRight());
                        break;
                    }
                case Key.Up:
                    {
                        CreatePoint createPoint = new CreatePoint(Convert.ToDouble(ResultAX.Text), Convert.ToDouble(ResultAY.Text), Convert.ToDouble(Length.Text));
                        CreateSquare createSquare = new CreateSquare(createPoint);

                        ShowCoordinates(createSquare.MoveUP());
                        DrawSquare(createSquare.MoveUP());
                        break;
                    }
                case Key.Down:
                    {
                        CreatePoint createPoint = new CreatePoint(Convert.ToDouble(ResultAX.Text), Convert.ToDouble(ResultAY.Text), Convert.ToDouble(Length.Text));
                        CreateSquare createSquare = new CreateSquare(createPoint);

                        ShowCoordinates(createSquare.MoveDown());
                        DrawSquare(createSquare.MoveDown());
                        break;
                    }   
            }
        }
    }
}
