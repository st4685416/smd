namespace ConsoleApp1
{
	internal class DisplayService
	{
		public void PrintActors(DBItem<Actor> actors)
		{
			Console.WriteLine("ACTORS");
			foreach (Actor a in actors.Items)
			{
				Console.WriteLine(a);
			}
		}

		public void PrintUseCases(DBItem<UseCase> useCases)
		{
			Console.WriteLine("\nUSE CASES");
			foreach (UseCase uc in useCases.Items)
			{
				Console.WriteLine(uc);
			}
		}

		public void PrintActorUseCases(DBItem<Actor> actors, DBItem<UseCase> useCases, DBItem<ActorUseCase> actorUseCases)
		{
			Console.WriteLine("\nACTOR USE CASES");
			foreach (Actor a in actors.Items)
			{
				Console.WriteLine(a);
				foreach (ActorUseCase auc in actorUseCases.Items)
				{
					if (a.Id == auc.ActorId)
					{
						foreach (UseCase uc in useCases.Items)
						{
							if (auc.UseCaseId == uc.Id)
							{
								Console.WriteLine($"   -> {uc.Name} ({uc.Type})");
							}
						}
					}
				}
			}
		}
	}
}