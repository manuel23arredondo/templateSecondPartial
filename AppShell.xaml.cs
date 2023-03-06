namespace EC2202MAC;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ListStudentsPage), typeof(ListStudentsPage));
        Routing.RegisterRoute(nameof(ListTeachersPage), typeof(ListTeachersPage));
		Routing.RegisterRoute(nameof(DetailStudentPage), typeof(DetailStudentPage));
    }
}
