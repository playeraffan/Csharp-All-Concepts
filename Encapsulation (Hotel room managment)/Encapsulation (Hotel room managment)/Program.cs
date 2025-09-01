using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Encapsulation__Hotel_room_managment_
{

    class Hotel_managment 
    {
        int Room_no;
        float Room_Rent;
        string Booking_status;

        public void set_roomdetail(int roomno, float roomrent, string bookingstatus)
        { 
          Room_no = roomno;
            Room_Rent = roomrent;
            Booking_status = bookingstatus;
        }
        public int roomno() {
            return Room_no; 
        }

        public float roomrent() {
            return Room_Rent;
                }
        public string getbookingstatus() {
            return Booking_status;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel_managment hotel = new Hotel_managment();
            hotel.set_roomdetail(23, 34 , "Booked");
            hotel.set_roomdetail(26, 21, "Pending");
            Console.WriteLine($"room no is : {hotel.roomno()}" +
                $" Room Rent is : {hotel.roomrent()}" +
                $"  Booking Status is : {hotel.getbookingstatus()}");
            Console.ReadLine();
        }
    }
}
