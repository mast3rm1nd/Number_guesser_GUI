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
using System.Windows.Shapes;

namespace Number_guesser
{
    /// <summary>
    /// Interaction logic for Window_settings.xaml
    /// </summary>
    public partial class Window_settings : Window
    {
        //public int max_number_settings = 0;
        public Window_settings()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
              if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)))
                 e.Handled = true;
        }

        private void Windows_settings_Loaded(object sender, RoutedEventArgs e)
        {
            TextBox_MaxNumber.Text = Globals.max_number.ToString();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow main_window = new MainWindow();
            Globals.max_number = Convert.ToInt32(TextBox_MaxNumber.Text);
            Close();
            //main_window.Show();
        }

        private void Windows_settings_Closed(object sender, EventArgs e)
        {
            //MainWindow main_window = new MainWindow();
            var myObject = this.Owner as MainWindow;
            myObject.Window_Loaded(this, null); // Call your method here.
            Close();
            //main_window.Show();
        }


             
       
    }
}
