using System;
using System.Collections.Generic;

namespace Auth.EF.Tables;

public partial class UserType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
