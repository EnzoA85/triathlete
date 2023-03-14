using System;
using System.Collections.Generic;

namespace triathlete.Models;

public partial class Categorie
{
    public int CatId { get; set; }

    public string? CatLibelle { get; set; }

    public int? CatAgeDébut { get; set; }

    public int? CatAgeFin { get; set; }

    public virtual ICollection<Licence> Licences { get; } = new List<Licence>();
}
