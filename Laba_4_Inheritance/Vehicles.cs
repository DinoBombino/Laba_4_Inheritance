using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Для раздачи транспортных средств (количество колес)
-Велосипеды (тип (горный, городской, детский), радиус колес)
-Автомобили (тип (автобус, грузовик, внедорожник, легковая), объем двигателя, количество дверей),
-Самолеты (тип двигателя, максимальная высота полета)*/

namespace Laba_4_Inheritance
{
    /*
        var bikes = new List<Bike>();
        var cars = new List<Car>();
        var planes = new List<Plane>();
    */

    public class Vehicle
    {
        public static Random rnd = new Random();
        public  virtual String GetInfo()
        {
            return "Я балдю";
        }
    }

    /*Велосипеды*/
    public enum TypeOfBike {mountain, urban, children};
    public class Bike : Vehicle
    {
        public TypeOfBike type = TypeOfBike.mountain;
        public int radius = 0;

        //var bicycle1 = new Bicycle { type = "Горный", radius = 13 };
        //var bicycle2 = new Bicycle { type = "Городской", radius = 15 };
        //var bicycle3 = new Bicycle { type = "Детский", radius = 10 };
        public override String GetInfo()
        {
            var str = "Вам достаётся велосипед";
            str += String.Format("\nТип {0}", this.type);
            str += String.Format("\nРадиус {0}", this.radius, "″");
            return str;
        }

        public static Bike Generate()
        {
            //var rnd = new Random();
            return new Bike
            {
                radius = rnd.Next() % 25
            };
        }
    }

    /*Автомобили*/
    public enum TypeOfCar {bus, truck, offroad, passenger};
    public class Car : Vehicle
    { 
        public TypeOfCar type = TypeOfCar.bus;
        public int engine_capacity = 0;
        public int number_of_doors = 0;

        public override String GetInfo()
        {
            var str = "Вам достаётся автомобиль";
            str += String.Format("\nТип {0}", this.type);
            str += String.Format("\nОбъем двигателя {0}", this.engine_capacity, "л.с.");
            str += String.Format("\nКоличество дверей {0}", this.number_of_doors, "шт");
            return str;
        }

        public static Car Generate()
        {
            //var rnd = new Random();
            return new Car
            {
                engine_capacity = rnd.Next() % 301,
                number_of_doors = rnd.Next() % 6
            };
        }
    }

    /*Самолёты*/
    public enum TypeOfEnginePlane { piston_engine, jet_engine };
    public class Plane : Vehicle
    { 
        public TypeOfEnginePlane type = TypeOfEnginePlane.piston_engine;
        public int maximum_flight_altitude = 0;

        public override String GetInfo()
        {
            var str = "Вам достаётся самолёт";
            str += String.Format("\nТип {0}", this.type);
            str += String.Format("\nМаксимальная высота полета {0}", this.maximum_flight_altitude, "м");
            return str;
        }

        public static Plane Generate()
        {
            //var rnd = new Random();
            return new Plane
            {
                maximum_flight_altitude = rnd.Next() % 12001
            };
        }
    }
}