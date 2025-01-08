using System;
namespace oopconcepts {
    public class Program { 
        public static void Main() { 
            Dice firstDice = new Dice("Orange", 20);
            Console.WriteLine("Color: {0}, Faces: {1}", firstDice.Color, firstDice.NumberOfFaces);
        }
    }
}