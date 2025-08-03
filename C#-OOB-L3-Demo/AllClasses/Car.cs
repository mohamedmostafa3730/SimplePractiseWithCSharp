using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L3_Demo.AllClasses
{
    internal class Car
    {
        #region attributes
        
        private int id;
        private string? model;
        private double speed;
        private string? color;
        #endregion

        #region constructors
        
        public Car(int id, string? model, double speedm, string? color)
        {
            this.id = id;
            this.model = model;
            this.speed = speedm;
            this.color = color;
        }
        
        public Car(int id, string? model, double speedm): this(id, model, speedm, "Not Inserted"){}
        
        
        public Car(int id, string? model): this(id, model, 0.0, "Not Inserted"){}
        
        
        public Car(int id): this(id, "Not Inserted", 0.0, "Not Inserted"){}
        
        public Car(): this(000, "Not Inserted", 0.0, "Not Inserted"){}

        

        #endregion

        #region porperties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string? Color
        {
            get { return color; }
            set { color = value; }
        }
        #endregion

        #region methods
        override public string ToString()
        {
            return $"Car ID: {Id}, Model: {Model}, Speed: {Speed} km/h, Color: {Color}";
        }


        #endregion
    }
}
