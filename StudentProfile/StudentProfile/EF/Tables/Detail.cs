using System;
using System.Collections.Generic;

namespace StudentProfile.EF.Tables;

public partial class Detail
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
