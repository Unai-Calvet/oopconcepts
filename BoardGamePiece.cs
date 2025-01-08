using System;

namespace oopconcepts {
    public class BoardGamePiece {
        public string Color { get; set; }

        public BoardGamePiece(string color) { 
            Color = color;
        }
        public BoardGamePiece() {
            Color = "White";
        }

        public virtual void Buy() {
            Console.WriteLine("Buying");
        }
    }
}
