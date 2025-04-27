using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CLASH
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // Load the ClipView on initial startup
            ContentFrame.Navigate(typeof(ClipView));
        }

        private void ClipViewButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(ClipView));
        }

        private void SequenceViewButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(SequenceView));
        }
    }
}
