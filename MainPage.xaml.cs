namespace EC2202MAC;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
        BindingContext = App.Current.Services.GetRequiredService<IFunctions>();
        InitializeComponent();
    }
}

