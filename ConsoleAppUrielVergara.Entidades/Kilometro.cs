using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUrielVergara.Entidades
{
    public  class Kilometro
    {
        private float _distancia;

        public Kilometro(float distancia)
        {
          _distancia = distancia;
        }
        public Kilometro(): this(100)
        { }
        public float GetDistancia() => _distancia;

        public static implicit operator Kilometro(float v)
        {
           return new Kilometro(v);
        }

        public static explicit operator Kilometro(Milla v)
        {
            return new Kilometro(v.GetDistancia());
        }

        public static explicit operator Kilometro(Yarda v)
        {
            return new Kilometro(v.GetDistancia());
        }

        public static bool operator ==(Kilometro k, Kilometro k2) 
        {
            return k.GetDistancia()==k2.GetDistancia();
        }
        public static bool operator!=(Kilometro k, Kilometro k2)
        {
            return !(k == k2);
        }
        public static bool operator==(Kilometro k, Milla m)
        {
            return k.GetDistancia()==m.GetDistancia();
        }

        public static bool operator !=(Kilometro k, Milla m)
        {
            return true;
        }
    }
}
