namespace EC2202MAC.ViewModel
{
    public partial class StudentViewModel : ObservableObject
    {
        public ObservableCollection<StudentModels> Students { get; set; } = new();

        [RelayCommand]
        public async Task ListStudents()
        {
            Students.Clear();
            Students.Add(new StudentModels() { FirstName = "Diego", LastName = "Garzón" });
            Students.Add(new StudentModels() { FirstName = "Samuel", LastName = "Díaz" });
            Students.Add(new StudentModels() { FirstName = "Manuel", LastName = "Arredondo" });
            Students.Add(new StudentModels() { FirstName = "Jessé", LastName = "Cerezo" });
            Students.Add(new StudentModels() { FirstName = "Alfonso", LastName = "Hernández" });
            Students.Add(new StudentModels() { FirstName = "Yael", LastName = "Palacios" });
            Students.Add(new StudentModels() { FirstName = "Edwin", LastName = "Lozada" });
            Students.Add(new StudentModels() { FirstName = "Alejandro", LastName = "Barroeta" });
            Students.Add(new StudentModels() { FirstName = "Luis", LastName = "Navarro" });
        }
    }
}