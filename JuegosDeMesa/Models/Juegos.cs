using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDeMesa.Models
{
    public class Juegos
    {
      
            public string _id { get; set; }
            public string nombre { get; set; }
            public int tiempodejuego { get; set; }
            public int CantidadDeJugadores { get; set; }
            public string editorial { get; set; }
        
    }
}
