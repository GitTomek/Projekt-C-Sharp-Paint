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
    }
}
