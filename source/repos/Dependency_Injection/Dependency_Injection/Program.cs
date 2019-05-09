using System;

namespace Dependency_Injection
{
    public interface ICar
    {
        void Serve();
    }

    public class Service1 : ICar
    {
        public void Serve()
        {
            Console.WriteLine("Car first time service");
        }
    }

    public class Service2 : ICar
    {
        public void Serve()
        {
            Console.WriteLine("Car second time service");
        }
    }

    public class Car
    {
        private ICar _car;
        public Car(ICar car)
        {
            this._car = car;
        }
        public void ServeMethod()
        {
            this._car.Serve();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICar service1 = new Service1();
            Car car = new Car(service1);
            car.ServeMethod();
            Service2 service2 = new Service2();
            car = new Car(service2);
            car.ServeMethod();
            //Console.WriteLine(car);
            Console.ReadLine();
        }
    }
}
