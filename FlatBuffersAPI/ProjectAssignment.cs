using System;
using System.Collections.Generic;

namespace FlatBuffersAPI;

public partial class ProjectAssignment
{
    public int AssignmentId { get; set; }

    public int? UserId { get; set; }

    public string? Project { get; set; }

    public string? Role { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Status { get; set; }

    public virtual User? User { get; set; }
}
