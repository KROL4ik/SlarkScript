using System;
using System.Collections.Generic;

namespace MokrousScript;

/// <summary>
/// вид работы и её содержание в разделе (для 4 команды). Не используется! Денормализована. 
/// </summary>
public partial class Work
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public short? WorkNumber { get; set; }

    public int? IdRazdel { get; set; }

    public virtual Razdel? IdRazdelNavigation { get; set; }
}
