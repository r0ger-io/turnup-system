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
    
    public partial class TB_ALUGUEL
    {
        public TB_ALUGUEL()
        {
            this.TB_LIVRO = new HashSet<TB_LIVRO>();
        }
    
        public int COD_ALUGUEL { get; set; }
        public Nullable<System.DateTime> DATA_ALUGUEL { get; set; }
        public Nullable<System.DateTime> DATA_DEVOLUCAO { get; set; }
        public int COD_ALUNO { get; set; }
    
        public virtual TB_ALUNO TB_ALUNO { get; set; }
        public virtual ICollection<TB_LIVRO> TB_LIVRO { get; set; }
    }
}
