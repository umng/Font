using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Font
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private calculate cal;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required; 
            cal = new calculate();


        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            string text = tb_text.Text;

            string character = cmb_character.SelectionBoxItem.ToString();

            string size = cmb_size.SelectedItem.ToString();

            string bold="", italic="", underline="";

            int length = text.Length;

            string Answer="";

            if(cb_bold.IsChecked==true)
            {
                bold = "Bold";
            }
            if (cb_bold.IsChecked == false)
            {
                bold = "";
            }

            if (cb_italic.IsChecked == true)
            {
                italic = "Italic";
            }
            if (cb_italic.IsChecked == false)
            {
                italic = "";
            }

            if (cb_underline.IsChecked == true)
            {
                underline = "Underline";
            }
            if (cb_underline.IsChecked == false)
            {
                underline = "";
            }



            cal.calculated(tb_text.Text, character, size, bold, italic, underline,length);

            NavigationContext nav = new NavigationContext()
            {
                Text = text,
                Answer=cal.answer

            };

            if (text == "")
            {
                var dialog = new MessageDialog("You have not entered anything.\n\nPlease enter something.");
                dialog.Title = "INVALID INPUT";
                await dialog.ShowAsync();
            }
            else
            {
            Frame.Navigate(typeof(ans),nav);
            }

        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            tb_text.Text = "";
        }

        private void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(About));
        }
    }
}
