namespace SingletonDesignPattern;
public class DbContextSingleton2
{
   private static DbContextSingleton2 _uniqueInstance;
   private DbContextSingleton2()
   {
   }
   public static DbContextSingleton2 GetInstance()
   {
      if( _uniqueInstance == null ) _uniqueInstance = new DbContextSingleton2();
      return _uniqueInstance;
   }
   // cac function duoc public ra ngoai
   public void GetDatafromDBContext()
   {
      Console.WriteLine("Get 10 records");
   }
}