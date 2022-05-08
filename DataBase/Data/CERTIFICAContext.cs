using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataBase.Data
{
    public partial class CERTIFICAContext : DbContext
    {
        public CERTIFICAContext()
        {
        }

        public CERTIFICAContext(DbContextOptions<CERTIFICAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Database=CERTIFICA;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsId)
                    .IsClustered(false);

                entity.ToTable("USUARIOS");

                entity.HasIndex(e => e.UsUsuario, "IX_USUARIOS")
                    .IsUnique()
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.UsCpf, "UQ_USUARIOS_CPF")
                    .IsUnique();

                entity.HasIndex(e => e.UsEmail, "UQ_USUARIOS_EMAIL")
                    .IsUnique();

                entity.HasIndex(e => e.UsRg, "UQ_USUARIOS_RG")
                    .IsUnique();

                entity.HasIndex(e => e.UsId, "_dta_index_USUARIOS_7_995078881__K1_13");

                entity.HasIndex(e => e.UsId, "_dta_index_USUARIOS_7_995078881__K1_4");

                entity.Property(e => e.UsId).HasColumnName("US_ID");

                entity.Property(e => e.Alteracao)
                    .HasColumnType("datetime")
                    .HasColumnName("ALTERACAO")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsAceitaTermo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_ACEITA_TERMO");

                entity.Property(e => e.UsAceitaTermoDt)
                    .HasColumnType("datetime")
                    .HasColumnName("US_ACEITA_TERMO_DT");

                entity.Property(e => e.UsAddPlantaoManual).HasColumnName("US_ADD_PLANTAO_MANUAL");

                entity.Property(e => e.UsAtivo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_ATIVO")
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.UsBairro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_BAIRRO");

                entity.Property(e => e.UsCep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("US_CEP");

                entity.Property(e => e.UsCertiCart)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("US_CERTI_CART");

                entity.Property(e => e.UsCertiEmi)
                    .HasColumnType("datetime")
                    .HasColumnName("US_CERTI_EMI");

                entity.Property(e => e.UsCertiFol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_CERTI_FOL");

                entity.Property(e => e.UsCertiLiv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_CERTI_LIV");

                entity.Property(e => e.UsCertiTer)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_CERTI_TER");

                entity.Property(e => e.UsCertiTp)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("US_CERTI_TP");

                entity.Property(e => e.UsCidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("US_CIDADE");

                entity.Property(e => e.UsCnes)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("US_CNES");

                entity.Property(e => e.UsCnhEmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("US_CNH_EMISSAO");

                entity.Property(e => e.UsCnhNumero)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("US_CNH_NUMERO");

                entity.Property(e => e.UsCnhUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("US_CNH_UF");

                entity.Property(e => e.UsCns)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("US_CNS");

                entity.Property(e => e.UsCodigoReset)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_CODIGO_RESET");

                entity.Property(e => e.UsComplemento)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("US_COMPLEMENTO");

                entity.Property(e => e.UsCor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_COR");

                entity.Property(e => e.UsCpf)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("US_CPF");

                entity.Property(e => e.UsCredenciamento)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_CREDENCIAMENTO")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.UsCripto)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("US_CRIPTO");

                entity.Property(e => e.UsCtpsAdm)
                    .HasColumnType("datetime")
                    .HasColumnName("US_CTPS_ADM");

                entity.Property(e => e.UsCtpsCargo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("US_CTPS_CARGO");

                entity.Property(e => e.UsCtpsEmi)
                    .HasColumnType("datetime")
                    .HasColumnName("US_CTPS_EMI");

                entity.Property(e => e.UsCtpsFuncao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("US_CTPS_FUNCAO");

                entity.Property(e => e.UsCtpsNumfun)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_CTPS_NUMFUN");

                entity.Property(e => e.UsCtpsOcu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_CTPS_OCU");

                entity.Property(e => e.UsCtpsOcuDesc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("US_CTPS_OCU_DESC");

                entity.Property(e => e.UsCtpsProf)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_CTPS_PROF");

                entity.Property(e => e.UsCtpsProfDesc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("US_CTPS_PROF_DESC");

                entity.Property(e => e.UsCtpsSerie)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_CTPS_SERIE");

                entity.Property(e => e.UsCtpsTurno).HasColumnName("US_CTPS_TURNO");

                entity.Property(e => e.UsDddFax)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("US_DDD_FAX");

                entity.Property(e => e.UsDddResidencia)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("US_DDD_RESIDENCIA");

                entity.Property(e => e.UsDddTrabalho)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("US_DDD_TRABALHO");

                entity.Property(e => e.UsDocEmi)
                    .HasColumnType("datetime")
                    .HasColumnName("US_DOC_EMI");

                entity.Property(e => e.UsDtEntPais)
                    .HasColumnType("datetime")
                    .HasColumnName("US_DT_ENT_PAIS");

                entity.Property(e => e.UsEMedico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_E_MEDICO")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.UsEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("US_EMAIL");

                entity.Property(e => e.UsEmail2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("US_EMAIL2");

                entity.Property(e => e.UsEmailSenha)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_EMAIL_SENHA");

                entity.Property(e => e.UsEmiPass)
                    .HasColumnType("datetime")
                    .HasColumnName("US_EMI_PASS");

                entity.Property(e => e.UsEmpresa).HasColumnName("US_EMPRESA");

                entity.Property(e => e.UsEndereco)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("US_ENDERECO");

                entity.Property(e => e.UsEscol)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("US_ESCOL");

                entity.Property(e => e.UsEstado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("US_ESTADO");

                entity.Property(e => e.UsEstadoCivil)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_ESTADO_CIVIL");

                entity.Property(e => e.UsEtnia)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("US_ETNIA");

                entity.Property(e => e.UsExpira)
                    .HasColumnType("datetime")
                    .HasColumnName("US_EXPIRA");

                entity.Property(e => e.UsFaturista)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_FATURISTA")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.UsFax)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_FAX");

                entity.Property(e => e.UsFreEscola)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_FRE_ESCOLA")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UsGrupoBase).HasColumnName("US_GRUPO_BASE");

                entity.Property(e => e.UsInss)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_INSS");

                entity.Property(e => e.UsInternamento)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_INTERNAMENTO")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.UsLogradouro)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("US_LOGRADOURO");

                entity.Property(e => e.UsMaxSessoes).HasColumnName("US_MAX_SESSOES");

                entity.Property(e => e.UsMunNasc)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("US_MUN_NASC");

                entity.Property(e => e.UsNacionalidade)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_NACIONALIDADE")
                    .HasDefaultValueSql("('B')");

                entity.Property(e => e.UsNasUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("US_NAS_UF");

                entity.Property(e => e.UsNascPass)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("US_NASC_PASS");

                entity.Property(e => e.UsNascimento)
                    .HasColumnType("datetime")
                    .HasColumnName("US_NASCIMENTO");

                entity.Property(e => e.UsNatural)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_NATURAL");

                entity.Property(e => e.UsNome)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("US_NOME");

                entity.Property(e => e.UsNomeSocial)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("US_NOME_SOCIAL");

                entity.Property(e => e.UsNum1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_NUM1");

                entity.Property(e => e.UsNumPass)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("US_NUM_PASS");

                entity.Property(e => e.UsOrgao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_ORGAO");

                entity.Property(e => e.UsOrgaoUf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("US_ORGAO_UF");

                entity.Property(e => e.UsPaginaInicial)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("US_PAGINA_INICIAL");

                entity.Property(e => e.UsPais)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_PAIS");

                entity.Property(e => e.UsPaisPass)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("US_PAIS_PASS");

                entity.Property(e => e.UsPeratual).HasColumnName("US_PERATUAL");

                entity.Property(e => e.UsPis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_PIS");

                entity.Property(e => e.UsPortariaData)
                    .HasColumnType("datetime")
                    .HasColumnName("US_PORTARIA_DATA");

                entity.Property(e => e.UsPortariaNat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_PORTARIA_NAT");

                entity.Property(e => e.UsProfConsReg).HasColumnName("US_PROF_CONS_REG");

                entity.Property(e => e.UsProfissional).HasColumnName("US_PROFISSIONAL");

                entity.Property(e => e.UsQtdDom).HasColumnName("US_QTD_DOM");

                entity.Property(e => e.UsRamalFax)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("US_RAMAL_FAX");

                entity.Property(e => e.UsRamalResidencia)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("US_RAMAL_RESIDENCIA");

                entity.Property(e => e.UsRamalTrabalho)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("US_RAMAL_TRABALHO");

                entity.Property(e => e.UsRealizaLibera)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_REALIZA_LIBERA")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.UsReligiao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("US_RELIGIAO");

                entity.Property(e => e.UsRg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_RG");

                entity.Property(e => e.UsSame)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_SAME")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.UsSenha)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_SENHA");

                entity.Property(e => e.UsSenhaCript).HasColumnName("US_SENHA_CRIPT");

                entity.Property(e => e.UsSenhaCriptAterior).HasColumnName("US_SENHA_CRIPT_ATERIOR");

                entity.Property(e => e.UsSetor).HasColumnName("US_SETOR");

                entity.Property(e => e.UsSexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_SEXO");

                entity.Property(e => e.UsSexoSocial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_SEXO_SOCIAL");

                entity.Property(e => e.UsSitFam)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("US_SIT_FAM");

                entity.Property(e => e.UsTecnico).HasColumnName("US_TECNICO");

                entity.Property(e => e.UsTelefoneResidencia)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_TELEFONE_RESIDENCIA");

                entity.Property(e => e.UsTelefoneTrabalho)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("US_TELEFONE_TRABALHO");

                entity.Property(e => e.UsTemplate1)
                    .HasColumnType("image")
                    .HasColumnName("US_TEMPLATE1");

                entity.Property(e => e.UsTemplate2)
                    .HasColumnType("image")
                    .HasColumnName("US_TEMPLATE2");

                entity.Property(e => e.UsTemplate3)
                    .HasColumnType("image")
                    .HasColumnName("US_TEMPLATE3");

                entity.Property(e => e.UsTemplate4)
                    .HasColumnType("image")
                    .HasColumnName("US_TEMPLATE4");

                entity.Property(e => e.UsTemplate5)
                    .HasColumnType("image")
                    .HasColumnName("US_TEMPLATE5");

                entity.Property(e => e.UsTipoCaixa)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_TIPO_CAIXA")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.UsTipoUsuario).HasColumnName("US_TIPO_USUARIO");

                entity.Property(e => e.UsTitNum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_TIT_NUM");

                entity.Property(e => e.UsTitSecao)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("US_TIT_SECAO");

                entity.Property(e => e.UsTitZona)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("US_TIT_ZONA");

                entity.Property(e => e.UsTpTel1).HasColumnName("US_TP_TEL1");

                entity.Property(e => e.UsTpTel2).HasColumnName("US_TP_TEL2");

                entity.Property(e => e.UsTpTel3).HasColumnName("US_TP_TEL3");

                entity.Property(e => e.UsTrocarSenha)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("US_TROCAR_SENHA")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UsUfNatural)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("US_UF_NATURAL");

                entity.Property(e => e.UsUltimoNome)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("US_ULTIMO_NOME");

                entity.Property(e => e.UsUsuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("US_USUARIO");

                entity.Property(e => e.UsValPass)
                    .HasColumnType("datetime")
                    .HasColumnName("US_VAL_PASS");

                entity.Property(e => e.Usuario1).HasColumnName("USUARIO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
