namespace WineShop;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void searchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        // Implement your search logic here
        string searchText = searchBar.Text;
        // For example: filter a list or navigate to a search results page
        // Example: Display an alert with the search text
        DisplayAlert("Search", $"You searched for: {searchText}", "OK");
    }

    private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        // Implement your search logic here
        string searchText = searchBar.Text;
        // For example: filter a list or navigate to a search results page
        // Example: Display an alert with the search text
        DisplayAlert("Search", $"You searched for: {searchText}", "OK");
    }
}

