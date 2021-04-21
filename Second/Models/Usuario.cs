using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Minha_Sgunda_Aplicação.Models
{
    [table("Usuario")]
    public class Usuario
        {
        [Display(Name ="Nome")]
        [Column("Nome do usuário")]
        public string Nome { get; set; }
    }

  
}
