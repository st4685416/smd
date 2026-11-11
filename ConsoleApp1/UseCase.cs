namespace ConsoleApp1
{
	internal class UseCase : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }

		public UseCase(string name, string type)
		{
			Name = name;
			Type = type;
		}

		public override string ToString()
		{
			return $"Id: {Id}, Name: {Name}, Type: {Type}";
		}
	}
}