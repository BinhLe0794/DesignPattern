// See https://aka.ms/new-console-template for more information
using ProxyDesignPattern;

Console.WriteLine("Hello, World!");

CoreProxy coreProxy = new CoreProxy(true);

Console.WriteLine(coreProxy.GetName());

coreProxy.SetName("Admin Core 1 ");

Console.WriteLine(coreProxy.GetName());
