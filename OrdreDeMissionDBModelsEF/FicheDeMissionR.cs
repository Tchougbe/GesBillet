﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Gestions_des_Titres_de_Transport.OrdreDeMissionDBModelsEF;

public partial class FicheDeMissionR
{
    public string RefFiche { get; set; }

    public string NomEtPrénoms { get; set; }

    public string Objet { get; set; }

    public DateTime? DateDébut { get; set; }

    public DateTime? DateFin { get; set; }

    public string Opérateur { get; set; }

    public string Valideur { get; set; }

    public DateTime? DateEnreg { get; set; }

    public int? Etat { get; set; }

    public int? Valider { get; set; }

    public string Classe { get; set; }

    public string Frais { get; set; }

    public string AutreImputation { get; set; }

    public int? RoutingTraite { get; set; }

    public int? RoutingPvalider { get; set; }

    public int? RoutingValider { get; set; }

    public string CatégorieAppliquée { get; set; }

    public DateTime? DateRouting { get; set; }

    public string MissionDrh { get; set; }

    public int? Etape { get; set; }

    public string CodeStr { get; set; }
}