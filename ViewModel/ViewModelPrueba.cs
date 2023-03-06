using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace EC2202MAC.ViewModel
{
    partial class ViewModelPrueba : ObservableObject
    {
        [ObservableProperty]
        string text;

        [ObservableProperty]
        int count = 0;
        private readonly IFunctions functions;

        [RelayCommand]
        public void CambiarTexto()
        {
            Count++;
            Text = this.functions.CambiarTexto("Hola mundo", Count);
        }

        public ViewModelPrueba()=>
            this.functions = App.Current.Services.GetRequiredService<IFunctions>();
    }
}
