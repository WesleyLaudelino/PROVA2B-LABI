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
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public TipoConta Tipo_Conta { get; set; }
    }
}