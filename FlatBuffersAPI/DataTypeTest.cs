using System.ComponentModel.DataAnnotations;

namespace FlatBuffersAPI;

public class DataTypeTest
{
    public Guid Id { get; set; }

    [StringLength(4000)]
    public string JsonData { get; set; }

    public byte[] BinaryData { get; set; }
}