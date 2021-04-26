using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2
{
    partial class Motorcycle
    {
        private double engineVolume;
        public double EngineVolume { 
            get { return engineVolume; }
            set { engineVolume = value; }
        }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private string modelName;
        private string color;
        private int yearOfCreation;

        private static int numberOfWheels;
        public static string CountryOfCreation { get; set; }
        public Motorcycle()
        {
            yearOfCreation = 0;
            color = "None";
            modelName = "None";
            speed = 0;
            engineVolume = 0.0;
        }
        public Motorcycle(int speed,string color )
        {
            yearOfCreation = 2000;
            this.color = color;
            modelName = "Gorvermental";
            this.speed = speed;
            engineVolume = 5.0;
        }
        public Motorcycle(int speed, string color,string modelName)
        {
            yearOfCreation = 2000;
            this.color = color;
            this.modelName = modelName;
            this.speed = speed;
            engineVolume = 5.0;
        }
        public Motorcycle(int speed, string color, string modelName,int yearOfCreation,double engineVolume)
        {
            this.yearOfCreation = yearOfCreation;
            this.color = color;
            this.modelName = modelName;
            this.speed = speed;
            this.engineVolume = engineVolume;
        }

        static Motorcycle()
        {
            numberOfWheels = 2;
            CountryOfCreation = "Azerbaijan";
        }



        #region Getters And Setters

        public string GetModelName()
        {
            return modelName;
        }

        public void SetModelName(string modelName)
        {
             this.modelName=modelName;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public int GetYearOfCreation()
        {
            return yearOfCreation;
        }
        public void SetYearOfCreation(int yearOfCreation)
        {
            this.yearOfCreation = yearOfCreation;
        }


        #endregion

        #region Referance Method
        public void CopySpeedTo(ref Motorcycle elem)
        {
            elem.speed = this.speed;
        }
        #endregion
    }
}
