using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUrielVergara.Entidades
{
    public class Milla
    {
        private float _distancia;

        public Milla(float distancia)
        {
            _distancia = distancia;
        }
        public Milla() : this(100)
        { }
        public float GetDistancia() => _distancia;

        public static implicit operator Milla(float v)
        {
            return new Milla(v);
        }

        public static explicit operator Milla(Yarda v)
        {
            return new Milla(v.GetDistancia());
        }

        public static explicit operator Milla(Kilometro v)
        {
            return new Milla(v.GetDistancia());
        }

        public static bool operator ==(Milla m, Kilometro k) 
        {
            return m.GetDistancia() == k.GetDistancia() * 0.621371f;
        }
        public static bool operator!=(Milla m, Kilometro k) { return !(m == k); }
    }
}
