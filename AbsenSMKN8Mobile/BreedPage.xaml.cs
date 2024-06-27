using AbsenSMKN8Mobile.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Text.Json;

namespace AbsenSMKN8Mobile;

public partial class BreedPage : ContentPage
{

	public ObservableCollection<Breed> DataSource { get; set; } = new ObservableCollection<Breed>();
    public BreedPage()
	{
		InitializeComponent();
        Loaded += BreedPage_Loaded;
        BindingContext = this;
        
	}

    private async void BreedPage_Loaded(object? sender, EventArgs e)
    {
		using (var http = new HttpClient())
		{
			http.BaseAddress = new Uri("https://dogapi.dog");
			var result = await http.GetFromJsonAsync<BreadResponse>("/api/v2/breeds");
            foreach (var item in result.Data)
            {
                DataSource.Add(item);
            }
        }
    }
}