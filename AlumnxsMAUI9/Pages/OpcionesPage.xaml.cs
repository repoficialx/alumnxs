namespace AlumnxsMAUI9.Pages;

public partial class OpcionesPage : ContentPage
{
	public OpcionesPage()
	{
		InitializeComponent();
	}

    private void OnThemeToggled(object sender, ToggledEventArgs e)
    {
        Application.Current!.UserAppTheme = e.Value ? AppTheme.Dark : AppTheme.Light;
    }

}