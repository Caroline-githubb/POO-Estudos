using Ex_12.Entities.Exceptions;

namespace Ex_12.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be a check-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout > now)
            {
                throw new DomainException("Reservation dates for update  must be future dates.");
            }

            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be a check-in date");
            }
            CheckIn = checkin;
            CheckOut = checkout; 
        }
        public override string ToString()
        {
            return "Room: "
            + RoomNumber
            + ", Check-in: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", Check-out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " nights";
        }



    }
}