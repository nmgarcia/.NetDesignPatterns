/*In this example, we have two classes: RealSubject and Proxy.Both implement the ISubject interface which declares a common operation called Request().
The RealSubject class contains the actual implementation of the Request() operation. Meanwhile, the Proxy class acts as a stand -in for the RealSubject,
providing additional functionality such as access control or logging.

The Proxy class creates an instance of the RealSubject class only when the Request() operation is actually called.
This is an example of the lazy-loading technique.

The Client class works with both RealSubject and Proxy objects through the ISubject interface. The client does not need to know which object 
it is working with because they both implement the same interface.*/

using System;

namespace Proxy
{

    // The Subject interface declares common operations for both RealSubject and the Proxy.
    public interface ISubject
    {
        void Request();
    }

    // The RealSubject contains some core business logic. Usually, RealSubjects are capable of doing some useful work which may also be very slow or sensitive - e.g. correcting input data. A Proxy can solve these issues without any changes to the RealSubject's code.
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }

    // The Proxy has an interface identical to the RealSubject.
    class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        // The most common use of the Proxy pattern is lazy loading. This means delaying the creation of an object until it is actually needed.
        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject = new RealSubject();
                this._realSubject.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }

    // The client code is supposed to work with all objects (both subjects and proxies) via the Subject interface in order to support both real subjects and proxies. In real life, however, clients mostly work with their real subjects directly. In this case, to implement the pattern more easily, you can extend your proxy from the real subject's class.
    class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}
