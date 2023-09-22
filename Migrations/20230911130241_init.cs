using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sism.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8");

            migrationBuilder.CreateTable(
                name: "accesos",
                columns: table => new
                {
                    idaccesos = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdGrupoDeUsuarios = table.Column<int>(type: "int(11)", nullable: true),
                    MOP = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Archivos = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    ClienteProveedor = table.Column<sbyte>(name: "Cliente/Proveedor", type: "tinyint(4)", nullable: true),
                    IngresoDe = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    IngresoDeTipos = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    AdministracionDeValoers = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Camiones = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Generadores = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Transportes = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Conductores = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    TiposResiduos = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    SupervisoresyRamplas = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Usuarios = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    ConexionServidor = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    ParametrosDinamicos = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Pesaje = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    PesajeComercial = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    ReimpresionTicketMOP = table.Column<sbyte>(name: "ReimpresionTicket MOP", type: "tinyint(4)", nullable: true),
                    ReimpresionTickets = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Modificacion = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    ListadoModificacion = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Transferencia = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    PesajeTrasferencia = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    ControlItinerario = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    ControlHorario = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    ControlTransferencia = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Informes = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    TipoResiduo = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    ClienteProveedor0 = table.Column<sbyte>(name: "ClienteProveedor", type: "tinyint(4)", nullable: true),
                    Camion = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    InformeIngresos = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    PesajePorHora = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    PermanenciaEnPlanta = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    pesajetransferencia = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    informeGeneralDeTickets = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    estado = table.Column<sbyte>(type: "tinyint(4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idaccesos);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "cargos",
                columns: table => new
                {
                    idCargos = table.Column<int>(type: "int(11)", nullable: false),
                    Cargos = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Area = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idCargos);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish_ci");

            migrationBuilder.CreateTable(
                name: "chofer",
                columns: table => new
                {
                    idchofer = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Transporte = table.Column<int>(type: "int(11)", nullable: true),
                    Rut = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Nombre = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Direccion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Fonos = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    estado = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idchofer);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");

            migrationBuilder.CreateTable(
                name: "clientegenerador",
                columns: table => new
                {
                    idClienteGenerador = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idGenerador = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    idCliente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    estado = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idClienteGenerador);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rut = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    razonsocial = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    ClienteProveedor = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    TipoCliente = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    giro = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    direccionfactura = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    comuna = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    ciudad = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    region = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    telefono = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    fax = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    casilla = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    lineadecredito = table.Column<string>(name: "linea de credito", type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    estado = table.Column<int>(type: "int(1)", nullable: true),
                    FechaPermitidaInicio = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    FechaPermitidaFin = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");

            migrationBuilder.CreateTable(
                name: "comuna",
                columns: table => new
                {
                    idComuna = table.Column<int>(type: "int(11)", nullable: false),
                    Comuna = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    idRegion = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idComuna);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "contactoclientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ds_clientes_id = table.Column<int>(type: "int(11)", nullable: false),
                    tipo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    nombre = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    cargo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    email = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    codarea = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    telefonofijo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    fax = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    movil = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    estado = table.Column<int>(type: "int(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");

            migrationBuilder.CreateTable(
                name: "detalleproducto",
                columns: table => new
                {
                    IdDetalleProducto = table.Column<int>(type: "int(11)", nullable: false),
                    IdCliente = table.Column<int>(type: "int(11)", nullable: false),
                    IdPersonal = table.Column<int>(type: "int(11)", nullable: false),
                    idPesaje = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.IdDetalleProducto);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");

            migrationBuilder.CreateTable(
                name: "generadores",
                columns: table => new
                {
                    idgeneradores = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rut = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    razonsocial = table.Column<string>(name: "razon social", type: "varchar(300)", maxLength: 300, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    direccion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    fonos = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Contacto = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'1'"),
                    idClientes = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idgeneradores);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "generadores2",
                columns: table => new
                {
                    idgeneradores2 = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rut = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    razonsocial = table.Column<string>(name: "razon social", type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    direccion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    fonos = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Contacto = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<int>(type: "int(2)", nullable: true),
                    idClientes = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idgeneradores2);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "gruposusuarios",
                columns: table => new
                {
                    idGruposUsuarios = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GrupoUsuario = table.Column<string>(name: "Grupo Usuario", type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<sbyte>(type: "tinyint(4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idGruposUsuarios);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "impresora",
                columns: table => new
                {
                    idimpresora = table.Column<int>(type: "int(11)", nullable: false),
                    IP = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    idPrograma = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idimpresora);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "iso14001",
                columns: table => new
                {
                    idiso14001 = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Motivo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idiso14001);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "lavado",
                columns: table => new
                {
                    idLavado = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Patente = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    IdTransporte = table.Column<int>(type: "int(11)", nullable: true),
                    IdGenerador = table.Column<int>(type: "int(11)", nullable: true),
                    idConductor = table.Column<int>(type: "int(11)", nullable: true),
                    idOperador = table.Column<int>(type: "int(11)", nullable: true),
                    FolioPesaje = table.Column<int>(type: "int(11)", nullable: true),
                    fechaHoraIngreso = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    HoraSalida = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idLavado);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "modificacionpesaje",
                columns: table => new
                {
                    idmodificacionpesaje = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPatente = table.Column<int>(type: "int(11)", nullable: true),
                    IdClienteProveedor = table.Column<int>(type: "int(11)", nullable: true),
                    idGenerador = table.Column<int>(type: "int(11)", nullable: true),
                    idGenerador2 = table.Column<int>(type: "int(11)", nullable: true),
                    idTipodeResiduo = table.Column<int>(type: "int(11)", nullable: true),
                    idTransporte = table.Column<int>(type: "int(11)", nullable: true),
                    IdChofer = table.Column<int>(type: "int(11)", nullable: true),
                    ObservacionDeEntrada = table.Column<string>(type: "text", nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ObservacionDeSalida = table.Column<string>(type: "text", nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Memorandum = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PesoEntrada = table.Column<int>(type: "int(11)", nullable: true),
                    PesoSalida = table.Column<int>(type: "int(11)", nullable: true),
                    PesoNeto = table.Column<int>(type: "int(11)", nullable: true),
                    Impresora = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    LavadoCamion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ISO14001 = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    TipoPesaje = table.Column<int>(type: "int(11)", nullable: true),
                    HoraEntrada = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    HoraSalida = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Patente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PapeleraSesma = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<int>(type: "int(11)", nullable: true),
                    Personal = table.Column<int>(type: "int(11)", nullable: true),
                    PersonalSalida = table.Column<int>(type: "int(11)", nullable: true),
                    DescISO14001 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    FechaEntrada = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    FechaSalida = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    FechaYHoraEntrada = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYhoraSalida = table.Column<DateTime>(type: "datetime", nullable: true),
                    PLANTA = table.Column<int>(type: "int(11)", nullable: true),
                    AnuladoPor = table.Column<int>(type: "int(11)", nullable: true),
                    ModificadoPor = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    FechaModificacion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    idpesaje = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idmodificacionpesaje);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "modificacionpesajetransferencia",
                columns: table => new
                {
                    idmodificacionpesaje = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPatente = table.Column<int>(type: "int(11)", nullable: true),
                    IdClienteProveedor = table.Column<int>(type: "int(11)", nullable: true),
                    idGenerador = table.Column<int>(type: "int(11)", nullable: true),
                    idGenerador2 = table.Column<int>(type: "int(11)", nullable: true),
                    idTipodeResiduo = table.Column<int>(type: "int(11)", nullable: true),
                    idTransporte = table.Column<int>(type: "int(11)", nullable: true),
                    IdChofer = table.Column<int>(type: "int(11)", nullable: true),
                    ObservacionDeEntrada = table.Column<string>(type: "text", nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ObservacionDeSalida = table.Column<string>(type: "text", nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Memorandum = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PesoEntrada = table.Column<int>(type: "int(11)", nullable: true),
                    PesoSalida = table.Column<int>(type: "int(11)", nullable: true),
                    PesoNeto = table.Column<int>(type: "int(11)", nullable: true),
                    Impresora = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    LavadoCamion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ISO14001 = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    TipoPesaje = table.Column<int>(type: "int(11)", nullable: true),
                    Patente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PapeleraSesma = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<int>(type: "int(11)", nullable: true),
                    Personal = table.Column<int>(type: "int(11)", nullable: true),
                    PersonalSalida = table.Column<int>(type: "int(11)", nullable: true),
                    DescISO14001 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PLANTA = table.Column<int>(type: "int(11)", nullable: true),
                    FechaYhoraSalidaETPS = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechayHoraEntradaRelleno = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYHoraSalidaRelleno = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYHoraEntradaETPS = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYHoraEntradaRellEst = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYhoraSalidaRellEst = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYhoraSalidaTransEst = table.Column<DateTime>(type: "datetime", nullable: true),
                    Rampla = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Supervisor = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    FechaEdicion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    MotivoModificacion = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    EditadoPor = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idmodificacionpesaje);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "patentecliente",
                columns: table => new
                {
                    idPatenteCliente = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idPAtente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    IdCliente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    estado = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPatenteCliente);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "patenteclientetransferencia",
                columns: table => new
                {
                    idPatenteCliente = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idPAtente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    IdCliente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    estado = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPatenteCliente);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "patentememorandum",
                columns: table => new
                {
                    idPatenteMemorandum = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPatente = table.Column<int>(type: "int(11)", nullable: true),
                    idCliente = table.Column<int>(type: "int(11)", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Folio = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    FechaEmision = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    FechaInicio = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    FechaFin = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPatenteMemorandum);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "patentes",
                columns: table => new
                {
                    idPatente = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(type: "int(11)", nullable: true),
                    idGeneradores = table.Column<int>(type: "int(11)", nullable: true),
                    idTransporte = table.Column<int>(type: "int(11)", nullable: false),
                    Patente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    numero = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    patentecarro = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Tipo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Tara = table.Column<int>(type: "int(11)", nullable: true),
                    largo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    CamionCSM = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    CamionMulticliente = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    CamionToleranca = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Observaciones = table.Column<string>(type: "text", nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Estado = table.Column<int>(type: "int(11)", nullable: true),
                    TransferenciaCliente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, defaultValueSql: "'0'", collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPatente);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");

            migrationBuilder.CreateTable(
                name: "patentestransferencia",
                columns: table => new
                {
                    idPatente = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(type: "int(11)", nullable: true),
                    idGeneradores = table.Column<int>(type: "int(11)", nullable: true),
                    idTransporte = table.Column<int>(type: "int(11)", nullable: false),
                    Patente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    numero = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    patentecarro = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Tipo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Tara = table.Column<int>(type: "int(11)", nullable: true),
                    largo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    CamionCSM = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    CamionMulticliente = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    CamionToleranca = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    Observaciones = table.Column<string>(type: "text", nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Estado = table.Column<int>(type: "int(11)", nullable: true),
                    TransferenciaCliente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, defaultValueSql: "'0'", collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPatente);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");

            migrationBuilder.CreateTable(
                name: "patentetransporte",
                columns: table => new
                {
                    idPatenteTransporte = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idPAtente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    idTransporte = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    estado = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPatenteTransporte);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "pesaje",
                columns: table => new
                {
                    idPesaje = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPatente = table.Column<int>(type: "int(11)", nullable: true),
                    IdClienteProveedor = table.Column<int>(type: "int(11)", nullable: true),
                    idGenerador = table.Column<int>(type: "int(11)", nullable: true),
                    idGenerador2 = table.Column<int>(type: "int(11)", nullable: true),
                    idTipodeResiduo = table.Column<int>(type: "int(11)", nullable: true),
                    idTransporte = table.Column<int>(type: "int(11)", nullable: true),
                    IdChofer = table.Column<int>(type: "int(11)", nullable: true),
                    ObservacionDeEntrada = table.Column<string>(type: "text", nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ObservacionDeSalida = table.Column<string>(type: "text", nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Memorandum = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PesoEntrada = table.Column<int>(type: "int(11)", nullable: true),
                    PesoSalida = table.Column<int>(type: "int(11)", nullable: true),
                    PesoNeto = table.Column<int>(type: "int(11)", nullable: true),
                    Impresora = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    LavadoCamion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ISO14001 = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    TipoPesaje = table.Column<int>(type: "int(11)", nullable: true),
                    HoraEntrada = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    HoraSalida = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Patente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PapeleraSesma = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<int>(type: "int(11)", nullable: true),
                    Personal = table.Column<int>(type: "int(11)", nullable: true),
                    PersonalSalida = table.Column<int>(type: "int(11)", nullable: true),
                    DescISO14001 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    FechaEntrada = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    FechaSalida = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    FechaYHoraEntrada = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYhoraSalida = table.Column<DateTime>(type: "datetime", nullable: true),
                    PLANTA = table.Column<int>(type: "int(11)", nullable: true),
                    AnuladoPor = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPesaje);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "pesajetransferencia",
                columns: table => new
                {
                    idPesaje = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPatente = table.Column<int>(type: "int(11)", nullable: true),
                    IdClienteProveedor = table.Column<int>(type: "int(11)", nullable: true),
                    idGenerador = table.Column<int>(type: "int(11)", nullable: true),
                    idGenerador2 = table.Column<int>(type: "int(11)", nullable: true),
                    idTipodeResiduo = table.Column<int>(type: "int(11)", nullable: true),
                    idTransporte = table.Column<int>(type: "int(11)", nullable: true),
                    IdChofer = table.Column<int>(type: "int(11)", nullable: true),
                    ObservacionDeEntrada = table.Column<string>(type: "text", nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ObservacionDeSalida = table.Column<string>(type: "text", nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Memorandum = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PesoEntrada = table.Column<int>(type: "int(11)", nullable: true),
                    PesoSalida = table.Column<int>(type: "int(11)", nullable: true),
                    PesoNeto = table.Column<int>(type: "int(11)", nullable: true),
                    Impresora = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    LavadoCamion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ISO14001 = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    TipoPesaje = table.Column<int>(type: "int(11)", nullable: true),
                    Patente = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PapeleraSesma = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<int>(type: "int(11)", nullable: true),
                    Personal = table.Column<int>(type: "int(11)", nullable: true),
                    PersonalSalida = table.Column<int>(type: "int(11)", nullable: true),
                    DescISO14001 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    PLANTA = table.Column<int>(type: "int(11)", nullable: true),
                    FechaYhoraSalidaETPS = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechayHoraEntradaRelleno = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYHoraSalidaRelleno = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYHoraEntradaETPS = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYHoraEntradaRellEst = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYhoraSalidaRellEst = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaYhoraSalidaTransEst = table.Column<DateTime>(type: "datetime", nullable: true),
                    Rampla = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Supervisor = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPesaje);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "plantas",
                columns: table => new
                {
                    idPlantas = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombrePlanta = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPlantas);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "plantasprog",
                columns: table => new
                {
                    idPlantasProg = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idPlanta = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    idPrograma = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPlantasProg);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    idproducto = table.Column<int>(type: "int(11)", nullable: false),
                    Producto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    descripcion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idproducto);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");

            migrationBuilder.CreateTable(
                name: "rampla",
                columns: table => new
                {
                    idRampla = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rampla = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idRampla);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "regiones",
                columns: table => new
                {
                    id_Region = table.Column<int>(type: "int(11)", nullable: false),
                    Region = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_Region);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "residuos",
                columns: table => new
                {
                    idResiduos = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Descripcion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Guia = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idResiduos);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "serial",
                columns: table => new
                {
                    idSerial = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LargoString = table.Column<int>(type: "int(11)", nullable: true),
                    InicioString = table.Column<int>(type: "int(11)", nullable: true),
                    FinString = table.Column<int>(type: "int(11)", nullable: true),
                    Comm = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    indicador = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Serie = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    marca = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    modelo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Observacion = table.Column<string>(type: "text", nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    IdPC = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idSerial);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "supervisores",
                columns: table => new
                {
                    idSupervisores = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Supervisor = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idSupervisores);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "tipocliente",
                columns: table => new
                {
                    idTipoCliente = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ClieProv = table.Column<int>(type: "int(11)", nullable: true),
                    estado = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idTipoCliente);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "transportes",
                columns: table => new
                {
                    idTransportes = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rut = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    razonSocial = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    direccion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    fonos = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Contacto = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<int>(type: "int(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idTransportes);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    idUsuarios = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idGrupoUsuario = table.Column<int>(type: "int(11)", nullable: true),
                    NombreUsuario = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Clave = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_spanish2_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Estado = table.Column<sbyte>(type: "tinyint(4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idUsuarios);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_spanish2_ci");

            migrationBuilder.CreateIndex(
                name: "idCargos_UNIQUE",
                table: "cargos",
                column: "idCargos",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idchofer",
                table: "chofer",
                column: "idchofer",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id",
                table: "clientes",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdDetalleProducto",
                table: "detalleproducto",
                column: "IdDetalleProducto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idCamion",
                table: "patentes",
                column: "idPatente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idCamion1",
                table: "patentestransferencia",
                column: "idPatente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idproducto",
                table: "producto",
                column: "idproducto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Rampla_UNIQUE",
                table: "rampla",
                column: "Rampla",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idResiduos_UNIQUE",
                table: "residuos",
                column: "idResiduos",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Supervisor_UNIQUE",
                table: "supervisores",
                column: "Supervisor",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accesos");

            migrationBuilder.DropTable(
                name: "cargos");

            migrationBuilder.DropTable(
                name: "chofer");

            migrationBuilder.DropTable(
                name: "clientegenerador");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "comuna");

            migrationBuilder.DropTable(
                name: "contactoclientes");

            migrationBuilder.DropTable(
                name: "detalleproducto");

            migrationBuilder.DropTable(
                name: "generadores");

            migrationBuilder.DropTable(
                name: "generadores2");

            migrationBuilder.DropTable(
                name: "gruposusuarios");

            migrationBuilder.DropTable(
                name: "impresora");

            migrationBuilder.DropTable(
                name: "iso14001");

            migrationBuilder.DropTable(
                name: "lavado");

            migrationBuilder.DropTable(
                name: "modificacionpesaje");

            migrationBuilder.DropTable(
                name: "modificacionpesajetransferencia");

            migrationBuilder.DropTable(
                name: "patentecliente");

            migrationBuilder.DropTable(
                name: "patenteclientetransferencia");

            migrationBuilder.DropTable(
                name: "patentememorandum");

            migrationBuilder.DropTable(
                name: "patentes");

            migrationBuilder.DropTable(
                name: "patentestransferencia");

            migrationBuilder.DropTable(
                name: "patentetransporte");

            migrationBuilder.DropTable(
                name: "pesaje");

            migrationBuilder.DropTable(
                name: "pesajetransferencia");

            migrationBuilder.DropTable(
                name: "plantas");

            migrationBuilder.DropTable(
                name: "plantasprog");

            migrationBuilder.DropTable(
                name: "producto");

            migrationBuilder.DropTable(
                name: "rampla");

            migrationBuilder.DropTable(
                name: "regiones");

            migrationBuilder.DropTable(
                name: "residuos");

            migrationBuilder.DropTable(
                name: "serial");

            migrationBuilder.DropTable(
                name: "supervisores");

            migrationBuilder.DropTable(
                name: "tipocliente");

            migrationBuilder.DropTable(
                name: "transportes");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
