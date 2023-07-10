using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUrielVergara.Entidades
{
    public static class ValidadorPatente
    {
        public static string Validar(string s)
        {
           return VerificarFormato(s.);
        }

        private static string VerificarFormato(string s)
        {

            if (s.Length==7)
            {
             return   "El formato de la patente es el viejo";
            }
            else
            {
                if(s.Length==9)
                {
                   return "El formato de la patente es el nuevo";
                }
                else
                {
                    return "El formato ingresado no existe";
                }
            }
            
        }
    }
}
