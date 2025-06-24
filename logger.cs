namespace PassgenConsole;

public class Logger
{
        public int LogHowMany {get; set;}
        public int LogDivisor { get; set; }
        public string LogletterCount { get; set; }
        public int LogNumCount { get; set; }
        public int LogSpecialsCount { get; set; }
        public int LogfileGrab1 { get; set; }
        public int LogfileGrab2  { get; set; }
        public string? Logfinal { get; set; }
        


        
        public void SaveToFile()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"/home/lynxx/RiderProjects/PassgenConsole/Notes.txt");
            path = Path.GetFullPath(path); // normalize
         
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine("Input-\nhowMany: " + LogHowMany +"\nNums: " +  LogNumCount + "\nSpecials: " +  LogSpecialsCount);

                file.WriteLine($"Divisor: {LogDivisor}");
                file.WriteLine("letterCount : " + LogletterCount);
                file.WriteLine("fileGrab1 : " + LogfileGrab1);
                file.WriteLine("fileGrab2: " + LogfileGrab2);
                file.WriteLine("final: " + Logfinal);
                file.WriteLine("---");

            }
        }
    }

