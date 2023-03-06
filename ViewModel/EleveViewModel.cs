namespace EC2202MAC.ViewModel
{
    public partial class EleveViewModel:ObservableValidator
    {
		private string firstName;
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}
	}
}
