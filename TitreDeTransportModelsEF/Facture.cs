﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Gestions_des_Titres_de_Transport.TitreDeTransportModelsEF;

public partial class Facture
{
    public int Idfacture { get; set; }

    public int? Idbereglem { get; set; }

    public string Numerofactureagence { get; set; }

    public DateTime Datesaisifacture { get; set; }

    public DateTime Dateagenceemissionfacture { get; set; }

    public DateTime? Datevalfacture { get; set; }

    public decimal? Montanttotalsurfacture { get; set; }

    public string Obserfacture { get; set; }

    public int Matagentsaifacture { get; set; }

    public int? Matagentvalfacture { get; set; }

    public int Idetapefacture { get; set; }

    public int Idagencevoyagefacture { get; set; }

    public int? Idrenvoifacture { get; set; }

    public virtual Bereglement IdbereglemNavigation { get; set; }

    public virtual ICollection<Titredetransport> Titredetransport { get; set; } = new List<Titredetransport>();
}