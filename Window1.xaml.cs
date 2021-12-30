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

namespace WpfApp3
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window1 : Window
    {
        Color currentStrokeColor = Colors.Black;
        Brush currentStrokeBrush = new SolidColorBrush(Colors.PaleGreen);
        Brush currentStrokeBrush1 = new SolidColorBrush(Colors.Pink);
        public Window1()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
          
            textBlock.Text = label + "分數:" +label1+ label2 + "分數:" +label3+ label4 + "分數:"+label5;
            if (slider.Value + slider1.Value + slider2.Value > 60)
            {
                textBlock.Background = currentStrokeBrush;
            }
            else
                textBlock.Background= currentStrokeBrush1;


        }

        
    }
}
