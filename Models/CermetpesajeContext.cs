using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace sism.Models;

public partial class CermetpesajeContext : DbContext
{
    public CermetpesajeContext()
    {
    }

    public CermetpesajeContext(DbContextOptions<CermetpesajeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acceso> Accesos { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Chofer> Chofers { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Clientegenerador> Clientegeneradors { get; set; }

    public virtual DbSet<Comuna> Comunas { get; set; }

    public virtual DbSet<Consultacliente> Consultaclientes { get; set; }

    public virtual DbSet<Contactocliente> Contactoclientes { get; set; }

    public virtual DbSet<Detalleproducto> Detalleproductos { get; set; }

    public virtual DbSet<Generadore> Generadores { get; set; }

    public virtual DbSet<Generadores2> Generadores2s { get; set; }

    public virtual DbSet<Gruposusuario> Gruposusuarios { get; set; }

    public virtual DbSet<Impresora> Impresoras { get; set; }

    public virtual DbSet<Iso14001> Iso14001s { get; set; }

    public virtual DbSet<Lavado> Lavados { get; set; }

    public virtual DbSet<Modificacionpesaje> Modificacionpesajes { get; set; }

    public virtual DbSet<Modificacionpesajetransferencium> Modificacionpesajetransferencia { get; set; }

    public virtual DbSet<Patente> Patentes { get; set; }

    public virtual DbSet<Patentecliente> Patenteclientes { get; set; }

    public virtual DbSet<Patenteclientetransferencium> Patenteclientetransferencia { get; set; }

    public virtual DbSet<Patentememorandum> Patentememoranda { get; set; }

    public virtual DbSet<Patentestransferencium> Patentestransferencia { get; set; }

    public virtual DbSet<Patentetransporte> Patentetransportes { get; set; }

    public virtual DbSet<Pesaje> Pesajes { get; set; }

    public virtual DbSet<Pesajetransferencium> Pesajetransferencia { get; set; }

    public virtual DbSet<Planta> Plantas { get; set; }

    public virtual DbSet<Plantasprog> Plantasprogs { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Rampla> Ramplas { get; set; }

    public virtual DbSet<Regione> Regiones { get; set; }

    public virtual DbSet<Residuo> Residuos { get; set; }

    public virtual DbSet<Serial> Serials { get; set; }

    public virtual DbSet<Supervisore> Supervisores { get; set; }

    public virtual DbSet<Tipocliente> Tipoclientes { get; set; }

    public virtual DbSet<Transferencium> Transferencia { get; set; }

    public virtual DbSet<Transporte> Transportes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vistalavado> Vistalavados { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder) 
    { 
       if (!OptionsBuilder.IsConfigured)
        {
            //OptionsBuilder.UseMySql("server=192.168.1.24;port=3306;database=cermetpesaje;uid=root;password=StaMarta.2022", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.6.22-mysql"));
        }
    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
     //   => optionsBuilder.UseMySql("server=192.168.1.24;port=3306;database=cermetpesaje;uid=root;password=StaMarta.2022", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.6.22-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_spanish2_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Acceso>(entity =>
        {
            entity.HasKey(e => e.Idaccesos).HasName("PRIMARY");

            entity.ToTable("accesos");

            entity.Property(e => e.Idaccesos)
                .HasColumnType("int(11)")
                .HasColumnName("idaccesos");
            entity.Property(e => e.AdministracionDeValoers).HasColumnType("tinyint(4)");
            entity.Property(e => e.Archivos).HasColumnType("tinyint(4)");
            entity.Property(e => e.Camion).HasColumnType("tinyint(4)");
            entity.Property(e => e.Camiones).HasColumnType("tinyint(4)");
            entity.Property(e => e.ClienteProveedor)
                .HasColumnType("tinyint(4)")
                .HasColumnName("Cliente/Proveedor");
            entity.Property(e => e.ClienteProveedor1)
                .HasColumnType("tinyint(4)")
                .HasColumnName("ClienteProveedor");
            entity.Property(e => e.Conductores).HasColumnType("tinyint(4)");
            entity.Property(e => e.ConexionServidor).HasColumnType("tinyint(4)");
            entity.Property(e => e.ControlHorario).HasColumnType("tinyint(4)");
            entity.Property(e => e.ControlItinerario).HasColumnType("tinyint(4)");
            entity.Property(e => e.ControlTransferencia).HasColumnType("tinyint(4)");
            entity.Property(e => e.Estado)
                .HasColumnType("tinyint(4)")
                .HasColumnName("estado");
            entity.Property(e => e.Generadores).HasColumnType("tinyint(4)");
            entity.Property(e => e.IdGrupoDeUsuarios).HasColumnType("int(11)");
            entity.Property(e => e.InformeGeneralDeTickets)
                .HasColumnType("tinyint(4)")
                .HasColumnName("informeGeneralDeTickets");
            entity.Property(e => e.InformeIngresos).HasColumnType("tinyint(4)");
            entity.Property(e => e.Informes).HasColumnType("tinyint(4)");
            entity.Property(e => e.IngresoDe).HasColumnType("tinyint(4)");
            entity.Property(e => e.IngresoDeTipos).HasColumnType("tinyint(4)");
            entity.Property(e => e.ListadoModificacion).HasColumnType("tinyint(4)");
            entity.Property(e => e.Modificacion).HasColumnType("tinyint(4)");
            entity.Property(e => e.Mop)
                .HasColumnType("tinyint(4)")
                .HasColumnName("MOP");
            entity.Property(e => e.ParametrosDinamicos).HasColumnType("tinyint(4)");
            entity.Property(e => e.PermanenciaEnPlanta).HasColumnType("tinyint(4)");
            entity.Property(e => e.Pesaje).HasColumnType("tinyint(4)");
            entity.Property(e => e.PesajeComercial).HasColumnType("tinyint(4)");
            entity.Property(e => e.PesajePorHora).HasColumnType("tinyint(4)");
            entity.Property(e => e.PesajeTrasferencia).HasColumnType("tinyint(4)");
            entity.Property(e => e.Pesajetransferencia)
                .HasColumnType("tinyint(4)")
                .HasColumnName("pesajetransferencia");
            entity.Property(e => e.ReimpresionTicketMop)
                .HasColumnType("tinyint(4)")
                .HasColumnName("ReimpresionTicket MOP");
            entity.Property(e => e.ReimpresionTickets).HasColumnType("tinyint(4)");
            entity.Property(e => e.SupervisoresyRamplas).HasColumnType("tinyint(4)");
            entity.Property(e => e.TipoResiduo).HasColumnType("tinyint(4)");
            entity.Property(e => e.TiposResiduos).HasColumnType("tinyint(4)");
            entity.Property(e => e.Transferencia).HasColumnType("tinyint(4)");
            entity.Property(e => e.Transportes).HasColumnType("tinyint(4)");
            entity.Property(e => e.Usuarios).HasColumnType("tinyint(4)");
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCargos).HasName("PRIMARY");

            entity
                .ToTable("cargos")
                .UseCollation("utf8_spanish_ci");

            entity.HasIndex(e => e.IdCargos, "idCargos_UNIQUE").IsUnique();

            entity.Property(e => e.IdCargos)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("idCargos");
            entity.Property(e => e.Area).HasMaxLength(45);
            entity.Property(e => e.Cargos).HasMaxLength(45);
        });

        modelBuilder.Entity<Chofer>(entity =>
        {
            entity.HasKey(e => e.Idchofer).HasName("PRIMARY");

            entity
                .ToTable("chofer")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Idchofer, "idchofer").IsUnique();

            entity.Property(e => e.Idchofer)
                .HasColumnType("int(11)")
                .HasColumnName("idchofer");
            entity.Property(e => e.Direccion).HasMaxLength(200);
            entity.Property(e => e.Estado)
                .HasColumnType("int(11)")
                .HasColumnName("estado");
            entity.Property(e => e.Fonos).HasMaxLength(45);
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Rut).HasMaxLength(45);
            entity.Property(e => e.Transporte).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("clientes")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Casilla)
                .HasMaxLength(45)
                .HasColumnName("casilla");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .HasColumnName("ciudad");
            entity.Property(e => e.ClienteProveedor).HasMaxLength(100);
            entity.Property(e => e.Comuna)
                .HasMaxLength(200)
                .HasColumnName("comuna");
            entity.Property(e => e.Direccionfactura)
                .HasMaxLength(200)
                .HasColumnName("direccionfactura");
            entity.Property(e => e.Estado)
                .HasColumnType("int(1)")
                .HasColumnName("estado");
            entity.Property(e => e.Fax)
                .HasMaxLength(45)
                .HasColumnName("fax");
            entity.Property(e => e.FechaPermitidaFin).HasMaxLength(45);
            entity.Property(e => e.FechaPermitidaInicio).HasMaxLength(45);
            entity.Property(e => e.Giro)
                .HasMaxLength(200)
                .HasColumnName("giro");
            entity.Property(e => e.LineaDeCredito)
                .HasMaxLength(45)
                .HasColumnName("linea de credito");
            entity.Property(e => e.Razonsocial)
                .HasMaxLength(300)
                .HasColumnName("razonsocial");
            entity.Property(e => e.Region)
                .HasMaxLength(200)
                .HasColumnName("region");
            entity.Property(e => e.Rut)
                .HasMaxLength(50)
                .HasColumnName("rut");
            entity.Property(e => e.Telefono)
                .HasMaxLength(45)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoCliente).HasMaxLength(100);
        });

        modelBuilder.Entity<Clientegenerador>(entity =>
        {
            entity.HasKey(e => e.IdClienteGenerador).HasName("PRIMARY");

            entity.ToTable("clientegenerador");

            entity.Property(e => e.IdClienteGenerador)
                .HasColumnType("int(11)")
                .HasColumnName("idClienteGenerador");
            entity.Property(e => e.Estado)
                .HasMaxLength(45)
                .HasColumnName("estado");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(45)
                .HasColumnName("idCliente");
            entity.Property(e => e.IdGenerador)
                .HasMaxLength(45)
                .HasColumnName("idGenerador");
        });

        modelBuilder.Entity<Comuna>(entity =>
        {
            entity.HasKey(e => e.IdComuna).HasName("PRIMARY");

            entity
                .ToTable("comuna")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.IdComuna)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("idComuna");
            entity.Property(e => e.Comuna1)
                .HasMaxLength(100)
                .HasColumnName("Comuna");
            entity.Property(e => e.IdRegion)
                .HasColumnType("int(11)")
                .HasColumnName("idRegion");
        });

        modelBuilder.Entity<Consultacliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("consultaclientes");

            entity.Property(e => e.CamNumero)
                .HasMaxLength(45)
                .HasColumnName("CAM_NUMERO")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.CamPatente)
                .HasMaxLength(45)
                .HasColumnName("CAM_PATENTE");
            entity.Property(e => e.ChfCodigo)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("CHF_CODIGO");
            entity.Property(e => e.ChfNombre)
                .HasMaxLength(200)
                .HasColumnName("CHF_NOMBRE")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.ChfRut)
                .HasMaxLength(45)
                .HasColumnName("CHF_RUT")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.CpvRazonsocial)
                .HasMaxLength(300)
                .HasColumnName("CPV_RAZONSOCIAL")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.CpvRut)
                .HasMaxLength(50)
                .HasColumnName("CPV_RUT")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.CpvTipo)
                .HasMaxLength(45)
                .HasColumnName("CPV_TIPO");
            entity.Property(e => e.Estado)
                .HasColumnType("int(11)")
                .HasColumnName("estado");
            entity.Property(e => e.FechaEntrada).HasColumnName("FECHA_ENTRADA");
            entity.Property(e => e.FechaSalida).HasColumnName("FECHA_SALIDA");
            entity.Property(e => e.FechaYhoraEntrada)
                .HasColumnType("datetime")
                .HasColumnName("FechaYHoraEntrada");
            entity.Property(e => e.FechaYhoraSalida).HasColumnType("datetime");
            entity.Property(e => e.FiltroSistema)
                .HasMaxLength(45)
                .HasColumnName("filtroSistema");
            entity.Property(e => e.Generador2)
                .HasMaxLength(45)
                .HasColumnName("GENERADOR2");
            entity.Property(e => e.GnrCodigo)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("GNR_CODIGO");
            entity.Property(e => e.GnrDireccion)
                .HasMaxLength(45)
                .HasColumnName("GNR_DIRECCION");
            entity.Property(e => e.GnrNombre)
                .HasMaxLength(300)
                .HasColumnName("GNR_NOMBRE");
            entity.Property(e => e.GnrRut)
                .HasMaxLength(45)
                .HasColumnName("GNR_RUT");
            entity.Property(e => e.HoraEntrada)
                .HasColumnType("time")
                .HasColumnName("HORA_ENTRADA");
            entity.Property(e => e.HoraSalida)
                .HasColumnType("time")
                .HasColumnName("HORA_SALIDA");
            entity.Property(e => e.IdOperadorEntrada)
                .HasMaxLength(100)
                .HasColumnName("ID_OPERADOR_ENTRADA");
            entity.Property(e => e.IdOperadorSalida)
                .HasMaxLength(100)
                .HasColumnName("ID_OPERADOR_SALIDA");
            entity.Property(e => e.IdSistema)
                .HasMaxLength(45)
                .HasColumnName("ID_SISTEMA");
            entity.Property(e => e.Iso14001)
                .HasMaxLength(45)
                .HasColumnName("ISO14001");
            entity.Property(e => e.NumSesma)
                .HasMaxLength(45)
                .HasColumnName("NUM_SESMA");
            entity.Property(e => e.ObservacionDeEntrada).HasColumnType("text");
            entity.Property(e => e.ObservacionDeSalida).HasColumnType("text");
            entity.Property(e => e.PesBruto)
                .HasColumnType("int(11)")
                .HasColumnName("PES_BRUTO");
            entity.Property(e => e.PesFecha)
                .HasMaxLength(45)
                .HasColumnName("PES_FECHA");
            entity.Property(e => e.PesFechaent)
                .HasMaxLength(45)
                .HasColumnName("PES_FECHAENT");
            entity.Property(e => e.PesFechasal)
                .HasMaxLength(45)
                .HasColumnName("PES_FECHASAL");
            entity.Property(e => e.PesHora)
                .HasMaxLength(45)
                .HasColumnName("PES_HORA");
            entity.Property(e => e.PesHoraent)
                .HasMaxLength(45)
                .HasColumnName("PES_HORAENT");
            entity.Property(e => e.PesHorasal)
                .HasMaxLength(45)
                .HasColumnName("PES_HORASAL");
            entity.Property(e => e.PesLavado)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("PES_LAVADO");
            entity.Property(e => e.PesNeto)
                .HasColumnType("int(11)")
                .HasColumnName("PES_NETO");
            entity.Property(e => e.PesNum)
                .HasColumnType("int(11)")
                .HasColumnName("PES_NUM");
            entity.Property(e => e.PesPermanencia)
                .HasMaxLength(10)
                .HasColumnName("PES_PERMANENCIA")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.PesTara)
                .HasColumnType("int(11)")
                .HasColumnName("PES_TARA");
            entity.Property(e => e.PesTon)
                .HasPrecision(14, 4)
                .HasColumnName("PES_TON");
            entity.Property(e => e.PesTramoHora)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("PES_TRAMO_HORA")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.PrdCodigo)
                .HasMaxLength(45)
                .HasColumnName("PRD_CODIGO");
            entity.Property(e => e.PrdDescripcion)
                .HasMaxLength(45)
                .HasColumnName("PRD_DESCRIPCION");
            entity.Property(e => e.TrnNombre)
                .HasMaxLength(300)
                .HasColumnName("TRN_NOMBRE");
            entity.Property(e => e.TrnRut)
                .HasMaxLength(45)
                .HasColumnName("TRN_RUT");
        });

        modelBuilder.Entity<Contactocliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("contactoclientes")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cargo)
                .HasMaxLength(100)
                .HasColumnName("cargo");
            entity.Property(e => e.Codarea)
                .HasMaxLength(100)
                .HasColumnName("codarea");
            entity.Property(e => e.DsClientesId)
                .HasColumnType("int(11)")
                .HasColumnName("ds_clientes_id");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasColumnType("int(1)")
                .HasColumnName("estado");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasColumnName("fax");
            entity.Property(e => e.Movil)
                .HasMaxLength(100)
                .HasColumnName("movil");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefonofijo)
                .HasMaxLength(100)
                .HasColumnName("telefonofijo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(100)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Detalleproducto>(entity =>
        {
            entity.HasKey(e => e.IdDetalleProducto).HasName("PRIMARY");

            entity
                .ToTable("detalleproducto")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.IdDetalleProducto, "IdDetalleProducto").IsUnique();

            entity.Property(e => e.IdDetalleProducto)
                .ValueGeneratedNever()
                .HasColumnType("int(11)");
            entity.Property(e => e.IdCliente).HasColumnType("int(11)");
            entity.Property(e => e.IdPersonal).HasColumnType("int(11)");
            entity.Property(e => e.IdPesaje)
                .HasColumnType("int(11)")
                .HasColumnName("idPesaje");
        });

        modelBuilder.Entity<Generadore>(entity =>
        {
            entity.HasKey(e => e.Idgeneradores).HasName("PRIMARY");

            entity.ToTable("generadores");

            entity.Property(e => e.Idgeneradores)
                .HasColumnType("int(11)")
                .HasColumnName("idgeneradores");
            entity.Property(e => e.Contacto).HasMaxLength(45);
            entity.Property(e => e.Direccion)
                .HasMaxLength(45)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(2)");
            entity.Property(e => e.Fonos)
                .HasMaxLength(45)
                .HasColumnName("fonos");
            entity.Property(e => e.IdClientes)
                .HasColumnType("int(11)")
                .HasColumnName("idClientes");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(300)
                .HasColumnName("razon social");
            entity.Property(e => e.Rut)
                .HasMaxLength(45)
                .HasColumnName("rut");
        });

        modelBuilder.Entity<Generadores2>(entity =>
        {
            entity.HasKey(e => e.Idgeneradores2).HasName("PRIMARY");

            entity.ToTable("generadores2");

            entity.Property(e => e.Idgeneradores2)
                .HasColumnType("int(11)")
                .HasColumnName("idgeneradores2");
            entity.Property(e => e.Contacto).HasMaxLength(45);
            entity.Property(e => e.Direccion)
                .HasMaxLength(45)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Estado).HasColumnType("int(2)");
            entity.Property(e => e.Fonos)
                .HasMaxLength(45)
                .HasColumnName("fonos");
            entity.Property(e => e.IdClientes)
                .HasColumnType("int(11)")
                .HasColumnName("idClientes");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(45)
                .HasColumnName("razon social");
            entity.Property(e => e.Rut)
                .HasMaxLength(45)
                .HasColumnName("rut");
        });

        modelBuilder.Entity<Gruposusuario>(entity =>
        {
            entity.HasKey(e => e.IdGruposUsuarios).HasName("PRIMARY");

            entity.ToTable("gruposusuarios");

            entity.Property(e => e.IdGruposUsuarios)
                .HasColumnType("int(11)")
                .HasColumnName("idGruposUsuarios");
            entity.Property(e => e.Estado).HasColumnType("tinyint(4)");
            entity.Property(e => e.GrupoUsuario)
                .HasMaxLength(100)
                .HasColumnName("Grupo Usuario");
        });

        modelBuilder.Entity<Impresora>(entity =>
        {
            entity.HasKey(e => e.Idimpresora).HasName("PRIMARY");

            entity.ToTable("impresora");

            entity.Property(e => e.Idimpresora)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("idimpresora");
            entity.Property(e => e.IdPrograma)
                .HasMaxLength(45)
                .HasColumnName("idPrograma");
            entity.Property(e => e.Ip)
                .HasMaxLength(45)
                .HasColumnName("IP");
            entity.Property(e => e.Nombre).HasMaxLength(45);
        });

        modelBuilder.Entity<Iso14001>(entity =>
        {
            entity.HasKey(e => e.Idiso14001).HasName("PRIMARY");

            entity.ToTable("iso14001");

            entity.Property(e => e.Idiso14001)
                .HasColumnType("int(11)")
                .HasColumnName("idiso14001");
            entity.Property(e => e.Estado).HasMaxLength(45);
            entity.Property(e => e.Motivo).HasMaxLength(45);
        });

        modelBuilder.Entity<Lavado>(entity =>
        {
            entity.HasKey(e => e.IdLavado).HasName("PRIMARY");

            entity.ToTable("lavado");

            entity.Property(e => e.IdLavado)
                .HasColumnType("int(11)")
                .HasColumnName("idLavado");
            entity.Property(e => e.FechaHoraIngreso)
                .HasMaxLength(45)
                .HasColumnName("fechaHoraIngreso");
            entity.Property(e => e.FolioPesaje).HasColumnType("int(11)");
            entity.Property(e => e.HoraSalida).HasMaxLength(45);
            entity.Property(e => e.IdConductor)
                .HasColumnType("int(11)")
                .HasColumnName("idConductor");
            entity.Property(e => e.IdGenerador).HasColumnType("int(11)");
            entity.Property(e => e.IdOperador)
                .HasColumnType("int(11)")
                .HasColumnName("idOperador");
            entity.Property(e => e.IdTransporte).HasColumnType("int(11)");
            entity.Property(e => e.Patente).HasMaxLength(10);
        });

        modelBuilder.Entity<Modificacionpesaje>(entity =>
        {
            entity.HasKey(e => e.Idmodificacionpesaje).HasName("PRIMARY");

            entity.ToTable("modificacionpesaje");

            entity.Property(e => e.Idmodificacionpesaje)
                .HasColumnType("int(11)")
                .HasColumnName("idmodificacionpesaje");
            entity.Property(e => e.AnuladoPor).HasColumnType("int(11)");
            entity.Property(e => e.DescIso14001)
                .HasMaxLength(100)
                .HasColumnName("DescISO14001");
            entity.Property(e => e.Estado).HasColumnType("int(11)");
            entity.Property(e => e.FechaEntrada).HasMaxLength(45);
            entity.Property(e => e.FechaModificacion).HasMaxLength(45);
            entity.Property(e => e.FechaSalida).HasMaxLength(45);
            entity.Property(e => e.FechaYhoraEntrada)
                .HasColumnType("datetime")
                .HasColumnName("FechaYHoraEntrada");
            entity.Property(e => e.FechaYhoraSalida).HasColumnType("datetime");
            entity.Property(e => e.HoraEntrada).HasMaxLength(45);
            entity.Property(e => e.HoraSalida).HasMaxLength(45);
            entity.Property(e => e.IdChofer).HasColumnType("int(11)");
            entity.Property(e => e.IdClienteProveedor).HasColumnType("int(11)");
            entity.Property(e => e.IdGenerador)
                .HasColumnType("int(11)")
                .HasColumnName("idGenerador");
            entity.Property(e => e.IdGenerador2)
                .HasColumnType("int(11)")
                .HasColumnName("idGenerador2");
            entity.Property(e => e.IdPatente).HasColumnType("int(11)");
            entity.Property(e => e.IdTipodeResiduo)
                .HasColumnType("int(11)")
                .HasColumnName("idTipodeResiduo");
            entity.Property(e => e.IdTransporte)
                .HasColumnType("int(11)")
                .HasColumnName("idTransporte");
            entity.Property(e => e.Idpesaje)
                .HasColumnType("int(11)")
                .HasColumnName("idpesaje");
            entity.Property(e => e.Impresora).HasMaxLength(45);
            entity.Property(e => e.Iso14001)
                .HasMaxLength(45)
                .HasColumnName("ISO14001");
            entity.Property(e => e.LavadoCamion).HasMaxLength(45);
            entity.Property(e => e.Memorandum).HasMaxLength(45);
            entity.Property(e => e.ModificadoPor).HasMaxLength(45);
            entity.Property(e => e.ObservacionDeEntrada).HasColumnType("text");
            entity.Property(e => e.ObservacionDeSalida).HasColumnType("text");
            entity.Property(e => e.PapeleraSesma).HasMaxLength(45);
            entity.Property(e => e.Patente).HasMaxLength(45);
            entity.Property(e => e.Personal).HasColumnType("int(11)");
            entity.Property(e => e.PersonalSalida).HasColumnType("int(11)");
            entity.Property(e => e.PesoEntrada).HasColumnType("int(11)");
            entity.Property(e => e.PesoNeto).HasColumnType("int(11)");
            entity.Property(e => e.PesoSalida).HasColumnType("int(11)");
            entity.Property(e => e.Planta)
                .HasColumnType("int(11)")
                .HasColumnName("PLANTA");
            entity.Property(e => e.TipoPesaje).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Modificacionpesajetransferencium>(entity =>
        {
            entity.HasKey(e => e.Idmodificacionpesaje).HasName("PRIMARY");

            entity.ToTable("modificacionpesajetransferencia");

            entity.Property(e => e.Idmodificacionpesaje)
                .HasColumnType("int(11)")
                .HasColumnName("idmodificacionpesaje");
            entity.Property(e => e.DescIso14001)
                .HasMaxLength(100)
                .HasColumnName("DescISO14001");
            entity.Property(e => e.EditadoPor).HasColumnType("int(11)");
            entity.Property(e => e.Estado).HasColumnType("int(11)");
            entity.Property(e => e.FechaEdicion).HasMaxLength(45);
            entity.Property(e => e.FechaYhoraEntradaEtps)
                .HasColumnType("datetime")
                .HasColumnName("FechaYHoraEntradaETPS");
            entity.Property(e => e.FechaYhoraEntradaRellEst)
                .HasColumnType("datetime")
                .HasColumnName("FechaYHoraEntradaRellEst");
            entity.Property(e => e.FechaYhoraSalidaEtps)
                .HasColumnType("datetime")
                .HasColumnName("FechaYhoraSalidaETPS");
            entity.Property(e => e.FechaYhoraSalidaRellEst).HasColumnType("datetime");
            entity.Property(e => e.FechaYhoraSalidaRelleno)
                .HasColumnType("datetime")
                .HasColumnName("FechaYHoraSalidaRelleno");
            entity.Property(e => e.FechaYhoraSalidaTransEst).HasColumnType("datetime");
            entity.Property(e => e.FechayHoraEntradaRelleno).HasColumnType("datetime");
            entity.Property(e => e.IdChofer).HasColumnType("int(11)");
            entity.Property(e => e.IdClienteProveedor).HasColumnType("int(11)");
            entity.Property(e => e.IdGenerador)
                .HasColumnType("int(11)")
                .HasColumnName("idGenerador");
            entity.Property(e => e.IdGenerador2)
                .HasColumnType("int(11)")
                .HasColumnName("idGenerador2");
            entity.Property(e => e.IdPatente).HasColumnType("int(11)");
            entity.Property(e => e.IdTipodeResiduo)
                .HasColumnType("int(11)")
                .HasColumnName("idTipodeResiduo");
            entity.Property(e => e.IdTransporte)
                .HasColumnType("int(11)")
                .HasColumnName("idTransporte");
            entity.Property(e => e.Impresora).HasMaxLength(45);
            entity.Property(e => e.Iso14001)
                .HasMaxLength(45)
                .HasColumnName("ISO14001");
            entity.Property(e => e.LavadoCamion).HasMaxLength(45);
            entity.Property(e => e.Memorandum).HasMaxLength(45);
            entity.Property(e => e.MotivoModificacion).HasMaxLength(500);
            entity.Property(e => e.ObservacionDeEntrada).HasColumnType("text");
            entity.Property(e => e.ObservacionDeSalida).HasColumnType("text");
            entity.Property(e => e.PapeleraSesma).HasMaxLength(45);
            entity.Property(e => e.Patente).HasMaxLength(45);
            entity.Property(e => e.Personal).HasColumnType("int(11)");
            entity.Property(e => e.PersonalSalida).HasColumnType("int(11)");
            entity.Property(e => e.PesoEntrada).HasColumnType("int(11)");
            entity.Property(e => e.PesoNeto).HasColumnType("int(11)");
            entity.Property(e => e.PesoSalida).HasColumnType("int(11)");
            entity.Property(e => e.Planta)
                .HasColumnType("int(11)")
                .HasColumnName("PLANTA");
            entity.Property(e => e.Rampla).HasMaxLength(45);
            entity.Property(e => e.Supervisor).HasMaxLength(45);
            entity.Property(e => e.TipoPesaje).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Patente>(entity =>
        {
            entity.HasKey(e => e.IdPatente).HasName("PRIMARY");

            entity
                .ToTable("patentes")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.IdPatente, "idCamion").IsUnique();

            entity.Property(e => e.IdPatente)
                .HasColumnType("int(11)")
                .HasColumnName("idPatente");
            entity.Property(e => e.CamionCsm)
                .HasColumnType("tinyint(4)")
                .HasColumnName("CamionCSM");
            entity.Property(e => e.CamionMulticliente).HasColumnType("tinyint(4)");
            entity.Property(e => e.CamionToleranca).HasColumnType("tinyint(4)");
            entity.Property(e => e.Estado).HasColumnType("int(11)");
            entity.Property(e => e.IdCliente).HasColumnType("int(11)");
            entity.Property(e => e.IdGeneradores)
                .HasColumnType("int(11)")
                .HasColumnName("idGeneradores");
            entity.Property(e => e.IdTransporte)
                .HasColumnType("int(11)")
                .HasColumnName("idTransporte");
            entity.Property(e => e.Largo)
                .HasMaxLength(45)
                .HasColumnName("largo");
            entity.Property(e => e.Numero)
                .HasMaxLength(45)
                .HasColumnName("numero");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Patente1)
                .HasMaxLength(45)
                .HasColumnName("Patente");
            entity.Property(e => e.Patentecarro)
                .HasMaxLength(45)
                .HasColumnName("patentecarro");
            entity.Property(e => e.Tara).HasColumnType("int(11)");
            entity.Property(e => e.Tipo).HasMaxLength(45);
            entity.Property(e => e.TransferenciaCliente)
                .HasMaxLength(45)
                .HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Patentecliente>(entity =>
        {
            entity.HasKey(e => e.IdPatenteCliente).HasName("PRIMARY");

            entity.ToTable("patentecliente");

            entity.Property(e => e.IdPatenteCliente)
                .HasColumnType("int(11)")
                .HasColumnName("idPatenteCliente");
            entity.Property(e => e.Estado)
                .HasMaxLength(45)
                .HasColumnName("estado");
            entity.Property(e => e.IdCliente).HasMaxLength(45);
            entity.Property(e => e.IdPatente)
                .HasMaxLength(45)
                .HasColumnName("idPAtente");
        });

        modelBuilder.Entity<Patenteclientetransferencium>(entity =>
        {
            entity.HasKey(e => e.IdPatenteCliente).HasName("PRIMARY");

            entity.ToTable("patenteclientetransferencia");

            entity.Property(e => e.IdPatenteCliente)
                .HasColumnType("int(11)")
                .HasColumnName("idPatenteCliente");
            entity.Property(e => e.Estado)
                .HasMaxLength(45)
                .HasColumnName("estado");
            entity.Property(e => e.IdCliente).HasMaxLength(45);
            entity.Property(e => e.IdPatente)
                .HasMaxLength(45)
                .HasColumnName("idPAtente");
        });

        modelBuilder.Entity<Patentememorandum>(entity =>
        {
            entity.HasKey(e => e.IdPatenteMemorandum).HasName("PRIMARY");

            entity.ToTable("patentememorandum");

            entity.Property(e => e.IdPatenteMemorandum)
                .HasColumnType("int(11)")
                .HasColumnName("idPatenteMemorandum");
            entity.Property(e => e.Estado).HasMaxLength(45);
            entity.Property(e => e.FechaEmision).HasMaxLength(45);
            entity.Property(e => e.FechaFin).HasMaxLength(45);
            entity.Property(e => e.FechaInicio).HasMaxLength(45);
            entity.Property(e => e.Folio).HasMaxLength(45);
            entity.Property(e => e.IdCliente)
                .HasColumnType("int(11)")
                .HasColumnName("idCliente");
            entity.Property(e => e.IdPatente).HasColumnType("int(11)");
            entity.Property(e => e.Nombre).HasMaxLength(45);
        });

        modelBuilder.Entity<Patentestransferencium>(entity =>
        {
            entity.HasKey(e => e.IdPatente).HasName("PRIMARY");

            entity
                .ToTable("patentestransferencia")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.IdPatente, "idCamion").IsUnique();

            entity.Property(e => e.IdPatente)
                .HasColumnType("int(11)")
                .HasColumnName("idPatente");
            entity.Property(e => e.CamionCsm)
                .HasColumnType("tinyint(4)")
                .HasColumnName("CamionCSM");
            entity.Property(e => e.CamionMulticliente).HasColumnType("tinyint(4)");
            entity.Property(e => e.CamionToleranca).HasColumnType("tinyint(4)");
            entity.Property(e => e.Estado).HasColumnType("int(11)");
            entity.Property(e => e.IdCliente).HasColumnType("int(11)");
            entity.Property(e => e.IdGeneradores)
                .HasColumnType("int(11)")
                .HasColumnName("idGeneradores");
            entity.Property(e => e.IdTransporte)
                .HasColumnType("int(11)")
                .HasColumnName("idTransporte");
            entity.Property(e => e.Largo)
                .HasMaxLength(45)
                .HasColumnName("largo");
            entity.Property(e => e.Numero)
                .HasMaxLength(45)
                .HasColumnName("numero");
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Patente).HasMaxLength(45);
            entity.Property(e => e.Patentecarro)
                .HasMaxLength(45)
                .HasColumnName("patentecarro");
            entity.Property(e => e.Tara).HasColumnType("int(11)");
            entity.Property(e => e.Tipo).HasMaxLength(45);
            entity.Property(e => e.TransferenciaCliente)
                .HasMaxLength(45)
                .HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Patentetransporte>(entity =>
        {
            entity.HasKey(e => e.IdPatenteTransporte).HasName("PRIMARY");

            entity.ToTable("patentetransporte");

            entity.Property(e => e.IdPatenteTransporte)
                .HasColumnType("int(11)")
                .HasColumnName("idPatenteTransporte");
            entity.Property(e => e.Estado)
                .HasMaxLength(45)
                .HasColumnName("estado");
            entity.Property(e => e.IdPatente)
                .HasMaxLength(45)
                .HasColumnName("idPAtente");
            entity.Property(e => e.IdTransporte)
                .HasMaxLength(45)
                .HasColumnName("idTransporte");
        });

        modelBuilder.Entity<Pesaje>(entity =>
        {
            entity.HasKey(e => e.IdPesaje).HasName("PRIMARY");

            entity.ToTable("pesaje");

            entity.Property(e => e.IdPesaje)
                .HasColumnType("int(11)")
                .HasColumnName("idPesaje");
            entity.Property(e => e.AnuladoPor).HasColumnType("int(11)");
            entity.Property(e => e.DescIso14001)
                .HasMaxLength(100)
                .HasColumnName("DescISO14001");
            entity.Property(e => e.Estado).HasColumnType("int(11)");
            entity.Property(e => e.FechaEntrada).HasMaxLength(45);
            entity.Property(e => e.FechaSalida).HasMaxLength(45);
            entity.Property(e => e.FechaYhoraEntrada)
                .HasColumnType("datetime")
                .HasColumnName("FechaYHoraEntrada");
            entity.Property(e => e.FechaYhoraSalida).HasColumnType("datetime");
            entity.Property(e => e.HoraEntrada).HasMaxLength(45);
            entity.Property(e => e.HoraSalida).HasMaxLength(45);
            entity.Property(e => e.IdChofer).HasColumnType("int(11)");
            entity.Property(e => e.IdClienteProveedor).HasColumnType("int(11)");
            entity.Property(e => e.IdGenerador)
                .HasColumnType("int(11)")
                .HasColumnName("idGenerador");
            entity.Property(e => e.IdGenerador2)
                .HasColumnType("int(11)")
                .HasColumnName("idGenerador2");
            entity.Property(e => e.IdPatente).HasColumnType("int(11)");
            entity.Property(e => e.IdTipodeResiduo)
                .HasColumnType("int(11)")
                .HasColumnName("idTipodeResiduo");
            entity.Property(e => e.IdTransporte)
                .HasColumnType("int(11)")
                .HasColumnName("idTransporte");
            entity.Property(e => e.Impresora).HasMaxLength(45);
            entity.Property(e => e.Iso14001)
                .HasMaxLength(45)
                .HasColumnName("ISO14001");
            entity.Property(e => e.LavadoCamion).HasMaxLength(45);
            entity.Property(e => e.Memorandum).HasMaxLength(45);
            entity.Property(e => e.ObservacionDeEntrada).HasColumnType("text");
            entity.Property(e => e.ObservacionDeSalida).HasColumnType("text");
            entity.Property(e => e.PapeleraSesma).HasMaxLength(45);
            entity.Property(e => e.Patente).HasMaxLength(45);
            entity.Property(e => e.Personal).HasColumnType("int(11)");
            entity.Property(e => e.PersonalSalida).HasColumnType("int(11)");
            entity.Property(e => e.PesoEntrada).HasColumnType("int(11)");
            entity.Property(e => e.PesoNeto).HasColumnType("int(11)");
            entity.Property(e => e.PesoSalida).HasColumnType("int(11)");
            entity.Property(e => e.Planta)
                .HasColumnType("int(11)")
                .HasColumnName("PLANTA");
            entity.Property(e => e.TipoPesaje).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Pesajetransferencium>(entity =>
        {
            entity.HasKey(e => e.IdPesaje).HasName("PRIMARY");

            entity.ToTable("pesajetransferencia");

            entity.Property(e => e.IdPesaje)
                .HasColumnType("int(11)")
                .HasColumnName("idPesaje");
            entity.Property(e => e.DescIso14001)
                .HasMaxLength(100)
                .HasColumnName("DescISO14001");
            entity.Property(e => e.Estado).HasColumnType("int(11)");
            entity.Property(e => e.FechaYhoraEntradaEtps)
                .HasColumnType("datetime")
                .HasColumnName("FechaYHoraEntradaETPS");
            entity.Property(e => e.FechaYhoraEntradaRellEst)
                .HasColumnType("datetime")
                .HasColumnName("FechaYHoraEntradaRellEst");
            entity.Property(e => e.FechaYhoraSalidaEtps)
                .HasColumnType("datetime")
                .HasColumnName("FechaYhoraSalidaETPS");
            entity.Property(e => e.FechaYhoraSalidaRellEst).HasColumnType("datetime");
            entity.Property(e => e.FechaYhoraSalidaRelleno)
                .HasColumnType("datetime")
                .HasColumnName("FechaYHoraSalidaRelleno");
            entity.Property(e => e.FechaYhoraSalidaTransEst).HasColumnType("datetime");
            entity.Property(e => e.FechayHoraEntradaRelleno).HasColumnType("datetime");
            entity.Property(e => e.IdChofer).HasColumnType("int(11)");
            entity.Property(e => e.IdClienteProveedor).HasColumnType("int(11)");
            entity.Property(e => e.IdGenerador)
                .HasColumnType("int(11)")
                .HasColumnName("idGenerador");
            entity.Property(e => e.IdGenerador2)
                .HasColumnType("int(11)")
                .HasColumnName("idGenerador2");
            entity.Property(e => e.IdPatente).HasColumnType("int(11)");
            entity.Property(e => e.IdTipodeResiduo)
                .HasColumnType("int(11)")
                .HasColumnName("idTipodeResiduo");
            entity.Property(e => e.IdTransporte)
                .HasColumnType("int(11)")
                .HasColumnName("idTransporte");
            entity.Property(e => e.Impresora).HasMaxLength(45);
            entity.Property(e => e.Iso14001)
                .HasMaxLength(45)
                .HasColumnName("ISO14001");
            entity.Property(e => e.LavadoCamion).HasMaxLength(45);
            entity.Property(e => e.Memorandum).HasMaxLength(45);
            entity.Property(e => e.ObservacionDeEntrada).HasColumnType("text");
            entity.Property(e => e.ObservacionDeSalida).HasColumnType("text");
            entity.Property(e => e.PapeleraSesma).HasMaxLength(45);
            entity.Property(e => e.Patente).HasMaxLength(45);
            entity.Property(e => e.Personal).HasColumnType("int(11)");
            entity.Property(e => e.PersonalSalida).HasColumnType("int(11)");
            entity.Property(e => e.PesoEntrada).HasColumnType("int(11)");
            entity.Property(e => e.PesoNeto).HasColumnType("int(11)");
            entity.Property(e => e.PesoSalida).HasColumnType("int(11)");
            entity.Property(e => e.Planta)
                .HasColumnType("int(11)")
                .HasColumnName("PLANTA");
            entity.Property(e => e.Rampla).HasMaxLength(45);
            entity.Property(e => e.Supervisor).HasMaxLength(45);
            entity.Property(e => e.TipoPesaje).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Planta>(entity =>
        {
            entity.HasKey(e => e.IdPlantas).HasName("PRIMARY");

            entity.ToTable("plantas");

            entity.Property(e => e.IdPlantas)
                .HasColumnType("int(11)")
                .HasColumnName("idPlantas");
            entity.Property(e => e.NombrePlanta).HasMaxLength(45);
        });

        modelBuilder.Entity<Plantasprog>(entity =>
        {
            entity.HasKey(e => e.IdPlantasProg).HasName("PRIMARY");

            entity.ToTable("plantasprog");

            entity.Property(e => e.IdPlantasProg)
                .HasColumnType("int(11)")
                .HasColumnName("idPlantasProg");
            entity.Property(e => e.IdPlanta)
                .HasMaxLength(45)
                .HasColumnName("idPlanta");
            entity.Property(e => e.IdPrograma)
                .HasMaxLength(45)
                .HasColumnName("idPrograma");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Idproducto).HasName("PRIMARY");

            entity
                .ToTable("producto")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Idproducto, "idproducto").IsUnique();

            entity.Property(e => e.Idproducto)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("idproducto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .HasColumnName("descripcion");
            entity.Property(e => e.Producto1)
                .HasMaxLength(100)
                .HasColumnName("Producto");
        });

        modelBuilder.Entity<Rampla>(entity =>
        {
            entity.HasKey(e => e.IdRampla).HasName("PRIMARY");

            entity.ToTable("rampla");

            entity.HasIndex(e => e.Rampla1, "Rampla_UNIQUE").IsUnique();

            entity.Property(e => e.IdRampla)
                .HasColumnType("int(11)")
                .HasColumnName("idRampla");
            entity.Property(e => e.Estado).HasMaxLength(45);
            entity.Property(e => e.Rampla1)
                .HasMaxLength(45)
                .HasColumnName("Rampla");
        });

        modelBuilder.Entity<Regione>(entity =>
        {
            entity.HasKey(e => e.IdRegion).HasName("PRIMARY");

            entity
                .ToTable("regiones")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.IdRegion)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id_Region");
            entity.Property(e => e.Region).HasMaxLength(100);
        });

        modelBuilder.Entity<Residuo>(entity =>
        {
            entity.HasKey(e => e.IdResiduos).HasName("PRIMARY");

            entity.ToTable("residuos");

            entity.HasIndex(e => e.IdResiduos, "idResiduos_UNIQUE").IsUnique();

            entity.Property(e => e.IdResiduos)
                .HasColumnType("int(11)")
                .HasColumnName("idResiduos");
            entity.Property(e => e.Codigo).HasMaxLength(45);
            entity.Property(e => e.Descripcion).HasMaxLength(45);
            entity.Property(e => e.Estado).HasColumnType("int(11)");
            entity.Property(e => e.Guia).HasMaxLength(45);
        });

        modelBuilder.Entity<Serial>(entity =>
        {
            entity.HasKey(e => e.IdSerial).HasName("PRIMARY");

            entity.ToTable("serial");

            entity.Property(e => e.IdSerial)
                .HasColumnType("int(11)")
                .HasColumnName("idSerial");
            entity.Property(e => e.Comm).HasMaxLength(45);
            entity.Property(e => e.FinString).HasColumnType("int(11)");
            entity.Property(e => e.IdPc)
                .HasMaxLength(100)
                .HasColumnName("IdPC");
            entity.Property(e => e.Indicador)
                .HasMaxLength(100)
                .HasColumnName("indicador");
            entity.Property(e => e.InicioString).HasColumnType("int(11)");
            entity.Property(e => e.LargoString).HasColumnType("int(11)");
            entity.Property(e => e.Marca)
                .HasMaxLength(100)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .HasColumnName("modelo");
            entity.Property(e => e.Observacion).HasColumnType("text");
            entity.Property(e => e.Serie).HasMaxLength(100);
        });

        modelBuilder.Entity<Supervisore>(entity =>
        {
            entity.HasKey(e => e.IdSupervisores).HasName("PRIMARY");

            entity.ToTable("supervisores");

            entity.HasIndex(e => e.Supervisor, "Supervisor_UNIQUE").IsUnique();

            entity.Property(e => e.IdSupervisores)
                .HasColumnType("int(11)")
                .HasColumnName("idSupervisores");
            entity.Property(e => e.Estado).HasMaxLength(45);
            entity.Property(e => e.Supervisor).HasMaxLength(200);
        });

        modelBuilder.Entity<Tipocliente>(entity =>
        {
            entity.HasKey(e => e.IdTipoCliente).HasName("PRIMARY");

            entity.ToTable("tipocliente");

            entity.Property(e => e.IdTipoCliente)
                .HasColumnType("int(11)")
                .HasColumnName("idTipoCliente");
            entity.Property(e => e.ClieProv).HasColumnType("int(11)");
            entity.Property(e => e.Estado)
                .HasMaxLength(45)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre).HasMaxLength(45);
        });

        modelBuilder.Entity<Transferencium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("transferencia");

            entity.Property(e => e.CamNumero)
                .HasMaxLength(45)
                .HasColumnName("CAM_NUMERO")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.CamPatente)
                .HasMaxLength(45)
                .HasColumnName("CAM_PATENTE");
            entity.Property(e => e.ChfCodigo)
                .HasColumnType("int(11)")
                .HasColumnName("CHF_CODIGO");
            entity.Property(e => e.ChfNombre)
                .HasMaxLength(200)
                .HasColumnName("CHF_NOMBRE")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.ChfRut)
                .HasMaxLength(45)
                .HasColumnName("CHF_RUT")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.CpvRazonsocial)
                .HasMaxLength(300)
                .HasColumnName("CPV_RAZONSOCIAL")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.CpvRut)
                .HasMaxLength(50)
                .HasColumnName("CPV_RUT")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.CpvTipo)
                .HasMaxLength(100)
                .HasColumnName("CPV_TIPO")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.GnrCodigo)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("GNR_CODIGO");
            entity.Property(e => e.GnrDireccion)
                .HasMaxLength(45)
                .HasColumnName("GNR_DIRECCION");
            entity.Property(e => e.GnrNombre)
                .HasMaxLength(300)
                .HasColumnName("GNR_NOMBRE");
            entity.Property(e => e.GnrRut)
                .HasMaxLength(45)
                .HasColumnName("GNR_RUT");
            entity.Property(e => e.Hora1)
                .HasMaxLength(9)
                .HasColumnName("HORA1")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.Hora2)
                .HasMaxLength(9)
                .HasColumnName("HORA2")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.Hora3)
                .HasMaxLength(9)
                .HasColumnName("HORA3")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.Hora4)
                .HasMaxLength(9)
                .HasColumnName("HORA4")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.IdOperadorEntrada)
                .HasMaxLength(100)
                .HasColumnName("ID_OPERADOR_ENTRADA");
            entity.Property(e => e.IdOperadorSalida)
                .HasMaxLength(100)
                .HasColumnName("ID_OPERADOR_SALIDA");
            entity.Property(e => e.IdSistema)
                .HasColumnType("int(11)")
                .HasColumnName("ID_SISTEMA");
            entity.Property(e => e.NumSesma)
                .HasMaxLength(45)
                .HasColumnName("NUM_SESMA");
            entity.Property(e => e.ObservacionDeEntrada).HasColumnType("text");
            entity.Property(e => e.PesBruto)
                .HasColumnType("int(11)")
                .HasColumnName("PES_BRUTO");
            entity.Property(e => e.PesFechaHora)
                .HasColumnType("datetime")
                .HasColumnName("PES_FECHA_HORA");
            entity.Property(e => e.PesFechaentrada)
                .HasMaxLength(11)
                .HasColumnName("PES_FECHAENTRADA")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.PesFechasalida)
                .HasMaxLength(11)
                .HasColumnName("PES_FECHASALIDA")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.PesHoraentrada)
                .HasMaxLength(9)
                .HasColumnName("PES_HORAENTRADA")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.PesHorasalida)
                .HasMaxLength(9)
                .HasColumnName("PES_HORASALIDA")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.PesNeto)
                .HasColumnType("int(11)")
                .HasColumnName("PES_NETO");
            entity.Property(e => e.PesNum)
                .HasColumnType("int(11)")
                .HasColumnName("PES_NUM");
            entity.Property(e => e.PesPermanencia)
                .HasColumnType("time")
                .HasColumnName("PES_PERMANENCIA");
            entity.Property(e => e.PesTara)
                .HasColumnType("int(11)")
                .HasColumnName("PES_TARA");
            entity.Property(e => e.PesTon)
                .HasPrecision(14, 4)
                .HasColumnName("PES_TON");
            entity.Property(e => e.PrdCodigo)
                .HasColumnType("int(11)")
                .HasColumnName("PRD_CODIGO");
            entity.Property(e => e.PrdDescripcion)
                .HasMaxLength(100)
                .HasColumnName("PRD_DESCRIPCION")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Rampla)
                .HasMaxLength(45)
                .HasColumnName("RAMPLA");
            entity.Property(e => e.SupNombre)
                .HasMaxLength(45)
                .HasColumnName("SUP_NOMBRE");
            entity.Property(e => e.TrnNombre)
                .HasMaxLength(300)
                .HasColumnName("TRN_NOMBRE");
            entity.Property(e => e.TrnRut)
                .HasMaxLength(45)
                .HasColumnName("TRN_RUT");
        });

        modelBuilder.Entity<Transporte>(entity =>
        {
            entity.HasKey(e => e.IdTransportes).HasName("PRIMARY");

            entity.ToTable("transportes");

            entity.Property(e => e.IdTransportes)
                .HasColumnType("int(11)")
                .HasColumnName("idTransportes");
            entity.Property(e => e.Contacto).HasMaxLength(45);
            entity.Property(e => e.Direccion)
                .HasMaxLength(45)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Estado).HasColumnType("int(2)");
            entity.Property(e => e.Fonos)
                .HasMaxLength(45)
                .HasColumnName("fonos");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(300)
                .HasColumnName("razonSocial");
            entity.Property(e => e.Rut)
                .HasMaxLength(45)
                .HasColumnName("rut");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuarios).HasName("PRIMARY");

            entity.ToTable("usuarios");

            entity.Property(e => e.IdUsuarios)
                .HasColumnType("int(11)")
                .HasColumnName("idUsuarios");
            entity.Property(e => e.Clave).HasMaxLength(100);
            entity.Property(e => e.Estado).HasColumnType("tinyint(4)");
            entity.Property(e => e.IdGrupoUsuario)
                .HasColumnType("int(11)")
                .HasColumnName("idGrupoUsuario");
            entity.Property(e => e.NombreUsuario).HasMaxLength(100);
        });

        modelBuilder.Entity<Vistalavado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vistalavado");

            entity.Property(e => e.CamNumero)
                .HasMaxLength(10)
                .HasColumnName("CAM_NUMERO");
            entity.Property(e => e.ChfNombre)
                .HasMaxLength(200)
                .HasColumnName("CHF_NOMBRE")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.CpvRazonsocial)
                .HasMaxLength(300)
                .HasColumnName("CPV_RAZONSOCIAL")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.LavFechaIng)
                .HasMaxLength(45)
                .HasColumnName("LAV_FECHA_ING");
            entity.Property(e => e.LavFechaSal)
                .HasMaxLength(45)
                .HasColumnName("LAV_FECHA_SAL");
            entity.Property(e => e.LavNum)
                .HasColumnType("int(11)")
                .HasColumnName("LAV_NUM");
            entity.Property(e => e.PesNum)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("PES_NUM");
            entity.Property(e => e.TrnNombre)
                .HasMaxLength(300)
                .HasColumnName("TRN_NOMBRE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
