using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVehiculo.Models
{
    [Table("Vehiculos")]
    public class MVehiculos
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Required]
        [Column("marca")]
        public string marca { get; set; }

        [Required]
        [Column("modelo")]
        public string modelo { get; set; }

        [Required]
        [Column("tipo")]
        public string tipo { get; set; }


    }
}


//    create table Vehiculos(
//id int primary key identity,
//marca varchar(50) not null,
//modelo varchar(50) not null,
//tipo varchar(50) not null
//);