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


namespace Number_guesser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isStarted = false;


        int min_number;
        int max_number;

        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Btn_StartStop_Click(object sender, RoutedEventArgs e)
        {
            if(!isStarted)
            {
                isStarted = true;

                min_number = Globals.min_number;
                max_number = Globals.max_number;

                Btn_Lower.Opacity = 100;
                Btn_Higher.Opacity = 100;
                Btn_StartStop.Opacity = 0;

                Btn_Lower.IsHitTestVisible = true;
                Btn_Higher.IsHitTestVisible = true;                
                Btn_StartStop.IsHitTestVisible = false;

                Btn_StartStop.Content = "Угадал!";
                Label_Guess.Content = "Больше " + ((min_number + max_number) / 2).ToString() + "?";
            }else
            {
                isStarted = false;
                Btn_Lower.Opacity = 0;
                Btn_Higher.Opacity = 0;

                min_number = Globals.min_number;
                max_number = Globals.max_number;

                Label_Guess.Content = "^___^ продолжим?";
                Btn_StartStop.Content = "Угу, давай";
            }
        }


        private void Btn_Lower_Click(object sender, RoutedEventArgs e)
        {            
            max_number = (min_number + max_number) / 2;

            if (max_number == min_number)
            {
                isStarted = false;
                Label_Guess.Content = "Ваше число = " + max_number.ToString() + " :)\n" + "^___^ продолжим?";
                Btn_StartStop.Content = "Угу, давай";
                Btn_StartStop.IsHitTestVisible = true;
                Btn_StartStop.Opacity = 100;
                Btn_Lower.Opacity = 0;
                Btn_Higher.Opacity = 0;
                Btn_Lower.IsHitTestVisible = false;
                Btn_Higher.IsHitTestVisible = false; 
            }
            else
            {
                Label_Guess.Content = "Больше " + ((min_number + max_number) / 2).ToString() + "?";
            }            
        }


        private void Btn_Higher_Click(object sender, RoutedEventArgs e)
        {            
            min_number = (min_number + max_number) / 2 + 1;

            if (max_number == min_number)
            {
                isStarted = false;
                Label_Guess.Content = "Ваше число = " + max_number.ToString() + " :)\n" + "^___^ продолжим?";
                Btn_StartStop.Content = "Угу, давай";
                Btn_StartStop.IsHitTestVisible = true;
                Btn_StartStop.Opacity = 100;
                Btn_Lower.Opacity = 0;
                Btn_Higher.Opacity = 0;
                Btn_Lower.IsHitTestVisible = false;
                Btn_Higher.IsHitTestVisible = false;
            }
            else
            {
                Label_Guess.Content = "Больше " + ((min_number + max_number) / 2).ToString() + "?";
            }            
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            isStarted = false;
            Btn_Lower.Opacity = 0;
            Btn_Higher.Opacity = 0;

            Btn_StartStop.Content = "Угадывай!";
            Btn_StartStop.IsHitTestVisible = true;
            Btn_StartStop.Opacity = 100;

            Btn_Lower.IsHitTestVisible = false;
            Btn_Higher.IsHitTestVisible = false;
            Label_Guess.Content = "Загадайте число от " + Globals.min_number.ToString() + " до " + Globals.max_number.ToString() + " :)";
        }


        private void Btn_Settings_Click(object sender, RoutedEventArgs e)
        {
            Window_settings settings = new Window_settings();
            settings.Owner = this;
            //settings.max_number_settings = max_number_global;
            settings.ShowDialog();
        }
    }
}
