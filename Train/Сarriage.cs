using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    enum CType
    {
        Reserved,
        Freight,
        Сompartment
    }
    struct Сarriage
    {
        private readonly uint number;
        private readonly CType type;
        private readonly uint seats;
        private uint passengers;
        
        public uint Seats { get { return seats; } }
        public CType Type { get { return type; } }
        public uint Number { get { return number; } }
        public uint FreeSeats { get { return seats - passengers; } }

        public uint Passenger
        {
            get { return passengers; }
            set
            {
                if (value > seats) throw new Exception($" Invalid passengers count of carriage number \"{number}\"");
                else passengers = value;
            }
        }

        public Сarriage(uint number, CType type, uint seats, uint passengers = 0)
        {
            this.number = number;   
            this.type = type;   
            this.seats = seats; 
            this.Passenger = passengers; 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Сarriage \"{number}\"\n");
            sb.AppendLine($" Type       : {type}");
            sb.AppendLine($" Seats      : {seats}");
            sb.AppendLine($" Passengers : {passengers}");
            sb.AppendLine($" Free seats : {FreeSeats}\n");
            return sb.ToString();
        }

    }
}
