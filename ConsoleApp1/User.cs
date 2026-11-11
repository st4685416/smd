namespace ConsoleApp1
{
	internal class User : IEntity
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public User(string email, string firstName, string lastName)
		{
			Email = email;
			FirstName = firstName;
			LastName = lastName;
		}

		public override string ToString()
		{
			return $"Id: {Id}, Email: {Email}, Name: {FirstName} {LastName}";
		}
	}
}