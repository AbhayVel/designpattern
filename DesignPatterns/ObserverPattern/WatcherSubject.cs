using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WatcherSubject : Subject
    {

        private string _Status;

        // Gets or sets subject state

        public string Status
        {
            get { return _Status; }
            set {
                _Status = value;
                base.Notify<string>(_Status);
            }
        }

    }
}
