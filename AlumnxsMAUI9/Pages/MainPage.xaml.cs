using AlumnxsMAUI9.Models;
using AlumnxsMAUI9.PageModels;

namespace AlumnxsMAUI9.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}