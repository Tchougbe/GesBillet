﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Gestions_des_Titres_de_Transport.TitreDeTransportModelsEF;

public partial class Etape
{
    public int Idetape { get; set; }

    public string Libelleetape { get; set; }

    public int Numeroetape { get; set; }

    public bool Sietapeactive { get; set; }

    public virtual ICollection<Autorisationetape> Autorisationetape { get; set; } = new List<Autorisationetape>();

    public virtual ICollection<Titredetransport> Titredetransport { get; set; } = new List<Titredetransport>();
}