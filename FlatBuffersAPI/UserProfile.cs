using System;
using System.Collections.Generic;

namespace FlatBuffersAPI;

public partial class UserProfile
{
    public int ProfileId { get; set; }

    public int? UserId { get; set; }

    public string? Bio { get; set; }

    public string? ProfilePicture { get; set; }

    public string? Website { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual User? User { get; set; }
}
