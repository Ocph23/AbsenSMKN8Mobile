namespace AbsenSMKN8Mobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PushAsync(new Page1());
        }
    }

}
