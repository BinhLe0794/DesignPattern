namespace SingletonDesignPattern;
public class KTeamDb
{
   private KTeamDb()
   {
   }
   private static object key = new object();
   
   private static volatile KTeamDb _instance;
   public static KTeamDb Instance
   {
      get
      {
         if( _instance == null )
         {
            // lock(key) // Tránh bị chiếm dụng ở thread khác
            // {
            //    _instance = new KTeamDb();
            // }
            _instance = new KTeamDb();
         }
         return _instance;
      }
   }
   //public method
   public void Demo()
   {
      Console.WriteLine("Demo Kteam Db");
   }
}