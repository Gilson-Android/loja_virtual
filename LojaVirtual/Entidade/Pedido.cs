using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Entidade
{
    public class Pedido
    {
        [Required(ErrorMessage="Informe seu nome")]
        public string NomeCliente { get; set; }

        [Display(Name="Cep:" )]
        public string Cep { get; set; }

       [Display(Name = "Endereço:")]
       [Required(ErrorMessage = "Informe seu endereço")]
        public string Endereco { get; set; }

       [Display(Name = "Complemento:")]
       public string Complemento { get; set; }

       [Display(Name = "Cidade:")]
       [Required(ErrorMessage = "Informe sua cidade")]
       public string Cidade { get; set; }

        [Display(Name = "Bairro:")]
        [Required(ErrorMessage = "Informe seu bairro")]
       public string Bairro { get; set; }

        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Informe seu email")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        public bool EmbrulharPresente { get; set; }
    }
}
