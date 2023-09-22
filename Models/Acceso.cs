using System;
using System.Collections.Generic;

namespace sism.Models;

public partial class Acceso
{
    public int Idaccesos { get; set; }

    public int? IdGrupoDeUsuarios { get; set; }

    public sbyte? Mop { get; set; }

    public sbyte? Archivos { get; set; }

    public sbyte? ClienteProveedor { get; set; }

    public sbyte? IngresoDe { get; set; }

    public sbyte? IngresoDeTipos { get; set; }

    public sbyte? AdministracionDeValoers { get; set; }

    public sbyte? Camiones { get; set; }

    public sbyte? Generadores { get; set; }

    public sbyte? Transportes { get; set; }

    public sbyte? Conductores { get; set; }

    public sbyte? TiposResiduos { get; set; }

    public sbyte? SupervisoresyRamplas { get; set; }

    public sbyte? Usuarios { get; set; }

    public sbyte? ConexionServidor { get; set; }

    public sbyte? ParametrosDinamicos { get; set; }

    public sbyte? Pesaje { get; set; }

    public sbyte? PesajeComercial { get; set; }

    public sbyte? ReimpresionTicketMop { get; set; }

    public sbyte? ReimpresionTickets { get; set; }

    public sbyte? Modificacion { get; set; }

    public sbyte? ListadoModificacion { get; set; }

    public sbyte? Transferencia { get; set; }

    public sbyte? PesajeTrasferencia { get; set; }

    public sbyte? ControlItinerario { get; set; }

    public sbyte? ControlHorario { get; set; }

    public sbyte? ControlTransferencia { get; set; }

    public sbyte? Informes { get; set; }

    public sbyte? TipoResiduo { get; set; }

    public sbyte? ClienteProveedor1 { get; set; }

    public sbyte? Camion { get; set; }

    public sbyte? InformeIngresos { get; set; }

    public sbyte? PesajePorHora { get; set; }

    public sbyte? PermanenciaEnPlanta { get; set; }

    public sbyte? Pesajetransferencia { get; set; }

    public sbyte? InformeGeneralDeTickets { get; set; }

    public sbyte? Estado { get; set; }
}
