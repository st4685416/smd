namespace ConsoleApp1
{
	internal class Actor : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Actor(string name)
		{
			Name = name;
		}

		public override string ToString()
		{
			return $"Id: {Id}, Name: {Name}";
		}
	}
}