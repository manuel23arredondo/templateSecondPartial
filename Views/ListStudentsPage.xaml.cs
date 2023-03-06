namespace EC2202MAC.Views;

public partial class ListStudentsPage : ContentPage
{
	public ListStudentsPage()
	{
        BindingContext = App.Current.Services.GetRequiredService<StudentViewModel>();
        InitializeComponent();
	}
}