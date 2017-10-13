using Xamarin.Forms;

namespace CustomBackButton
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnCarePlanDetailsPressed(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CarePlanDetailPage());
        }
    }
}
