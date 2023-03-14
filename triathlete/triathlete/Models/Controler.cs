using System;
using System.Collections.Generic;

namespace triathlete.Models;

public partial class Controler
{
    public int TriId { get; set; }

    public int InscDossard { get; set; }

    public int DopId { get; set; }

    public decimal? ControleRésultat { get; set; }

    public virtual ProduitDopant Dop { get; set; } = null!;

    public virtual Inscription Inscription { get; set; } = null!;
}
