using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using HotelOrigin.Core.Domain;

namespace HotelOrigin.Core.Repository
{
    class ReservationsRepository
    {
        private static ObservableCollection<Reservations> reservations = new ObservableCollection<Reservations>();

        public static Reservations Create()
        {
            Reservations reserve = new Reservations();
            reservations.Add(reserve);
            return reserve;
        }

        public static Reservations Where(string Customer)
        {
            Customer.Equals(Customer);
            return reservations.Customer;
        }

        public static Reservations Where(int Room)
        {
            return reservations.FirstOrDefault(r => r.Room == Room);
        }

        public static Reservations Where(DateTime CheckInDate)
        {
           
        }

        public static ObservableCollection<Reservations> GetAll()
        {
            return reservations;
        }

        public static void Update(Reservations reservations, string customer, int room, DateTime checkInDate, DateTime checkOutDate)
        {
            reservations.Customer = customer;
            reservations.Room = room;
            reservations.CheckInDate = checkInDate;
            reservations.CheckOutDate = checkOutDate;
        }

        // The problem now is with Deleting reservations if someone has multiple reservations, either I'll accidentally delete all of them or do one by mistake!
        public static void Delete(string Customer)
        {
            var customer = GetByCustomer(Customer);

            reservations.Remove(Customer);
        }

    
}
}
