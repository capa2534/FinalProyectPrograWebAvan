using Examen.Models.DataTransferModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Models.DataModels
{
    public class Ventas
    {
        public List<Elemento> Clientes { get; set; }
        public List<Elemento> Empleados { get; set; }

        public Ventas()
        {
            Empleados = new List<Elemento>();
            Clientes = new List<Elemento>();    
        }

        public Ventas(int id)
        {
            Id = id;            

        }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    
        public DateTime Fecha_hora { get; set; }    
        public Cliente Id_Cliente{ get; set; }
        public Auto Id_Auto { get; set; }
        public Empleado Empleado { get; set; }
        

    }
}
