﻿using System;
using System.Collections.Generic;

namespace MokrousScript;

/// <summary>
/// Блок плана
/// </summary>
public partial class BlockPlan
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
