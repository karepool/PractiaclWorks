namespace Lesson7;

public class Program {

    public static void Main(string[] args) {

        var workerRepository = new WorkerRepository("out.txt");
        var worker = new Worker();
        int id;
        DateTime[] dateFromTo = new DateTime[2];

        while(true) {
            Console.Clear();
            Console.WriteLine(
                "Choose:\n\t" +
                "1 - Add Worker\n\t" +
                "2 - Get All Workers\n\t" +
                "3 - Get Worker By Id\n\t" +
                "4 - Delete Worker By Id\n\t" +
                "5 - Get Workers Between Two Dates\n\t" +
                "6 - Sort Workers\n\t" +
                "other - Exit\n\t" 
                );

            switch(Console.ReadLine()) {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Addition worker\n\n");
                    FillWorker(ref worker);
                    workerRepository.AddWorker(worker);
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("All workers from file\n\n");
                    
                    foreach(Worker w in workerRepository.GetAllWorkers())
                        Console.WriteLine(w.ToString());

                    Console.Write("\npress any button to continue...");
                    Console.ReadKey();
                    break;

                case "3":
                    Console.Clear();
                    Console.Write("Enter a Id to find: ");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(workerRepository.GetWorkerById(id).ToString());
                    
                    Console.Write("\npress any button to continue...");
                    Console.ReadKey();
                    break;

                case "4":
                    Console.Clear();
                    Console.Write("Enter a Id to delete: ");
                    id = int.Parse(Console.ReadLine());
                    workerRepository.DeleteWorker(id);
                    
                    Console.Write("\npress any button to continue...");
                    Console.ReadKey();
                    break; 
                
                case "5":
                    Console.Clear();
                    Console.Write("Enter a DateFrom: ");
                    dateFromTo[0] = DateTime.Parse(Console.ReadLine());

                    Console.Write("Enter a DateTo: ");
                    dateFromTo[1] = DateTime.Parse(Console.ReadLine());

                    foreach(Worker w in workerRepository.GetWorkersBetweenTwoDates(dateFromTo[0], dateFromTo[1]))
                        Console.WriteLine(w.ToString());

                    Console.Write("\npress any button to continue...");
                    Console.ReadKey();
                    break; 
            
                case "6":
                    Console.Clear();
                    Console.Write(
                        "Choose Sort By: \n\t" +
                        "1 - Full Name\n\t" +
                        "2 - Date Of Birth\n\t" + 
                        "3 - Age\n\t" +
                        "other - back\n"
                        );
                    switch(Console.ReadLine()) {
                        case "1":
                            foreach(Worker w in workerRepository.GetAllWorkers().OrderBy(wr => wr.FullName))
                                Console.WriteLine(w.ToString());
                            break; 

                        case "2":
                            foreach(Worker w in workerRepository.GetAllWorkers().OrderBy(wr => wr.DateOfBirth))
                                Console.WriteLine(w.ToString());
                            break; 

                        case "3":
                            foreach(Worker w in workerRepository.GetAllWorkers().OrderBy(wr => wr.Age))
                                Console.WriteLine(w.ToString());
                            break;
                    }

                    Console.Write("\npress any button to continue...");
                    Console.ReadKey();
                    break;
                
                default:
                    return;
            }

        }


    }

    private static void FillWorker(ref Worker worker) {
        Console.Write("Full Name: "); 
        worker.FullName = Console.ReadLine();

        Console.Write("Age: ");
        worker.Age = int.Parse(Console.ReadLine());

        Console.Write("Height: ");
        worker.Height = int.Parse(Console.ReadLine());

        Console.Write("Palce Of Birth: ");
        worker.PalceOfBirth = Console.ReadLine();

        Console.Write("Date Of Birth: ");
        worker.DateOfBirth = DateTime.Parse(Console.ReadLine());
    }

}