using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Cube : Body
    {
        private decimal r;
        /// <summary>
        /// Сторона куба.
        /// </summary>
        public decimal R
        {
            get => r;
            set => _ = value < 0 ? throw new Exception("Длина стороны куба не может быть отрицательной") : r = value;
        }
        public Cube(decimal side) => R = side;
        public override decimal Area() => 6 * R * R;
        public override decimal Volume() => R * R * R;
        public override bool Equals(object obj) => (obj is Cube objc) && objc.R == R;
        public override string ToString() => $"{GetType().Name.ToLower()}(R={R})";
    }
}
