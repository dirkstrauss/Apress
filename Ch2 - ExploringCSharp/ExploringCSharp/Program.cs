using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ExploringCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract classes and interfaces
            //DerivedClass d = new DerivedClass();
            //WriteLine($"PropA before calculation {d.PropA}");
            //WriteLine($"PropB before calculation {d.PropB}");
            //WriteLine($"Perform calculation {d.PerformCalculationAB()}");
            //WriteLine($"PropA after calculation {d.PropA}");
            //WriteLine($"PropB after calculation {d.PropB}");


            //Car car1 = new Car("VIN12345", 2, 4);
            //Car car2 = new Car("VIN12345", 2, 4);
            //WriteLine(car1.VinNumberEqual(car2) ? "ERROR: Vin numbers equal" : "Vin numbers unique"); 
            #endregion

            #region Extension methods
            //string strInt = "123";
            //if (strInt.IsValidInt())
            //{
            //    WriteLine("Valid Integer");
            //}
            //else
            //{
            //    WriteLine("Not an Integer");
            //}

            //string strInt = "123";
            //if (strInt.IsValidInt(out int validIntValue))
            //{
            //    WriteLine($"Valid Integer is {validIntValue}");
            //}
            //else
            //{
            //    WriteLine("Not an Integer");
            //} 



            //WorkerClass worker = new WorkerClass();
            //worker.DoSomething(5);
            #endregion

            #region Generics
            ////Without Generics
            //Car car1 = new Car("123", 2, 4);
            //Car car2 = new Car("456", 3, 4);
            //Car car3 = new Car("789", 2, 4);

            //List<Car> carList = new List<Car>(new Car[] { car1, car2, car3 });

            //VehicleCarrier carrier = new VehicleCarrier(3);
            //foreach (var vehicle in carList)
            //{
            //    carrier.AddVehicle(vehicle);
            //}

            //carrier.GetAllVehicles();

            //// With Generics
            //SUV suv1 = new SUV("123", 2, 4, false);
            //SUV suv2 = new SUV("456", 3, 4, false);
            //SUV suv3 = new SUV("789", 2, 4, false);


            //List<SUV> carList = new List<SUV>(new SUV[] { suv1, suv2, suv3 });

            //VehicleCarrier<SUV> carrier = new VehicleCarrier<SUV>(3);
            //foreach (var vehicle in carList)
            //{
            //    carrier.AddVehicle(vehicle);
            //}

            //carrier.GetAllVehicles();

            // With Generics
            SUV suv1 = new SUV("123", 2, 4, false);
            Car car1 = new Car("456", 3, 4);
            SUV suv3 = new SUV("789", 2, 4, false);

            List<object> carList = new List<object>(new object[] { suv1, car1, suv3 });

            VehicleCarrier<object> carrier = new VehicleCarrier<object>(3);
            foreach (var vehicle in carList)
            {
                carrier.AddVehicle(vehicle);
            }

            carrier.GetAllVehicles(); 
            #endregion


            ReadLine();
        }




    }
}

