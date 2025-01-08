using System;

namespace oopconcepts {
    public class Dice {
        public string Color { get; set; }
        public int NumberOfFaces { get; set; }

        public void Buy() {
            Console.WriteLine("I'm buying a dice");
        }
        public void Roll() {
            Console.WriteLine("I'm rolling a dice");
        }
    }
}
