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
    
    public partial class TB_BOLETIM
    {
        public int COD_BOLETIM { get; set; }
        public int COD_FUNC { get; set; }
        public int COD_ALUNO { get; set; }
        public Nullable<decimal> NOTA_PROVA_ESCRITA_1 { get; set; }
        public Nullable<decimal> NOTA_PROVA_ESCRITA_2 { get; set; }
        public Nullable<decimal> NOTA_PROVA_ESCRITA_3 { get; set; }
        public Nullable<decimal> NOTA_PROVA_ESCRITA_4 { get; set; }
        public Nullable<decimal> NOTA_PROVA_ORAL_1 { get; set; }
        public Nullable<decimal> NOTA_PROVA_ORAL_2 { get; set; }
        public Nullable<decimal> NOTA_PROVA_ORAL_3 { get; set; }
        public Nullable<decimal> NOTA_PROVA_ORAL_4 { get; set; }
        public Nullable<decimal> NOTA_PARTICIPACAO_1 { get; set; }
        public Nullable<decimal> NOTA_PARTICIPACAO_2 { get; set; }
    
        public virtual TB_ALUNO TB_ALUNO { get; set; }
        public virtual TB_FUNCIONARIO TB_FUNCIONARIO { get; set; }
    }
}
