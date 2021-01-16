using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LinqSample
{
    class Program
    {

        static void Sample()
        {

            var i = 1;
            var numbers = new[] { 1, 4, 5, 2, 3, 5, 6, 15, 67, 23 };

            var list = new List<Car>()
            {
                new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),
                new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),  new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),
            };

            //sample w/o linq
            var newCarCollection = new List<Car>();
            foreach (var car in list)
            {
                if (car.YearOfProduction > 2010)
                {
                    newCarCollection.Add(car);
                }
            }

            //linq sample
            var carsCollection = from car in list
                                 where car.YearOfProduction > 2010
                                 select car;

            //linq using lambda sample
            var cars = list.Where(car => car.YearOfProduction > 2010).ToList();

            var cars2 = list
                .Where(car
                    => car.YearOfProduction > 2000
                       && car.Model.StartsWith("S"))
                .OrderBy(car => car.Manufacturer)
                .Select(car => new[] { car })
                .ToList();

            //list<car[]> -> list<car>
            var carsList = cars2.SelectMany(cars1 => cars1).ToList();


            var carsOrderedByDescending = carsList.OrderByDescending(car => car.YearOfProduction);

            var carsOrderedByYearAndManufacturer =
                cars.OrderBy(car => car.YearOfProduction)
                    .ThenBy(car => car.Manufacturer)
                    .ToList();

            //all & any -> return bool
            var isAllCarsMaufacturedByBmwOrFord =
                cars.All(car => car.Manufacturer.Equals("BMW") || car.Manufacturer.Equals("Ford"));

            var isJustOneCarManufactureByBmwOrFord =
                cars.Any(car => car.Manufacturer.Equals("BMW") || car.Manufacturer.Equals("Ford"));



            ////6 very important methods
            //var firstCar = cars.First(car => car.YearOfProduction < 1000);//exception
            //var firstCarWithNullPossible = cars.FirstOrDefault(car => car.YearOfProduction < 1000);//null
            //var last = cars.Last();
            //var lastCarWithNullPossible = cars.LastOrDefault();
            //var signleCar = cars.Single();
            //var signleCarWithNullPossible = cars.SingleOrDefault();

            //var element = cars.Find(car => car.YearOfProduction == 2000);

            ////find element by index
            //var elementByIndex = cars.ElementAt(2);
            //var elementByIndexOrNull = cars.ElementAtOrDefault(2);


            //count & distinct
            var numbers2 = new[] { 1, 4, 5, 2, 3, 5, 6, 15, 67, 23, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            Console.WriteLine(numbers2.Length);
            var enumerable = numbers2.Distinct();
            Console.WriteLine(enumerable.Count());

            //select
            var x = cars.Select(car => new
            {
                ID = Guid.NewGuid(),
                car = car
            });

            //aggregate

            var maxCarYear = cars.Max(car => car.YearOfProduction);
            var minCarYear = cars.Min(car => car.YearOfProduction);
            var avgCarYear = cars.Average(car => car.YearOfProduction);
            var sumCarYears = cars.Sum(car => car.YearOfProduction);

            //group operations 
            var groupedCars = cars.GroupBy(car => car.Manufacturer).ToList();
            //IGrouping<string, Car>

            var y = cars.ToList();

            y.Add(new Car(":", "1", 1));

            var z = y.ToDictionary(car => car.Manufacturer, car => car);//exception

        }

        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car("S-klasse", "Mercedes", 2000),
                new Car("7er", "BMW", 2011),
                new Car("Tiguan", "VW", 2012),
                new Car("Escort", "Ford", 1995),
                new Car("Navigator", "Lincoln", 2003),
                new Car("Supra", "Toyota", 2003),
                new Car("E-klasse", "Mercedes", 2000),
                new Car("5er", "BMW", 2011),
                new Car("Touareg", "VW", 2012),
                new Car("Explorer", "Ford", 1995),
                new Car("Continental", "Lincoln", 2003),
                new Car("Land cruiser", "Toyota", 2003),
                new Car("C-klasse", "Mercedes", 2000),
                new Car("3er", "BMW", 2011),
                new Car("Passat", "VW", 2012)
            };

            //var dict = cars
            //    .GroupBy(car => car.Manufacturer)
            //    .ToDictionary(car => car.Key, car => car.ToList());

            //foreach (var value in dict)
            //{
            //    var x = value;
            //    var z = x.Key;
            //}

            var newCars = cars
                .Where(car => car.Manufacturer.StartsWith("B"))
                .OrderBy(car => car.Manufacturer)
                .Select(car => Do2(car.YearOfProduction))
                .Distinct()
                .Select(x => new Car(x,x,200));

            var z = 1;

            var list = new List<Car>(newCars);

            var zx = 2;

            //immediately execution will be here if ^ ends with 
            // .Count()
            //.First()\Fod -> 6 important methods
            //Min\max\sum\avegare
            //.ToX

            //code 

            //newCars = newCars.Where(i => i > 0);


            //???
            foreach (var newCar in newCars)
            {
                
            }
        }

        static string Do2(int a)
        {
            return a.ToString();
        }
    }
}
