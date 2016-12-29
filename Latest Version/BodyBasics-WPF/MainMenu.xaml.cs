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

namespace Microsoft.Samples.Kinect.BodyBasics
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Exam_Clicked(object sender, RoutedEventArgs e)
        {
            MainWindow examWindow = new MainWindow(usernameLabel.Text);
            App.Current.MainWindow = examWindow;
            this.Close();
            examWindow.Show();
        }

        private void AnalyticalViewBtn_Clicked(object sender, RoutedEventArgs e)
        {
           AnalyticalView analyticalWindow = new AnalyticalView(usernameLabel.Text);
            App.Current.MainWindow = analyticalWindow;
            this.Close();
            analyticalWindow.Show();
        }
    }
}
