using System;
namespace oopconcepts {
    public class Dice:BoardGamePiece {
        public int NumberOfFaces { get; set; }

        // Builders
        public Dice(string color, int numberOfFaces) : base (color) {
            NumberOfFaces = numberOfFaces;
        }
        public Dice(string color): base(color) { 
            NumberOfFaces = 6;
        }
        public Dice(int numberOfFaces) {
            NumberOfFaces = numberOfFaces;
        }
        public Dice() {
            NumberOfFaces = 6;
        }

        // Functional methods
        public override void Buy() {
            Console.WriteLine("Buying a dice");
        }
        public void Roll() {
            Console.WriteLine("Rolling a dice");
        }
    }
}
