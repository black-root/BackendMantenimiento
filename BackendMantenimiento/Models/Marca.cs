using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendMantenimiento.Models
{
    public class Marca
    {

        public long IdMarca { get; set; }

        public String Nombre { get; set; }

        public String Descripcion { get; set; }

        public String Telefono { get; set; }

        public String Email { get; set; }

        public String Direccion { get; set; }

        public String Website { get; set; }

        public String Fundador { get; set; }
    }
}
