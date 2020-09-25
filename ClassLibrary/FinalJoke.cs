using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Classe model da piada
    /// </summary>
    public class FinalJoke
    {
        public bool Error { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Joke { get; set; }
        public string Setup { get; set; }
        public string Delivery { get; set; }
        public Flags Flags { get; set; }
        public int Id { get; set; }
        public string Lang { get; set; }
    }
}
