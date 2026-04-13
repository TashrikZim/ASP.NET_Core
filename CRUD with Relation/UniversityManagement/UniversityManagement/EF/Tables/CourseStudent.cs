using System;
using System.Collections.Generic;

namespace UniversityManagement.EF.Tables;

public partial class CourseStudent
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int CourseId { get; set; }

    public string Student { get; set; } = null!;

    public string Course { get; set; } = null!;

    public virtual Course CourseNavigation { get; set; } = null!;

    public virtual Student StudentNavigation { get; set; } = null!;
}
