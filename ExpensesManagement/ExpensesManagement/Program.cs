using ExpensesManagement.ResponsabilityOfChain;
using ExpensesManagementWatcher;
using System;
using System.IO;

namespace ExpensesManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Creazione FileSystem Wathcer
            FileSystemWatcher fsw = new FileSystemWatcher();

            Console.WriteLine("Watcher activated");
            //path della cartella da controllare
            fsw.Path = @"C:\Users\tiziana.camboni\Desktop\Academy\Academy2\Settimana1\Week1Test"; //

            //controllo il file spese.txt
            fsw.Filter = "spese.txt";

            //imposto notifiche
            fsw.NotifyFilter = NotifyFilters.LastWrite
                | NotifyFilters.LastAccess
                | NotifyFilters.FileName
                | NotifyFilters.DirectoryName;

            //abilitazione notifiche 
            fsw.EnableRaisingEvents = true;

            // Gestione della creazione-> richiama metodo nella classe eventmanagement
            fsw.Created += EventManagementWatcher.NewFileAllert;
            var expensesList = EventManagementWatcher.NewListExp();

            // chain of resp
            var ceo = new CEOHandler();
            var OpManager = new OperationManagerHandler();
            var Manager = new ManagerHandler();

            Manager.SetNext(OpManager).SetNext(ceo); //concatenazione
            foreach (var item in expensesList)
            {
               var result = Manager.Handle(item.import);
                if (!(result == 0 || result == 1 || result == 2))
                    {
                    Console.WriteLine("non è stata gestita");
                    }
               //string livello = null;
               switch (result)
                {
                    case 0:
                       item.livello = "Manager";
                        break;
                    case 1:
                        item.livello = "Operator Manager";
                        break;
                    case 2:
                        item.livello = "CEO";
                        break;
               }

                
            }
            
            

            //mi tiene il programma aperto durante il controllo 
            Console.WriteLine("Press q to exit");
            while (Console.Read() != 'q') ;

        }
    }
}
