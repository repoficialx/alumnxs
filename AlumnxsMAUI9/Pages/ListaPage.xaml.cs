namespace AlumnxsMAUI9.Pages;

public partial class ListaPage : ContentPage
{
	public ListaPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

var appFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Alumnxs", "allist");
        // Convertimos a URI
        string folderUri = new Uri(appFolder + Path.DirectorySeparatorChar).AbsoluteUri;

        
        var indexPath = Path.Combine(appFolder, "index.html");

        if (!Directory.Exists(appFolder))
            Directory.CreateDirectory(appFolder);

        if (!File.Exists(indexPath))
        {
            // Copiar desde el paquete
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Templates", "template.html");
            File.Copy(templatePath, indexPath);
        }

        // Cargar en WebView
        AlumnxsWebView.Source = new UrlWebViewSource
        {
            Url = $"file:///{indexPath.Replace("\\", "/")}"
        };
    }

}