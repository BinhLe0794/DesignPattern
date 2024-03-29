﻿namespace StrategyDesignPattern;
public class Ticket
{
   // Khai bao Set Get bang methods
   private IPromoteStrategy _promoteStrategy;

   // Khai bao mot constructor khi can truyen vao tham so
   public Ticket(IPromoteStrategy promoteStrategy)
   {
      _promoteStrategy = promoteStrategy;
   }
   // Khai bao mot constructor mac dinh
   public Ticket()
   {
   }
   public double Price { get; set; } = 0.0;
   public string Name { get; set; } = string.Empty;
   public IPromoteStrategy GetPromoteStrategy()
   {
      return _promoteStrategy;
   }
   public void SetPromoteStrategy(IPromoteStrategy value)
   {
      _promoteStrategy = value;
   }
   // Goi mot method duoc implementation tu interface
   public double GetPromotedPrice()
   {
      return _promoteStrategy.DoDiscount(Price);
   }
}