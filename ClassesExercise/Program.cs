using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //default constructor examples
            Car myCar = new Car();
                            //^contructor-helps create new instance of class
            myCar.Make = "Ford";
            myCar.Model = "Ranger";
            myCar.Year = 2002;

            //or

            Car mazda = new Car() { Make = "mazda", Model = "rx8", Year = 2012 };

            //or with non-default constructor:

            Car chevy = new Car("Chevy", "z-71", 2021);


        }
    }
}
