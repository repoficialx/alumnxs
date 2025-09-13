using System;
using System.IO;
using Microsoft.Maui.Controls;

namespace AlumnxsMAUI9.Pages;

public partial class NuevoUsuarioPage : ContentPage
{
    // Ruta base donde se guardarán los archivos
    private readonly string _directorioDestino =
    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Alumnxs", "allist");

    public NuevoUsuarioPage()
	{
		InitializeComponent();
	}

    private async void OnGuardarArchivoClicked(object sender, EventArgs e)
    {
        /*try
        {
            // Obtener los valores de los controles
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            string nombre = ((Entry)this.FindByName("NombreEntry"))?.Text?.Trim();

            string fechaNacimiento = ((Entry)this.FindByName("FechaNacimientoEntry"))?.Text?.Trim();
            string telefono = ((Entry)this.FindByName("TelefonoEntry"))?.Text?.Trim();
            string email = ((Entry)this.FindByName("EmailEntry"))?.Text?.Trim();
            string genero = ((Picker)this.FindByName("GeneroPicker"))?.SelectedItem?.ToString();
            string notas1 = ((Entry)this.FindByName("Notas1Entry"))?.Text?.Trim();
            string notas2 = ((Entry)this.FindByName("Notas2Entry"))?.Text?.Trim();
            string notas3 = ((Editor)this.FindByName("Notas3Editor"))?.Text?.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                await DisplayAlert("Error", "El nombre es obligatorio.", "OK");
                return;
            }

            // Asegurarse de que la carpeta exista
            if (!Directory.Exists(_directorioDestino))
            {
                Directory.CreateDirectory(_directorioDestino);
            }

            // Ruta final del archivo
            string rutaArchivo = Path.Combine(_directorioDestino, $"{nombre}.txt");

            // Contenido del archivo
            string contenido = $"Nombre: {nombre}\n" +
                               $"Fecha de nacimiento: {fechaNacimiento}\n" +
                               $"Teléfono: {telefono}\n" +
                               $"E·Mail: {email}\n" +
                               $"Género: {genero}\n" +
                               $"Notas1: {notas1}\n" +
                               $"Notas2: {notas2}\n" +
                               $"Notas3: {notas3}\n" +
                               $"Guardado: {DateTime.Now}";

            // Guardar archivo
            File.WriteAllText(rutaArchivo, contenido);

            await DisplayAlert("Éxito", $"Usuario guardado como: {rutaArchivo}", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"No se pudo guardar: {ex.Message}", "OK");
        }*/
        var alumnoHtml = $"""
    <div class="alumno">
        <h2>{NombreEntry.Text}</h2>
        <p><strong>Fecha de nacimiento:</strong> {FechaNacimientoEntry.Text}</p>
        <p><strong>Teléfono:</strong> {TelefonoEntry.Text}</p>
        <p><strong>Email:</strong> {EmailEntry.Text}</p>
        <p><strong>Género:</strong> {GeneroPicker.SelectedItem}</p>
        <p><strong>Notas:</strong><br>
        1: {Notas1Entry.Text}<br>
        2: {Notas2Entry.Text}<br>
        3: {Notas3Editor.Text}</p>
        <hr>
    </div>
""";

        var indexPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Alumnxs", "allist", "index.html");
        string contenido = File.ReadAllText(indexPath);

        // Buscamos el cierre de </body> y metemos el alumnoHtml justo antes
        int bodyCloseIndex = contenido.IndexOf("</body>", StringComparison.OrdinalIgnoreCase);

        if (bodyCloseIndex != -1)
        {
            var nuevoContenido = contenido.Insert(bodyCloseIndex, alumnoHtml);
            File.WriteAllText(indexPath, nuevoContenido);
            await DisplayAlert("Éxito", "Alumno añadido correctamente.", "OK");
        }
        else
        {
            await DisplayAlert("Error", "No se encontró la etiqueta </body> en el archivo HTML.", "OK");
        }

    }
}
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL