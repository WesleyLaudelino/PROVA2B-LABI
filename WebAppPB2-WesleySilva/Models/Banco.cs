using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppPB2_WesleySilva.Models
{
    public class Banco
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Agencia é obrigatória !!")]
        public string Agencia { get; set; }
        [Required(ErrorMessage = "Conta é obrigatória !!")]
        public string ContaCorrente { get; set; }
        public TipoConta Tipo_Conta { get; set; }
    }
}