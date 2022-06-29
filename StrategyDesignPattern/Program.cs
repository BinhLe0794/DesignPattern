using StrategyDesignPattern;
/*
 
 */
Console.WriteLine("Start Running the Program");
var random = new Random();
for(var i = 0; i < 5; i++)
{
   var StrategyIndex = random.Next(0, 3);
   //innitalization information for ticket
   var ticket = new Ticket();
   ticket.Name  = "Ticket " + i;
   ticket.Price = 10;
   switch(StrategyIndex)
   {
      case 0:
         ticket.SetPromoteStrategy(new NoDiscountStrategy());
         break;
      case 1:
         ticket.SetPromoteStrategy(new HalfDiscountStrategy());
         break;
      case 2:
         ticket.SetPromoteStrategy(new QuarterDiscountStrategy());
         break;
   }
   Console.WriteLine(
      $"{ticket.Name} : {ticket.GetPromotedPrice()} : {ticket.GetPromoteStrategy().GetType().Name}");
}
Console.ReadLine();