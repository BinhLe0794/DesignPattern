﻿
using SingletonDesignPattern;

Console.WriteLine("Hello, World!");

DbContextSingleton.GetInstance().GetDatafromDBContext();

DbContextSingleton2.GetInstance().GetDatafromDBContext();