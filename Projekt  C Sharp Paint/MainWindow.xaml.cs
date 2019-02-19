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
    }
}
