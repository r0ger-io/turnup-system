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
    
    public partial class TB_FUNCIONARIO
    {
        public TB_FUNCIONARIO()
        {
            this.TB_BOLETIM = new HashSet<TB_BOLETIM>();
            this.TB_LOGAR = new HashSet<TB_LOGAR>();
            this.TB_TURMA = new HashSet<TB_TURMA>();
        }
    
        public int COD_FUNC { get; set; }
        public string NOME_FUNC { get; set; }
        public string FUNCAO_FUNC { get; set; }
        public System.DateTime NASC_FUNC { get; set; }
        public Nullable<decimal> SALARIO_FUNC { get; set; }
        public Nullable<bool> VALE_TRANSPORTE_FUNC { get; set; }
        public Nullable<bool> VALE_ALIMENTACAO_FUNC { get; set; }
        public Nullable<decimal> NUM_CARTEIRA_TRABALHO { get; set; }
        public string CAMINHO_IMG { get; set; }
        public byte[] IMG { get; set; }
        public string TIPO_SALARIO { get; set; }
        public Nullable<decimal> SALARIO { get; set; }
        public Nullable<decimal> NUM_PIS { get; set; }
        public decimal TELEFONE1 { get; set; }
        public Nullable<decimal> TELEFONE2 { get; set; }
        public decimal CELULAR { get; set; }
        public decimal RG { get; set; }
        public decimal CPF { get; set; }
        public string ORGAO_EMISSOR { get; set; }
        public string LOGRADOURO { get; set; }
        public decimal NUMERO_LOGRA { get; set; }
        public string COMPLEMENTO { get; set; }
        public Nullable<decimal> CEP { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
    
        public virtual ICollection<TB_BOLETIM> TB_BOLETIM { get; set; }
        public virtual ICollection<TB_LOGAR> TB_LOGAR { get; set; }
        public virtual ICollection<TB_TURMA> TB_TURMA { get; set; }
    }
}