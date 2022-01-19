using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtClass
{
    public interface ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start();
        public string Stop();

    }
    public interface IElectricCar
    {
        public int Battery { get; set; }
    }
    public class Seat:ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start() => "Engine start";
        public string Stop()=>"Breaaak!";
        public override string ToString()
        {
            return Color+" Seat "+Model+"\n"+Start()+"\n"+Stop();

        }
        public Seat()
        {

        }
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }
    }
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }
        public string Start() => "Engine start";
        public string Stop() => "Breaaak!";
        public override string ToString()
        {
            return Color + " Telsa " + Model +"with "+Battery+" Batteries"+ "\n" + Start() + "\n" + Stop();

        }
        public Tesla()
        {

        }
        public Tesla(string model, string color,int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
    }
}
