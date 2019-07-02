using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
  public  class Aircraft
  {
    protected string name;    // Наименование 
    protected string model;    // модель
    protected int weight;      // вес самолета: кг
    protected int flightTime;   // максимальное время полета: тик времени
    protected int serviceTime; // время обслуживание в аэропарту:  тик времени
    protected int speed;      // рассотояние за один тик времени
    protected int type = 0;  // тип самолета: 0 военный, 1 прогулочный, 2 грузовой, 3 пассажирский
    protected Random rnd = new Random();  // генератор случайных чисел

    public Aircraft(string name, string model, int weight, int flightTime, int serviceTime, int speed, int type) // инициализация
    {   
      this.name = name;
      this.model = model;
      this.weight = weight;
      this.flightTime = flightTime;
      this.serviceTime = serviceTime;
      this.speed = speed;
      this.type = type;
    }
    public Aircraft(Aircraft air, string name) // перегруженный метод инициализации
    {
      this.name = name;
      this.model = air.model;
      this.weight = air.weight;
      this.flightTime = air.flightTime;
      this.serviceTime = air.serviceTime;
      this.speed = air.speed;
      this.type = air.type;
    }

    // свойства *****************************
    public int ServTime {get { return this.serviceTime;}} // время обслуживания
    public string Name {get{ return this.name;}}// наименование
    public string Model {get {return this.model;}} // модель
    public int FlightTime {get {return this.flightTime;}} // максимальное время полета
    public int Speed {get{return this.speed;}} // Скорость самолета
    public int Type { get { return this.type; } }  // тип самолета 
    public int Weight { get { return this.weight; } }  // вес самолета
    public virtual int Cargo { get { return 0; } set {  } }  // виртуальное свойство возврашает вес нагрузки;
    public virtual int Passenger { get { return 0; } set { } } //виртуальное свойство  количество пассажирова
    public virtual int MaxPassenger { get { return 0; } } // виртуальное свойство максимум пассажиров
    public virtual int MaxCargo { get { return 0; } } // виртуальное свойство максимум загрущка
    //  методы -------------------------------
    public virtual void Loading() {  } //виртуальный метод предстартовая загрузка
  } // конец class Aircraft

  public class WarAircraft : Aircraft  // подкласс военный самолет
  {
    public WarAircraft(string name, string model, int weight, int flightTime, int serviceTime,
      int speed) : base(name, model, weight, flightTime, serviceTime, speed, 0)
    {  }// инициализация
    public WarAircraft(Aircraft air, string name) : base(air, name){  } // перегрузка инициализации
    public override void Loading() { } 
  } // конец class WarAircraft

  public class WalkingAircraft : Aircraft  // подкласс прогулочный самолет
  {
    public WalkingAircraft(string name, string model, int weight, int flightTime, int serviceTime,
        int speed) : base(name, model, weight, flightTime, serviceTime, speed, 1) { }// инициализация
    public WalkingAircraft(Aircraft air, string name) : base(air, name) { }// перегрузка инициализации
    public override void Loading() { } 
  } // конец class WalkingAircraft

  public class CargoAircraft : Aircraft  // подкласс грузовой самолет
  {
    private int cargo = 0;  // количество груза
    private int maxCargo;   // максимум груза
    public CargoAircraft(CargoAircraft air, string name) : base(air, name) // перегрузка инициализации
    {
        this.maxCargo = air.maxCargo;
    }

    public CargoAircraft(string name, string model, int weight, int flightTime, int serviceTime,
    int speed, int maxCargo) : base(name, model, weight, flightTime, serviceTime, speed, 2) // инициализация
    {
        this.maxCargo = maxCargo;
    }
    public override int Cargo { get { return this.cargo; } set { this.cargo = value; } } //переопределение: возврашает вес нагрузки;
    public override int MaxCargo { get { return this.maxCargo; } } //переопределение: возврашает вес нагрузки;
    public override void Loading()          //переопределение: предстартовая загрузка
    {
        this.cargo = this.rnd.Next(this.maxCargo/5, this.maxCargo); ;
    }
  } // конец class CargoAircraft

  public class PassengerAircraft : Aircraft // подкласс прогулочный самолет
  {
    private int passenger = 0; // количество пассажиров
    private int maxPassenger;  // максимальное количество пассажиров

    public PassengerAircraft(string name, string model, int weight, int flightTime, int serviceTime,
        int speed, int maxPassenger) // инициализация
        : base(name, model, weight, flightTime, serviceTime, speed, 3) 
    {
        this.maxPassenger = maxPassenger;
    }
    public PassengerAircraft(PassengerAircraft air, string name )  // перегрузка инициализации
        : base(air, name)
    {
        this.maxPassenger = air.maxPassenger;
    }

    public override int Cargo { get { return this.passenger * 100; } }// переопределение: возврашает вес нагрузки;
    public override int Passenger { get { return this.passenger; } set { this.passenger = value; } }// переопределение: количество пассажиров
    public override int MaxPassenger { get { return this.maxPassenger; } } // переопределение: максимум пассажиров
    public override void Loading() // переопределение: предстартовая загрузка
    {
        this.passenger = rnd.Next(maxPassenger/5, maxPassenger);
    }
  } //  конец class PassengerAircraft
}