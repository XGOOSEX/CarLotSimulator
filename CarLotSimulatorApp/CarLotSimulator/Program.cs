using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            var lot = new CarLot();
            
            //Now that the Car class is created we can instanciate 3 new cars

            //Instantiation 1 - dot notation 
            var iansCar  = new Car();
            iansCar.Make = "Ford";
            iansCar.Model = "Focus";
            iansCar.Year = 2013;
            iansCar.EngineNoise = "Vroom";
            iansCar.HonkNoise = "Beep";
            iansCar.IsDrivable = true;

            lot.Cars.Add(iansCar);


            //Instantiation 2 - object initializer syntax 
            var hillsCar = new Car()
            {
                Year = 2019,
                Make = "Ford",
                Model = "Fiesta", 
                EngineNoise = "...", 
                HonkNoise = "Bloop", 
                IsDrivable = false,
            };

            lot.Cars.Add(hillsCar); 


            //Instantiation 3 - using constructor to allow parameter values to be placed inside properties. reference car class 
            var ronniesCar = new Car(2014, "Chevy", "volt", "Zip", "Brap", true); 

            lot.Cars.Add(ronniesCar);



            //Set the properties for each of the cars
            //Call each of the methods for each car

            iansCar.MakeEngineNoise(iansCar.EngineNoise);
            hillsCar.MakeEngineNoise(hillsCar.EngineNoise);
            ronniesCar.MakeEngineNoise(ronniesCar.EngineNoise);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year:{car.Year} Make {car.Make} Model {car.Model});
            }
        }
    }
}
