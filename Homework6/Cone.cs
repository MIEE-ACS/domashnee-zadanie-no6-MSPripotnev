using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Cone : Body
    {
        decimal h = 0;
        decimal r = 0;
        decimal l = 0;
        /// <summary>
        /// Высота конуса.
        /// </summary>
        public decimal H
        {
            get => h;
            set => _ = value < 0 ? throw new Exception() : 
                (h = value) - (L = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(H * H + R * R))));
        }
        /// <summary>
        /// Радиус основания конуса.
        /// </summary>
        public decimal R
        {
            get => r;
            set => _ = value < 0 ? throw new Exception() : 
                (r = value) - (L = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(H * H + R * R))));
        }
        /// <summary>
        /// Длина образующей.
        /// </summary>
        decimal L
        {
            get => l;
            set => _ = value < 0 ? throw new Exception() : l = value;
        }

        public Cone(decimal _h, decimal _r)
        {
            H = _h;
            R = _r;
        }
        public override decimal Area() => Convert.ToDecimal(Math.PI) * R * (R + L);
        public override decimal Volume() => Convert.ToDecimal(Math.PI) * R * R * H / 3;
        public override bool Equals(object obj) => (obj is Cone objc) &&
            objc.H == H && objc.R == R && objc.L == L;
        public override string ToString() => $"{GetType().Name.ToLower()}(R={R}, H={H})";
    }
}
