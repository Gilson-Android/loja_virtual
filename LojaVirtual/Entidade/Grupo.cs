using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Entidade
{
    [Table("Grupo")]
    public class Grupo
    {
        [Key]
        public int id_Grupo { get; set; }
        public String ds_Grupo { get; set; }
    }
}
