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
    
    public partial class TB_SALA_DE_VIDEO
    {
        public int COD_SALA_VIDEO { get; set; }
        public Nullable<int> COD_FUNC { get; set; }
        public Nullable<int> COD_PROFESSOR { get; set; }
        public Nullable<int> COD_TURMA { get; set; }
        public Nullable<System.TimeSpan> HORA_VIDEO { get; set; }
        public Nullable<byte> DIA_VIDEO { get; set; }
    
        public virtual TB_FUNCIONARIO TB_FUNCIONARIO { get; set; }
        public virtual TB_PROFESSOR TB_PROFESSOR { get; set; }
        public virtual TB_TURMA TB_TURMA { get; set; }
    }
}
