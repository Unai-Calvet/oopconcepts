using System;
namespace oopconcepts {
    public class Dice {
        public string Color { get; set; }
        public int NumberOfFaces { get; set; }

        // Builders
        public Dice(string color, int numberOfFaces) {
            Color = color;
            NumberOfFaces = numberOfFaces;
        }
        public Dice(string color) { 
            Color = color;
            NumberOfFaces = 6;
        }
        public Dice(int numberOfFaces) {
            Color = "White";
            NumberOfFaces = numberOfFaces;
        }
        public Dice() {
            Color = "White";
            NumberOfFaces = 6;
        }

        // Functional methods
        public void Buy() {
            Console.WriteLine("Buying a dice");
        }
        public void Roll() {
            Console.WriteLine("Rolling a dice");
        }
    }
}
