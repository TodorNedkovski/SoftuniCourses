﻿namespace Farm
{
    using _01._Single_Inheritance;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}