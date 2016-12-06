using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Xbox
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DoAsync();
            
        }

        public async void DoAsync()
        {
            ServiceReference1.Service1Client client = new
                             ServiceReference1.Service1Client();
            int textboxinputInt = Convert.ToInt32(textBox1.Text);

            var task1 = client.GetDataAsync(textboxinputInt);

           // await Task.Delay(100);
            // In the Real World, we would actually do something...
            // For this example, we're just going to (asynchronously) wait 100ms.

            string x = await task1;

            textBox.Text = x;



        }

        public async Task<string> DoSomethingAsync()
        {
            await Task.Delay(100);
            // In the Real World, we would actually do something...
            // For this example, we're just going to (asynchronously) wait 100ms.
            ServiceReference1.Service1Client client = new
                 ServiceReference1.Service1Client();

            string returnString;

            returnString =await client.GetDataAsync(3);
            return returnString;
            
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
