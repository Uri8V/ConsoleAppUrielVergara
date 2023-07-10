using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUrielVergara.Entidades
{
    public  class Cono
    {
        private double altura;
        private double radio;
        private double genematriz;

        public Cono(double Altura, double Radio)
        {
            if (Altura<=0 || Radio <=0)
            {
              throw  new ArgumentException("El radio o la altura deben ser mayores a 0");
            }     
            altura = Altura;
            radio = Radio;
            genematriz = Math.Sqrt(Math.Pow(Radio, 2) + (Math.Pow(Altura, 2)));
        }
       
        public double GetArea()
        {
            double area = 0;
            area = Math.PI * radio * (radio + genematriz);
            return Math.Truncate(area);
        }
        public double GetVolumen()
        {
            double volumen= 0;
            volumen = (Math.PI * Math.Pow(radio, 2) * altura) / 3;
            return Math.Truncate(volumen);
        }

        public string GetValores()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La altura del Cono es: {altura}");
            sb.AppendLine($"El radio del Cono es: {radio}");
            sb.AppendLine($"La Genematriz del Cono es: {genematriz.ToString("n2")}");
            sb.AppendLine($"El Volumen del cono es: {GetVolumen()}");
            sb.AppendLine($"El Area del Cono es: {GetArea()}");
            return sb.ToString();
        }

    }
}
