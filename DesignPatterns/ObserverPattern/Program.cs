using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            WatcherSubject watcherSubject = new WatcherSubject();
            watcherSubject.Attach(new ReactorObserver("Abhay"));
            watcherSubject.Attach(new ReactorObserver("Ajay"));
            watcherSubject.Attach(new ReactorObserver("Alok"));
            watcherSubject.Attach(new ReactorObserver("Amruta"));

            watcherSubject.Status = "Start";
            watcherSubject.Status = "End";
            Console.ReadKey();
        }
    }
}
