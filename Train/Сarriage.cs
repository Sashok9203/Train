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
        private uint passenger;

        public uint Passenger 
        {
            get { return passenger; }
            set { passenger = value<=seats ? value : seats;}
        }
        public uint Seats { get { return seats; } }
        public CType Type { get { return type; } }
        public uint Number { get { return number; } }

        public uint FreeSeats { get { return seats - passenger; } }
        public Сarriage(uint number, CType type, uint seats, uint passenger = 0)
        {
            this.number = number;   
            this.type = type;   
            this.seats = seats; 
            this.passenger = passenger; 
        }
    }
}
