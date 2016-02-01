using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Font
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ans : Page
    {
        private calculate cal;

        public string Character, Size, Bold, Italic, Underline;
        public ans()
        {
            this.InitializeComponent();
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
            cal = new calculate();

            //cal.calculated(tb_text.Text, Character, Size, Bold, Italic, Underline);
            //tb_ans.Text = cal.answer;
            //ring.IsActive = false;
        }


        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame == null)
            {
                return;
            }
            if (frame.CanGoBack)
            {
                frame.GoBack();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var nav = (NavigationContext)e.Parameter;
            tb_text.Text = nav.Text;
            tb_ans.Text = nav.Answer;
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            tb_ans.Height = 0.1;
            TextBox tb_anse = new TextBox();
            tb_anse.IsEnabled = true;
            tb_anse.TextWrapping = Windows.UI.Xaml.TextWrapping.Wrap;
            tb_anse.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch;
            tb_anse.Text = tb_ans.Text;
            sp.Children.Add(tb_anse);
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(About));
        }
    }
}
