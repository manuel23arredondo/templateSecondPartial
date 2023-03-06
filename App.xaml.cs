using EC2202MAC.ViewModel;
using EC2202MAC.Views;

namespace EC2202MAC;

public partial class App : Application
{
	public new static App Current => (App)Application.Current;
	public IServiceProvider Services { get; }

	public App()
	{
		var services = new ServiceCollection();
		Services = ConfigureServices(services);
		InitializeComponent();

		MainPage = new AppShell();
	}

    static IServiceProvider ConfigureServices(ServiceCollection services)
    {
		//Services
		services.AddSingleton<IFunctions, Functions>();

		// ViewModel
		// Añadir cada ViewModel que se van a utilizar
		services.AddTransient<ViewModelPrueba>();
        services.AddTransient<StudentViewModel>();
		services.AddTransient<TeacherViewModel>();

        //Views
        //services.AddSingleton<MainPage>();
        services.AddSingleton<ListStudentsPage>();
		services.AddSingleton<ListTeachersPage>();

        return services.BuildServiceProvider();
    }
}