﻿using System;
using SimpleInjector;


namespace SInjector
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            var lifestyle = Lifestyle.Singleton;
            container.Options.ResolveUnregisteredConcreteTypes = true;

            container.Register<ICart, DataAccessLayer>(lifestyle); 

            var BL = container.GetInstance<BussinessLayer>();

            BL.InserttoCart();
            Console.ReadLine();            
        }
    }
}