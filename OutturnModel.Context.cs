﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_TCM_OutturnEntities : DbContext
    {
        public DB_TCM_OutturnEntities()
            : base("name=DB_TCM_OutturnEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_ALUGUEL> TB_ALUGUEL { get; set; }
        public virtual DbSet<TB_ALUNO> TB_ALUNO { get; set; }
        public virtual DbSet<TB_BOLETIM> TB_BOLETIM { get; set; }
        public virtual DbSet<TB_FUNCIONARIO> TB_FUNCIONARIO { get; set; }
        public virtual DbSet<TB_LIVRO> TB_LIVRO { get; set; }
        public virtual DbSet<TB_LOGAR> TB_LOGAR { get; set; }
        public virtual DbSet<TB_TURMA> TB_TURMA { get; set; }
    }
}