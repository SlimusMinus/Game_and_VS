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

namespace VS_window
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

        private void TextBox_MouseMove(object sender, MouseEventArgs e)
        {
            Search.Text = ""; 
        }

        private void Search_MouseLeave(object sender, MouseEventArgs e)
        {
            Search.Opacity = 50;
            Search.Text = "Search options (CTRL+E)";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ColorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int str = ColorBox.SelectedIndex;
            if (str == 0)
            {
                Grid_VS.Background = new SolidColorBrush(Colors.Black);
                Color_name.Background = new SolidColorBrush(Colors.Black);
                Color_name.BorderBrush = new SolidColorBrush(Colors.Black);
                LongText.Background = new SolidColorBrush(Colors.Black);
                LongText.BorderBrush = new SolidColorBrush(Colors.Black);
                text_box_1.Background = new SolidColorBrush(Colors.Black);
                text_box_1.BorderBrush = new SolidColorBrush(Colors.Black);
                text_box_2.Background = new SolidColorBrush(Colors.Black);
                text_box_2.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else if (str == 1)
            {
                Grid_VS.Background = new SolidColorBrush(Colors.DarkBlue);
                Color_name.Background = new SolidColorBrush(Colors.DarkBlue);
                Color_name.BorderBrush = new SolidColorBrush(Colors.DarkBlue);
                LongText.Background = new SolidColorBrush(Colors.DarkBlue);
                LongText.BorderBrush = new SolidColorBrush(Colors.DarkBlue);
                text_box_1.Background = new SolidColorBrush(Colors.DarkBlue);
                text_box_1.BorderBrush = new SolidColorBrush(Colors.DarkBlue);
                text_box_2.Background = new SolidColorBrush(Colors.DarkBlue);
                text_box_2.BorderBrush = new SolidColorBrush(Colors.DarkBlue);
            }
            else if (str == 2)
            {
                Grid_VS.Background = new SolidColorBrush(Colors.White);
                Color_name.Background = new SolidColorBrush(Colors.White);
                Color_name.BorderBrush = new SolidColorBrush(Colors.White);
                LongText.Background = new SolidColorBrush(Colors.White);
                LongText.BorderBrush = new SolidColorBrush(Colors.White);
                text_box_1.Background = new SolidColorBrush(Colors.White);
                text_box_1.BorderBrush = new SolidColorBrush(Colors.White);
                text_box_2.Background = new SolidColorBrush(Colors.White);
                text_box_2.BorderBrush = new SolidColorBrush(Colors.White);
            }
            else if (str == 3)
            {
                Grid_VS.Background = new SolidColorBrush(Colors.Yellow);
                Color_name.Background = new SolidColorBrush(Colors.Yellow);
                Color_name.BorderBrush = new SolidColorBrush(Colors.Yellow);
                LongText.Background = new SolidColorBrush(Colors.Yellow);
                LongText.BorderBrush = new SolidColorBrush(Colors.Yellow);
                text_box_1.Background = new SolidColorBrush(Colors.Yellow);
                text_box_1.BorderBrush = new SolidColorBrush(Colors.Yellow);
                text_box_2.Background = new SolidColorBrush(Colors.Yellow);
                text_box_2.BorderBrush = new SolidColorBrush(Colors.Yellow);
            }
        }
    }
}
