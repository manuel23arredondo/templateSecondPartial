namespace EC2202MAC.Views;

public partial class ListTeachersPage : ContentPage
{
	public ListTeachersPage()
	{
        BindingContext = App.Current.Services.GetRequiredService<TeacherViewModel>();
        InitializeComponent();
	}
}