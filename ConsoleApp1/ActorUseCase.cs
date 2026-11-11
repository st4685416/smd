namespace ConsoleApp1
{
	internal class ActorUseCase : IEntity
	{
		public int Id { get; set; }
		public int ActorId { get; set; }
		public int UseCaseId { get; set; }

		public ActorUseCase(int actorId, int useCaseId)
		{
			ActorId = actorId;
			UseCaseId = useCaseId;
		}

		public override string ToString()
		{
			return $"Id: {Id}, ActorId: {ActorId}, UseCaseId: {UseCaseId}";
		}
	}
}