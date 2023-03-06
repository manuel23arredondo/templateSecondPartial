namespace EC2202MAC.ViewModel
{
    public partial class TeacherViewModel : ObservableObject
    {
        public ObservableCollection<TeacherModel> Teachers { get; set; } = new();

        [RelayCommand]
        public async Task ListTeachers()
        {
            Teachers.Clear();
            Teachers.Add(new TeacherModel() { FirstName = "Eduardo", LastName = "Fong", Email = "eduardo.fong@umad.edu.mx", Phone = "2726558942"});
            Teachers.Add(new TeacherModel() { FirstName = "Carlos", LastName = "Zapata", Email = "carlos.zapata@umad.edu.mx", Phone = "2726557821"});
            Teachers.Add(new TeacherModel() { FirstName = "Patricia", LastName = "Hernández", Email = "patricia.hernandez@umad.edu.mx", Phone = "2513558942"});
            Teachers.Add(new TeacherModel() { FirstName = "Nicolás", LastName = "Arrioja", Email = "nicolas.arrioja@umad.edu.mx", Phone = "2726544989"});
        }
    }
}
