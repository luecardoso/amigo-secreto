using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AmigoSecreto
{
    internal class Utilidades
    {
        /// <summary>
        /// método estático que recebe um nome completo e cria um email da UFN
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>email </returns>
        public static string gerarEmail(string nome)
        {
            string[] vetor = nome.Split();
            string email = (vetor[0] + "." + vetor[vetor.Length - 1] + "@ufn.edu.br").ToLower();
            return email;
        }

    }
}
