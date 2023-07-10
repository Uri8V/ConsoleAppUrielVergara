using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUrielVergara.Entidades
{
    public  class Yarda
    {
        private float _distancia;

        public Yarda(float distancia)
        {
            _distancia = distancia;
        }
        public Yarda() : this(100)
        { }
        public float GetDistancia() => _distancia;

        public static implicit operator Yarda(float v)
        {
           return new Yarda(v);
        }

        public static explicit operator Yarda(Kilometro v)
        {
            return new Yarda(v.GetDistancia());
        }

        public static explicit operator Yarda(Milla v)
        {
            return new Yarda(v.GetDistancia());
        }
        public static bool operator ==(Yarda a, Kilometro K)
        {
            return a.GetDistancia() == K.GetDistancia()*1093.61;
        }
        public static bool operator!=(Yarda a, Kilometro k)
        {
            return !(a == k);
        }

    }
}
