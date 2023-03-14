using System;
using System.Collections.Generic;

namespace triathlete.Models;

public partial class LicenceClub
{
    public int LicId { get; set; }

    public int? ClubIdEntrainer { get; set; }

    public int ClubIdAdherer { get; set; }

    public DateOnly? LicDatePremiereLice { get; set; }

    public virtual Club ClubIdAdhererNavigation { get; set; } = null!;

    public virtual Club? ClubIdEntrainerNavigation { get; set; }

    public virtual Licence Lic { get; set; } = null!;
}
