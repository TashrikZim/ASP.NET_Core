using System;
using System.Collections.Generic;

namespace UniversityManagement.EF.Tables;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DepartmentId { get; set; }

    public virtual ICollection<CourseStudent> CourseStudents { get; set; } = new List<CourseStudent>();

    public virtual Department Department { get; set; } = null!;
}
