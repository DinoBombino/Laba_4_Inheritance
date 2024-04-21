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

        public override String GetInfo()
        {
            var str = "Вам достаётся велосипед!";
            str += String.Format("\nТип: {0}", GetTypeString(this.type));
            str += String.Format("\nРадиус: {0}", this.radius);
            str += String.Format("″");
            return str;
        }

        private string GetTypeString(TypeOfBike type)
        {
            switch (type)
            {
                case TypeOfBike.mountain:
                    return "Горный";
                case TypeOfBike.urban:
                    return "Городской";
                case TypeOfBike.children:
                    return "Детский";
                default:
                    return "неизвестный тип";
            }
        }

        public static Bike Generate()
        {
            //var rnd = new Random();
            return new Bike
            {
                type = (TypeOfBike)rnd.Next(3),
                radius = 5 + rnd.Next() % 25
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
            var str = "Вам достаётся автомобиль!";
            str += String.Format("\nТип: {0}", GetTypeString(this.type));
            str += String.Format("\nОбъем двигателя: {0}", this.engine_capacity);
            str += String.Format("л.с.");
            str += String.Format("\nКоличество дверей: {0}", this.number_of_doors);
            str += String.Format("шт");
            return str;
        }

        private string GetTypeString(TypeOfCar type)
        {
            switch (type)
            {
                case TypeOfCar.bus:
                    return "Автобус";
                case TypeOfCar.truck:
                    return "Грузовик";
                case TypeOfCar.offroad:
                    return "Внедорожник";
                case TypeOfCar.passenger:
                    return "Легковой автомобиль";
                default:
                    return "неизвестный тип";
            }
        }

        public static Car Generate()
        {
            //var rnd = new Random();
            return new Car
            {
                type = (TypeOfCar)rnd.Next(4),
                engine_capacity =64 + rnd.Next() % 301,
                number_of_doors =2 + rnd.Next() % 6
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
            var str = "Вам достаётся самолёт!";
            str += String.Format("\nТип: {0}", GetTypeString(this.type));
            str += String.Format("\nМаксимальная высота полета: {0}", this.maximum_flight_altitude);
            str += String.Format("м");
            return str;
        }

        private string GetTypeString(TypeOfEnginePlane type)
        {
            switch (type)
            {
                case TypeOfEnginePlane.piston_engine:
                    return "Поршневой двигатель (пропеллерный)";
                case TypeOfEnginePlane.jet_engine:
                    return "Реактивный двигатель";
                default:
                    return "неизвестный тип";
            }
        }

        public static Plane Generate()
        {
            //var rnd = new Random();
            return new Plane
            {
                type = (TypeOfEnginePlane)rnd.Next(2),
                maximum_flight_altitude =100 + rnd.Next() % 12001
            };
        }
    }
}