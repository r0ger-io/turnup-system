//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCM_4_FUN
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_ALUNO
    {
        public TB_ALUNO()
        {
            this.TB_ALUGUEL = new HashSet<TB_ALUGUEL>();
            this.TB_BOLETIM = new HashSet<TB_BOLETIM>();
            this.TB_TURMA = new HashSet<TB_TURMA>();
        }
    
        public int COD_ALUNO { get; set; }
        public string NOME_ALUNO { get; set; }
        public System.DateTime NASC_ALUNO { get; set; }
        public Nullable<bool> STATUS_ALUNO { get; set; }
        public string SEXO_ALUNO { get; set; }
        public Nullable<bool> PLANO_SAUDE { get; set; }
        public string OBSERVACAO_MEDICA { get; set; }
        public string CAMINHO_IMG { get; set; }
        public byte[] IMG { get; set; }
        public decimal TELEFONE1 { get; set; }
        public Nullable<decimal> TELEFONE2 { get; set; }
        public decimal CELULAR { get; set; }
        public Nullable<decimal> RG { get; set; }
        public Nullable<decimal> CPF { get; set; }
        public string ORGAO_EMISSOR { get; set; }
        public string LOGRADOURO { get; set; }
        public decimal NUMERO_LOGRA { get; set; }
        public string COMPLEMENTO { get; set; }
        public Nullable<decimal> CEP { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
    
        public virtual ICollection<TB_ALUGUEL> TB_ALUGUEL { get; set; }
        public virtual ICollection<TB_BOLETIM> TB_BOLETIM { get; set; }
        public virtual ICollection<TB_TURMA> TB_TURMA { get; set; }
    }
}
