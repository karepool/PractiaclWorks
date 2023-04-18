namespace Lesson7;

struct WorkerRepository {

    public WorkerRepository(string path) {
        _file = new FileWorkerRepository(path);
    }

    private FileWorkerRepository _file;


    public Worker[] GetAllWorkers() => 
        _file.ReadFromFile();

    public Worker GetWorkerById(int id) {
        foreach(Worker worker in GetAllWorkers())
            if (worker.Id == id) 
                return worker;

        return new Worker();
    }

    public void DeleteWorker(int id) {
        _file.ClearFile();
        foreach(Worker worker in GetAllWorkers())
            if(worker.Id != id)
                _file.WriteToFile(worker);
    }

    public void AddWorker(Worker worker) {
        Worker[] workers = GetAllWorkers();
        int id = workers.Length;
      
        foreach(Worker workerFile in workers)
            if(workerFile.Id == id)
                id++;
              
        worker.Id = id;
        worker.AddedDateTime = DateTime.Now;
        _file.WriteToFile(worker);
    }


    public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo) {
        Worker[] workersFile = GetAllWorkers();
        Worker[] workersFilter = new Worker[workersFile.Length];
        int index = 0;

        foreach(Worker worker in workersFile)
            if((worker.AddedDateTime >= dateFrom) &&
                (worker.AddedDateTime <= dateTo)) 
                workersFilter[index++] = worker;
            
        if(workersFilter.Length < workersFile.Length)
            Array.Resize(ref workersFilter, index);

        return workersFilter;
    }
}