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
    
    public partial class PictureEntities : DbContext
    {
        public PictureEntities()
            : base("name=PictureEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_ALUGUEL> TB_ALUGUEL { get; set; }
        public virtual DbSet<TB_ALUNO> TB_ALUNO { get; set; }
        public virtual DbSet<TB_CAIXA> TB_CAIXA { get; set; }
        public virtual DbSet<TB_COMPRA> TB_COMPRA { get; set; }
        public virtual DbSet<TB_CURSO> TB_CURSO { get; set; }
        public virtual DbSet<TB_DOCUMENTO> TB_DOCUMENTO { get; set; }
        public virtual DbSet<TB_ENDERECO> TB_ENDERECO { get; set; }
        public virtual DbSet<TB_FUNCIONARIO> TB_FUNCIONARIO { get; set; }
        public virtual DbSet<TB_LIVRO> TB_LIVRO { get; set; }
        public virtual DbSet<TB_LOGAR> TB_LOGAR { get; set; }
        public virtual DbSet<TB_MENCAO> TB_MENCAO { get; set; }
        public virtual DbSet<TB_MENSALIDADE> TB_MENSALIDADE { get; set; }
        public virtual DbSet<TB_PROFESSOR> TB_PROFESSOR { get; set; }
        public virtual DbSet<TB_PROVA> TB_PROVA { get; set; }
        public virtual DbSet<TB_RESPONSAVEL> TB_RESPONSAVEL { get; set; }
        public virtual DbSet<TB_SALA> TB_SALA { get; set; }
        public virtual DbSet<TB_SALA_DE_VIDEO> TB_SALA_DE_VIDEO { get; set; }
        public virtual DbSet<TB_TELEFONE> TB_TELEFONE { get; set; }
        public virtual DbSet<TB_TURMA> TB_TURMA { get; set; }
    }
}
