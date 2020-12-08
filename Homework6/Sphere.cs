using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Sphere : Body
    {
        decimal r;
        /// <summary>
        /// Радиус сферы
        /// </summary>
        public decimal R
        {
            get => r;
            set => _ = value < 0 ? throw new Exception("R не может быть отрицательным!") : r = value;
        }

        public Sphere(decimal r) => R = r;

        public override decimal Area() => 4 * Convert.ToDecimal(Math.PI) * R * R;
        public override decimal Volume() => Area() * R / 3;
        public override bool Equals(object obj) => (obj is Sphere objc) && objc.R == R;
        public override string ToString() => $"{GetType().Name.ToLower()}(R={R})";
    }
}
