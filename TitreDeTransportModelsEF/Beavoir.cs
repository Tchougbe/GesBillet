﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Gestions_des_Titres_de_Transport.TitreDeTransportModelsEF;

public partial class Beavoir
{
    public int Idbeavoir { get; set; }

    public DateTime Datesaisibeavoir { get; set; }

    public DateTime? Datevalbeavoir { get; set; }

    public string Obserbeavoir { get; set; }

    public int Matagentsaibeavoir { get; set; }

    public int? Matagentvalbeavoir { get; set; }

    public int Idetapebeavoir { get; set; }

    public int? Idrenvoibeavoir { get; set; }

    public virtual ICollection<Avoir> Avoir { get; set; } = new List<Avoir>();
}