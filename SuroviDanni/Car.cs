using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuroviDanni
{
    internal class Car
    {
		private string model;
        private Engine engine;
        private Cargo cargo;
        public string Model
		{
			get { return model; }
			set { model = value; }
		}
		public Engine Engine
        {
			get { return engine; }
			set { engine = value; }
		}
		public Cargo Cargo
		{
			get { return cargo; }
			set { cargo = value; }
		}
		private List<Tire> tires;

		public List<Tire> Tires
		{
			get { return tires; }
			set { tires = value; }
		}
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
               double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age,
               double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            Model = model;
            Engine = new Engine { Speed = engineSpeed, Power = enginePower };
            Cargo = new Cargo { Weight = cargoWeight, Type = cargoType };

            Tires = new List<Tire>();
            Tires.Add(new Tire { Pressure = tire1Pressure, Age = tire1Age });
            Tires.Add(new Tire { Pressure = tire2Pressure, Age = tire2Age });
            Tires.Add(new Tire { Pressure = tire3Pressure, Age = tire3Age });
            Tires.Add(new Tire { Pressure = tire4Pressure, Age = tire4Age });
        }
    }
}
