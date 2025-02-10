using System;
using System.Collections.Generic;

namespace FlatBuffersAPI;

public partial class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? Country { get; set; }

    public DateOnly? BirthDate { get; set; }

    public DateOnly? JoinDate { get; set; }

    public decimal? Salary { get; set; }

    public string? Department { get; set; }

    public string? Position { get; set; }

    public int? ExperienceYears { get; set; }

    public bool? IsActive { get; set; }

    public double? Rating { get; set; }

    public string? Notes { get; set; }

    public string? Project { get; set; }

    public string? Manager { get; set; }

    public DateOnly? LastPromotionDate { get; set; }

    public string? Hobbies { get; set; }

    public string? Skills { get; set; }

    public string? FavoriteColor { get; set; }

    public virtual ICollection<ProjectAssignment> ProjectAssignments { get; set; } = new List<ProjectAssignment>();

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
