using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppPB2_WesleySilva.Models
{
    public class Banco
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Agencia é obrigatória !!")]
        public string Agencia { get; set; }
        [Required(ErrorMessage = "Conta é obrigatória !!")]
        // O código abaixo foi comentado porque não funcionou. Não deixa grava o registro
        //[Remote("VerificaConta", "ContaCorrente", ErrorMessage = "Conta já existe !!")]
        public string ContaCorrente { get; set; }
        public TipoConta Tipo_Conta { get; set; }
    }
}