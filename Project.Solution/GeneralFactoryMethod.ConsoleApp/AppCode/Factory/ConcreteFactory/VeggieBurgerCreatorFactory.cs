﻿using GeneralFactoryMethod.ConsoleApp.AppCode.Factory.AbstractFactory;
using GeneralFactoryMethod.ConsoleApp.AppCode.Factory.AbstractProduct;
using GeneralFactoryMethod.ConsoleApp.AppCode.Factory.ConcreteProduct;

namespace GeneralFactoryMethod.ConsoleApp.AppCode.Factory.ConcreteFactory
{
    // 4. Concrete Product.
    public class VeggieBurgerCreatorFactory : IBurgerCreatorFactory
    {
        public IBurger CreateBurger() => new VeggieBurger();
    }
}
