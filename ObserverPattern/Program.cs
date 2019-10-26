using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Subject subject = new Subject();

            //Observer1 takes a subscription to the subject
            Observer observerOne = new Observer("observer 1");
            subject.Subscribe(observerOne);
            Console.WriteLine("Add first item");
            subject.Inventory++;

            // Observer2 also subscribes to the store
            subject.Subscribe(new Observer("Observer 2"));

            Console.WriteLine("Add second item");
            subject.Inventory++;

            // Observer1 unsubscribes and Observer3 subscribes to notifications.
            subject.Unsubscribe(observerOne);

            subject.Subscribe(new Observer("Observer 3"));

            Console.WriteLine("Add third item");
            subject.Inventory++;


            Console.ReadLine();
        }
    }
}
