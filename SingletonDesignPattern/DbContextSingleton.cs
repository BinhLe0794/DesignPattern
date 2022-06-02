using System;
namespace SingletonDesignPattern
{
    public class DbContextSingleton
    {
        //cach 1
        private static readonly DbContextSingleton _uniqueInstance = new();
        public static DbContextSingleton GetInstance()
        {
            return _uniqueInstance;
        }
        private DbContextSingleton()
        {

        }
        // cac function duoc public ra ngoai
        public void GetDatafromDBContext()
        {
            Console.WriteLine("Get 10 records");
        }
    }
}

