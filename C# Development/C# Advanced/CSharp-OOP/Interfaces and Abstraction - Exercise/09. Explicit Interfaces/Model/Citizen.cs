﻿namespace Problem9ExplicitInterfaces.Model
{
    using System;
    using Problem9ExplicitInterfaces.Contracts;

    class Citizen : IPerson, IResident
    {
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        public string Name { get; }

        public string Country { get; }

        public int Age { get; }

        string IPerson.GetName()
        {
            return this.Name;
        }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs ";
        }
    }
}