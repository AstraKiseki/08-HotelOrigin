using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrigin.Core.Domain;
using System.Collections.ObjectModel;


namespace HotelOrigin.Core.Repository
{
    class RoomsRepository
    {
        //Create
    //Read
    //Update
    //Delete

        private static ObservableCollection<Rooms> rooms = new ObservableCollection<Rooms>();

        public static Rooms Create()
        {
            Rooms room = new Rooms();

            rooms.Add(room);

            return room;
        }

        public static Rooms GetByRoomNumber(int roomNumber)
        {
            return rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
        }

        public static ObservableCollection<Rooms> GetAll()
        {
            return rooms;
        }

        public static void Update(Rooms room, int roomNumber, int numberOfBeds, bool hasTV, string typeOfBathroom, bool hasBeenCleanedToday)
        {
            room.RoomNumber = roomNumber;
            room.NumberOfBeds = numberOfBeds;
            room.HasTV = hasTV;
            room.TypeOfBathroom = typeOfBathroom;
            room.HasBeenCleanedToday = hasBeenCleanedToday;
        }
        
        public static void Delete(int RoomNumber)
        {
            var room = GetByRoomNumber(RoomNumber);
            rooms.Remove(room);
        }

    }
}
