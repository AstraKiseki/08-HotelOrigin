using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HotelOrigin.Core.Domain
{
    class Rooms
    {
        public int RoomNumber { get; set; }
        public int NumberOfBeds { get; set; }
        public bool HasTV;
        public string TypeOfBathroom { get; set;  }
        public bool HasBeenCleanedToday;
    }
}
