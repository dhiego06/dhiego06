using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ClienteWebPortal
{
    public partial class LICITANTEContext : DbContext
    {
        public LICITANTEContext()
        {
        }

        public LICITANTEContext(DbContextOptions<LICITANTEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArquivoEdital> ArquivoEditals { get; set; }
        public virtual DbSet<Concorrente> Concorrentes { get; set; }
        public virtual DbSet<Contrato> Contratos { get; set; }
        public virtual DbSet<DeclaracaoPropostum> DeclaracaoProposta { get; set; }
        public virtual DbSet<Documento> Documentos { get; set; }
        public virtual DbSet<Edital> Editals { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Esclarecimento> Esclarecimentos { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Licitante> Licitantes { get; set; }
        public virtual DbSet<NotaFiscal> NotaFiscals { get; set; }
        public virtual DbSet<OrdemCompra> OrdemCompras { get; set; }
        public virtual DbSet<Processo> Processos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Propostum> Proposta { get; set; }
        public virtual DbSet<Recurso> Recursos { get; set; }
        public virtual DbSet<Representante> Representantes { get; set; }
        public virtual DbSet<SituacaoEdital> SituacaoEditals { get; set; }
        public virtual DbSet<SituacaoProcesso> SituacaoProcessos { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public virtual DbSet<TipoHabilitacao> TipoHabilitacaos { get; set; }
        public virtual DbSet<TipoItem> TipoItems { get; set; }
        public virtual DbSet<TipoLicitacao> TipoLicitacaos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Database=LICITANTE;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<ArquivoEdital>(entity =>
            {
                entity.HasKey(e => e.IdArquivo);

                entity.ToTable("ArquivoEdital");

                entity.Property(e => e.Arquivo).IsRequired();

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEditalNavigation)
                    .WithMany(p => p.ArquivoEditals)
                    .HasForeignKey(d => d.IdEdital)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArquivoEdital_Edital");
            });

            modelBuilder.Entity<Concorrente>(entity =>
            {
                entity.HasKey(e => e.IdConcorrente)
                    .HasName("PK__Concorre__BEED4FC6598F0F10");

                entity.ToTable("Concorrente");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Concorrentes)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Concorrente_Empresa");
            });

            modelBuilder.Entity<Contrato>(entity =>
            {
                entity.HasKey(e => e.IdContrato);

                entity.ToTable("Contrato");

                entity.Property(e => e.DataFim)
                    .HasColumnType("datetime")
                    .HasComment("Vigencia (data inicio / Data fim)");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("datetime")
                    .HasComment("Vigencia (data inicio / Data fim)");

                entity.Property(e => e.IdEdital).HasComment("Selecionar processo (edital)");

                entity.Property(e => e.NovoValor).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentualAditivado).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdEditalNavigation)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.IdEdital)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contrato_Edital");
            });

            modelBuilder.Entity<DeclaracaoPropostum>(entity =>
            {
                entity.HasKey(e => e.IdDeclaracao);

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Texto)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPropostaNavigation)
                    .WithMany(p => p.DeclaracaoProposta)
                    .HasForeignKey(d => d.IdProposta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeclaracaoProposta_Proposta");
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.IdDocumento)
                    .HasName("PK__Document__E5207347B06A09CA");

                entity.ToTable("Documento");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdEditalNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdEdital)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documento_Edital");

                entity.HasOne(d => d.IdRepresentanteNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdRepresentante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documento_Representante");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documento_TipoDocumento");
            });

            modelBuilder.Entity<Edital>(entity =>
            {
                entity.HasKey(e => e.IdEdital);

                entity.ToTable("Edital");

                entity.Property(e => e.AnaliseDois).IsUnicode(false);

                entity.Property(e => e.AnaliseUm).IsUnicode(false);

                entity.Property(e => e.DataAbertura).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataDisputa).HasColumnType("datetime");

                entity.Property(e => e.DataImpugnacao).HasColumnType("datetime");

                entity.Property(e => e.IdRepresentante).HasComment("Responsável pela Analise");

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PrazoPagamento)
                    .HasColumnType("datetime")
                    .HasComment("Prazo de pagamento");

                entity.Property(e => e.Validade)
                    .HasColumnType("datetime")
                    .HasComment("Validade da proposta");

                entity.HasOne(d => d.IdRepresentanteNavigation)
                    .WithMany(p => p.Editals)
                    .HasForeignKey(d => d.IdRepresentante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Edital_Representante");

                entity.HasOne(d => d.IdSituacaoNavigation)
                    .WithMany(p => p.Editals)
                    .HasForeignKey(d => d.IdSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Edital_SituacaoEdital");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK__Empresa__5EF4033EAB2EE121");

                entity.ToTable("Empresa");

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Esclarecimento>(entity =>
            {
                entity.HasKey(e => e.IdEsclarecimento);

                entity.ToTable("Esclarecimento");

                entity.Property(e => e.DataEnvio).HasColumnType("datetime");

                entity.Property(e => e.DataResposta).HasColumnType("datetime");

                entity.HasOne(d => d.IdConcorrenteNavigation)
                    .WithMany(p => p.Esclarecimentos)
                    .HasForeignKey(d => d.IdConcorrente)
                    .HasConstraintName("FK_Esclarecimento_Concorrente");

                entity.HasOne(d => d.IdPropostaNavigation)
                    .WithMany(p => p.Esclarecimentos)
                    .HasForeignKey(d => d.IdProposta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Esclarecimento_Proposta");

                entity.HasOne(d => d.IdRepresentanteNavigation)
                    .WithMany(p => p.Esclarecimentos)
                    .HasForeignKey(d => d.IdRepresentante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Esclarecimento_Representante");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.IdItem);

                entity.ToTable("Item");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Item1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Item");

                entity.Property(e => e.Lote)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValorCompra).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorVenda).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.IdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Produto");

                entity.HasOne(d => d.IdTipoItemNavigation)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.IdTipoItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_TipoItem");
            });

            modelBuilder.Entity<Licitante>(entity =>
            {
                entity.HasKey(e => e.IdLicitante);

                entity.ToTable("Licitante");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Site)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotaFiscal>(entity =>
            {
                entity.HasKey(e => e.IdNota);

                entity.ToTable("NotaFiscal");

                entity.Property(e => e.Emissao).HasColumnType("datetime");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pagamento)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdOrdemCompraNavigation)
                    .WithMany(p => p.NotaFiscals)
                    .HasForeignKey(d => d.IdOrdemCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotaFiscal_OrdemCompra");
            });

            modelBuilder.Entity<OrdemCompra>(entity =>
            {
                entity.HasKey(e => e.IdOrdemCompra);

                entity.ToTable("OrdemCompra");

                entity.Property(e => e.NovoPrazo).HasColumnType("datetime");

                entity.Property(e => e.NumeroEmpenho)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrazoEntrega).HasColumnType("datetime");

                entity.HasOne(d => d.IdEditalNavigation)
                    .WithMany(p => p.OrdemCompras)
                    .HasForeignKey(d => d.IdEdital)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdemCompra_Edital");

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.OrdemCompras)
                    .HasForeignKey(d => d.IdItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdemCompra_Item");
            });

            modelBuilder.Entity<Processo>(entity =>
            {
                entity.HasKey(e => e.IdProcesso);

                entity.ToTable("Processo");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdLicitanteNavigation)
                    .WithMany(p => p.Processos)
                    .HasForeignKey(d => d.IdLicitante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Processo_Licitante");

                entity.HasOne(d => d.IdSituacaoNavigation)
                    .WithMany(p => p.Processos)
                    .HasForeignKey(d => d.IdSituacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Processo_SituacaoProcesso");

                entity.HasOne(d => d.IdTipoHabilitacaoNavigation)
                    .WithMany(p => p.Processos)
                    .HasForeignKey(d => d.IdTipoHabilitacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Processo_TipoHabilitacao");

                entity.HasOne(d => d.IdTipoLicitacaoNavigation)
                    .WithMany(p => p.Processos)
                    .HasForeignKey(d => d.IdTipoLicitacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Processo_TipoLicitacao");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Processos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Processo_Usuario");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.IdProduto);

                entity.ToTable("Produto");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prazo).HasColumnType("datetime");

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Propostum>(entity =>
            {
                entity.HasKey(e => e.IdProposta);

                entity.Property(e => e.Garantia).HasComment("Pegar de produto");

                entity.Property(e => e.MotivoPerdeu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrazoPagamento).HasColumnType("datetime");

                entity.Property(e => e.Validade)
                    .HasColumnType("datetime")
                    .HasComment("Validade automática do cadastro do edital");

                entity.Property(e => e.ValorArremate).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdConcorrenteNavigation)
                    .WithMany(p => p.Proposta)
                    .HasForeignKey(d => d.IdConcorrente)
                    .HasConstraintName("FK_Proposta_Concorrente");
            });

            modelBuilder.Entity<Recurso>(entity =>
            {
                entity.HasKey(e => e.IdRecurso);

                entity.ToTable("Recurso");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataLimite).HasColumnType("datetime");

                entity.HasOne(d => d.IdPropostaNavigation)
                    .WithMany(p => p.Recursos)
                    .HasForeignKey(d => d.IdProposta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recurso_Proposta");
            });

            modelBuilder.Entity<Representante>(entity =>
            {
                entity.HasKey(e => e.IdRepresentante)
                    .HasName("PK__Represen__980D28E0F4CA7CAE");

                entity.ToTable("Representante");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Representantes)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Representante_Usuario");
            });

            modelBuilder.Entity<SituacaoEdital>(entity =>
            {
                entity.HasKey(e => e.IdSituacao);

                entity.ToTable("SituacaoEdital");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SituacaoProcesso>(entity =>
            {
                entity.HasKey(e => e.IdSituacao)
                    .HasName("PK__Situacao__810BCE3A36659C3D");

                entity.ToTable("SituacaoProcesso");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento)
                    .HasName("PK__TipoDocu__3AB3332F639A00A4");

                entity.ToTable("TipoDocumento");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoHabilitacao>(entity =>
            {
                entity.HasKey(e => e.IdTipoHabilitacao)
                    .HasName("PK__TipoHabi__AAC63CAFE1F72D5C");

                entity.ToTable("TipoHabilitacao");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoItem>(entity =>
            {
                entity.HasKey(e => e.IdTipoItem)
                    .HasName("PK__TipoItem__D74BB8246407B35C");

                entity.ToTable("TipoItem");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoLicitacao>(entity =>
            {
                entity.HasKey(e => e.IdTipoLicitacao);

                entity.ToTable("TipoLicitacao");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Usuario");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiraSenha).HasColumnType("datetime");

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
