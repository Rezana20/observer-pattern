using System.Collections.Generic;
using System.Net.Http.Headers;

namespace ObserverPattern
{
    public class Subject :  ISubject
    {
        List<Observer> Observers  = new List<Observer>();
        private int _int;
        public int Inventory
        {
            get { return _int; }
            set
            {
                if (value > _int)
                {
                    Notify();
                }

                _int = value;
            }
        }

        public void Subscribe(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Unsubscribe(Observer observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        { Observers.ForEach(observer => observer.Update());
        }
    }
}