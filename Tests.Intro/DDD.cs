using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Intro
{
    public class DDD
    {
        public static string ValidarDDD(int entrada)
        {

            if (entrada < 10 || entrada > 99)
            {
                throw new ArgumentException("DDD inválido");
            } 
            else if (entrada == 11) {
                return "São Paulo";
            }
            else if (entrada == 19)
            {
                return "Campinas";
            }
            else if (entrada == 21)
            {
                return "Rio de Janeiro";
            }
            else if (entrada == 27)
            {
                return "Vitória";
            }
            else if (entrada == 31)
            {
                return "Belo Horizonte";
            }
            else if (entrada == 32)
            {
                return "Juiz de Fora";
            }
            else if (entrada == 61)
            {
                return "Brasília";
            }
            else if (entrada == 71)
            {
                return "Salvador";
            }
            else
            {
                throw new ArgumentException("DDD não encontrado");
            }
        }
    }
}
