namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DBItem<Actor> actorDB = new DBItem<Actor>();
            int a1 = actorDB.AddItem(new Actor("Покупець"));
            int a2 = actorDB.AddItem(new Actor("Адміністратор"));

            DBItem<UseCase> useCaseDB = new DBItem<UseCase>();
            int uc1 = useCaseDB.AddItem(new UseCase("Управління даними щодо користувачів", "CRUD-операції"));
            int uc2 = useCaseDB.AddItem(new UseCase("Управління даними щодо дисконтних карток", "CRUD-операції"));
            int uc3 = useCaseDB.AddItem(new UseCase("Управління даними щодо категорій товарів", "CRUD-операції"));
            int uc4 = useCaseDB.AddItem(new UseCase("Управління даними щодо товарів", "CRUD-операції"));
            int uc5 = useCaseDB.AddItem(new UseCase("Управління даними щодо замовлень", "CRUD-операції"));
            int uc6 = useCaseDB.AddItem(new UseCase("Управління даними щодо позицій замовлень", "CRUD-операції"));
            int uc7 = useCaseDB.AddItem(new UseCase("Отримання даних щодо користувачів та їх дисконтних карток", "Service"));
            int uc8 = useCaseDB.AddItem(new UseCase("Отримання даних щодо товарів та їх категорій", "Service"));
            int uc9 = useCaseDB.AddItem(new UseCase("Отримання даних щодо замовлень та їх позицій", "Service"));

            DBItem<ActorUseCase> actorUseCaseDB = new DBItem<ActorUseCase>();
            actorUseCaseDB.AddItem(new ActorUseCase(a1, uc1));
            actorUseCaseDB.AddItem(new ActorUseCase(a1, uc5));
            actorUseCaseDB.AddItem(new ActorUseCase(a1, uc6));
            actorUseCaseDB.AddItem(new ActorUseCase(a1, uc7));
            actorUseCaseDB.AddItem(new ActorUseCase(a1, uc8));
            actorUseCaseDB.AddItem(new ActorUseCase(a1, uc9));

            actorUseCaseDB.AddItem(new ActorUseCase(a2, uc2));
            actorUseCaseDB.AddItem(new ActorUseCase(a2, uc3));
            actorUseCaseDB.AddItem(new ActorUseCase(a2, uc4));
            actorUseCaseDB.AddItem(new ActorUseCase(a2, uc7));
            actorUseCaseDB.AddItem(new ActorUseCase(a2, uc8));
            actorUseCaseDB.AddItem(new ActorUseCase(a2, uc9));

            DisplayService display = new DisplayService();
            display.PrintActors(actorDB);
            display.PrintUseCases(useCaseDB);
            display.PrintActorUseCases(actorDB, useCaseDB, actorUseCaseDB);
        }
    }
}