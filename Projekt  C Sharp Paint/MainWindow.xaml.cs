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

namespace Projekt__C_Sharp_Paint
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    
        private enum MyShape
        {
            Linia, Kolo, Prostokat
        }
        
        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        private void przyciskLinia(object sender, RoutedEventArgs e)
        {
            ksztalt = MyShape.Linia;
        }
 
        private void przyciskKolo(object sender, RoutedEventArgs e)
        {
            ksztalt = MyShape.Kolo;
        }
 
        private void przyciskProstokat(object sender, RoutedEventArgs e)
        {
            ksztalt = MyShape.Prostokat;
        }
        
        
    Point start;
    Point koniec;

    private void poczatekRysowania(object sender, MouseButtonEventArgs e)
    {
        
        start = e.GetPosition(this);
    }

    private void rysowanieKsztaltu(object sender, MouseButtonEventArgs e)
    {
        
        switch (ksztalt)
        {
            case MyShape.Linia:
                RysujLinie();
                break;

            case MyShape.Kolo:
                RysujKolo();
                break;

            case MyShape.Prostokat:
                RysujProstokat();
                break;

            default:
                return;
        }
    }



        private void rysowanieZmianaPozycji(object sender, MouseEventArgs e)
        {
            
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                koniec = e.GetPosition(this);
            }
        }

        
        private void RysujLinie()
        {
            Line nowaLinia = new Line()
            {
                Stroke = Brushes.Black,
                X1 = start.X,
                Y1 = start.Y - 50,
                X2 = koniec.X,
                Y2 = koniec.Y - 50
            };

            MyCanvas.Children.Add(nowaLinia);
        }


        private void RysujKolo()
        {
            Ellipse noweKolo = new Ellipse()
            {
                Stroke = Brushes.Blue,
                Fill = Brushes.Yellow,
                StrokeThickness = 7,
                Height = 11,
                Width = 11
            };


            if (koniec.X >= start.X)
            {
                
                noweKolo.SetValue(Canvas.LeftProperty, start.X);
                noweKolo.Width = koniec.X - start.X;
            }
            else
            {
                noweKolo.SetValue(Canvas.LeftProperty, koniec.X);
                noweKolo.Width = start.X - koniec.X;
            }

            if (koniec.Y >= start.Y)
            {
                
                noweKolo.SetValue(Canvas.TopProperty, start.Y - 50);
                noweKolo.Height = koniec.Y - start.Y;
            }
            else
            {
                noweKolo.SetValue(Canvas.TopProperty, koniec.Y - 50);
                noweKolo.Height = start.Y - koniec.Y;
            }

            MyCanvas.Children.Add(noweKolo);
        }
   private void RysujProstokat()
        {
            Rectangle nowyProstokat = new Rectangle()
            {
                Stroke = Brushes.Brown,
                Fill = Brushes.ForestGreen,
                StrokeThickness = 5
            };
 
            if (koniec.X >= start.X)
            {
                
                nowyProstokat.SetValue(Canvas.LeftProperty, start.X);
                nowyProstokat.Width = koniec.X - start.X;
            }
            else
            {
                nowyProstokat.SetValue(Canvas.LeftProperty, koniec.X);
                nowyProstokat.Width = start.X - koniec.X;
            }
 
            if (koniec.Y >= start.Y)
            {
               
                nowyProstokat.SetValue(Canvas.TopProperty, start.Y - 50);
                nowyProstokat.Height = koniec.Y - start.Y;
            }
            else
            {
                nowyProstokat.SetValue(Canvas.TopProperty, koniec.Y - 50);
                nowyProstokat.Height = start.Y - koniec.Y;
            }
 
            MyCanvas.Children.Add(nowyProstokat);
        }
 
        private void przyciskWyjdz(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
 
       
    }
}
