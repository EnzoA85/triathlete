using System;
using System.Collections.Generic;

namespace triathlete.Models;

public partial class Club
{
    public int ClubId { get; set; }

    public string? ClubNom { get; set; }

    public string? ClubRue { get; set; }

    public string? ClubTel { get; set; }

    public string? ClubVille { get; set; }

    public string? ClubCp { get; set; }

    public virtual ICollection<LicenceClub> LicenceClubClubIdAdhererNavigations { get; } = new List<LicenceClub>();

    public virtual ICollection<LicenceClub> LicenceClubClubIdEntrainerNavigations { get; } = new List<LicenceClub>();
}
