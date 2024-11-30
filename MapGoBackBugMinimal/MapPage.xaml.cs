namespace MapGoBackBugMinimal;

public partial class MapPage : ContentPage
{
    public MapPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}