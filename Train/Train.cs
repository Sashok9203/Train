using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    enum TrainType
    {
        Passenger,
        Freight,
    }
    internal class Train
    {
        private Сarriage[] carriages;
        private readonly uint number;
        private readonly TrainType type;
        private DateTime arrival;


        public DateTime Arrival
        {
            get { return arrival; }
            set { arrival = arrival < Dispatch ? Dispatch : value; }
        }
        public DateTime Dispatch { get; set; }
        public string Route { get; set; }
        public uint Number { get { return number; } }
        public TrainType Type { get { return type; } }
        public float PassAvr 
        {
            get 
            {
                uint average = 0;
                foreach (var car in carriages)
                    average += car.Passenger;
                return (float)Math.Round((float)average/carriages.Length,2);
            }
        }

        public Train(uint trainNumber,TrainType type,string route,DateTime dispatch,DateTime arrival,params Сarriage[] carriages)
        {
            this.Route = route;
            this.number = trainNumber;
            this.type = type;
            this.Dispatch = dispatch;
            this.arrival = arrival;
            for (int i = 0; i < carriages.Length - 1; i++)
                if (carriages[i].Number == carriages[i + 1].Number) throw new Exception($" Dublicate carriage number {carriages[i].Number}");
            this.carriages = carriages;
        }

    }
}
