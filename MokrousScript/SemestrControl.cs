using System;
using System.Collections.Generic;

namespace MokrousScript;

/// <summary>
/// форма контроля
/// </summary>
public partial class SemestrControl
{
    public int Id { get; set; }

    public int IdSemestr { get; set; }

    public int IdСontrolType { get; set; }

    public virtual Semestr IdSemestrNavigation { get; set; } = null!;

    public virtual ControlType IdСontrolTypeNavigation { get; set; } = null!;
}
