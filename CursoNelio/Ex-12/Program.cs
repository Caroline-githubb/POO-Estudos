using Ex_12.Entities;
using Ex_12.Entities.Exceptions;

try
{
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine() + "");

    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkin = DateTime.Parse(Console.ReadLine() + "");
    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkout = DateTime.Parse(Console.ReadLine() + "");


    Reservation reservation = new Reservation(number, checkin, checkout);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data  to update the reservation: ");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkin = DateTime.Parse(Console.ReadLine() + "");
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkout = DateTime.Parse(Console.ReadLine() + "");

    reservation.UpdateDates(checkin, checkout);

    Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException ex)
{
    Console.WriteLine("Error in reservation: " + ex.Message);
}

catch (FormatException e)
{
    Console.WriteLine("Format error: "+ e.Message);
}

catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}



