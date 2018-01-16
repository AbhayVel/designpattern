using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
  public   class ReactorObserver : Observer
    {
        public String  Name { get; set; }
        public String Status { get; set; }

        public ReactorObserver(String name)
        {
            Name = name;
        }


        public override void Update<T>(T status)
        {
            Console.WriteLine(@"value has been changed " + Name + " and " + status +"." );
        }
    }
}
