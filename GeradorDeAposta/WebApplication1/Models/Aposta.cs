using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApostaGenerator.Models
{
    public class Aposta
    {
        public int Id { get; set; }

        [Required]
        public List<int> Numeros { get; set; } = new List<int>();

        public Aposta()
        {
            var random = new Random();
            while (Numeros.Count < 6) 
            {
                int numero = random.Next(1, 60); 
                if (!Numeros.Contains(numero))
                {
                    Numeros.Add(numero);
                }
            }
            Numeros.Sort(); 
        }
    }
}
