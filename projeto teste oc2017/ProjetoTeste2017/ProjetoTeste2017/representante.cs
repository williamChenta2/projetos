//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoTeste2017
{
    using System;
    using System.Collections.Generic;
    
    public partial class representante
    {
        public int id { get; set; }
        public string nome { get; set; }
        public System.DateTime dataNascimento { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string cep { get; set; }
        public int id_cidade { get; set; }
        public string bairro { get; set; }
        public string endereco { get; set; }
        public byte status { get; set; }
        public string foto { get; set; }
    
        public virtual cidade cidade { get; set; }
    }
}
