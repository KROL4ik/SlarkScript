using System;
using System.Collections.Generic;

namespace MokrousScript;

/// <summary>
/// квалиифкация
/// </summary>
public partial class Qualification
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Napravlenie> Napravlenies { get; set; } = new List<Napravlenie>();
}
