using Ex_06.Entities;
using Ex_06.Entities.Enums;

Order order = new Order{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

//conversao de um tipo enumerado para string 
string txt = OrderStatus.PendingPayment.ToString();

//conversao de um tipo string para um tipo enumerado
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(os);
Console.WriteLine(txt);