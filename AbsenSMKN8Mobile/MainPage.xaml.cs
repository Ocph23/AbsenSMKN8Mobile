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
                
            //proses login
            //send user and passwword to website 
            // result -> Siswa



            Shell.Current.Navigation.PushAsync(new BreedPage());
        }
    }

}
