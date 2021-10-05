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

namespace CS_ASP_12
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
        //Add Images into the ImageBox start opacity at 0 then change to 100 when button is clicked then back to 0 so they dont overlap but how to add images then use the opacity command 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PencilBox.Opacity = 0.0;
            PenBox.Opacity = 0.0;
            PhoneBox.Opacity = 0.0;
            TabBox.Opacity = 0.0;

            if (PencilButton.IsChecked == true)
            {
                resultLabel.Content = "Pencil, very reliable";
                PencilBox.Opacity = 1.0;
            }
            else if (PenButton.IsChecked ==true)
            { 
                resultLabel.Content = "Pen, Nice Choice";
                PenBox.Opacity = 1.0;
            }
            else if (PhoneButton.IsChecked ==true)
            {
                resultLabel.Content = "you must be from the future";
                PhoneBox.Opacity = 1.0;
            }
            else if (PadButton.IsChecked ==true)
            {
                resultLabel.Content = "Welcome to 2021";
                TabBox.Opacity = 1.0;
            }
            else
            {
                resultLabel.Content = "You must pick one";
            }
               
            
        }
    }
}
