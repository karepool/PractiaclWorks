namespace Lesson7;

public struct FileWorkerRepository {

    public FileWorkerRepository(string filePath) {
        _filePath = filePath;
        if(!File.Exists(_filePath))
            File.Create(filePath).Close();
    }

    private string _filePath;

    public void ClearFile() {
        using(var sw = new StreamWriter(_filePath, false)) {
            sw.Write(String.Empty);
        }
    }

    public void WriteToFile(Worker worker) {
        using(var sw = new StreamWriter(_filePath, true)) {
            sw.WriteLine(
                worker.Id + "#" +
                worker.FullName + "#" +
                worker.Age + "#" +
                worker.Height + "#" +
                worker.PalceOfBirth + "#" +
                worker.DateOfBirth + "#" +
                worker.AddedDateTime
                );
        }
    }

    public Worker[] ReadFromFile() {
        var workers = new Worker[5];
        int index = 0;

        using(var sr = new StreamReader(_filePath)) {
            if(String.IsNullOrEmpty(sr.ReadToEnd()))
                return new Worker[0];
        }

        using(var sr = new StreamReader(_filePath)) {
            while(!sr.EndOfStream) {
                string[] args = sr.ReadLine().Split('#');

                if(index >= workers.Length)
                    Array.Resize(ref workers, workers.Length * 2);

                workers[index] = new Worker(
                    int.Parse(args[0]),
                    args[1],
                    int.Parse(args[2]),
                    int.Parse(args[3]),
                    args[4],
                    DateTime.Parse(args[5]),
                    DateTime.Parse(args[6])
                    );

                index++;
            }

            if(index < workers.Length)
                Array.Resize(ref workers, index);

        }

        return workers;
    }

}