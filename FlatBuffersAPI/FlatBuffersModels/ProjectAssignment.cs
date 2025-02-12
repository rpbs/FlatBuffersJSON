// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatBuffersModels
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ProjectAssignment : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_1_24(); }
  public static ProjectAssignment GetRootAsProjectAssignment(ByteBuffer _bb) { return GetRootAsProjectAssignment(_bb, new ProjectAssignment()); }
  public static ProjectAssignment GetRootAsProjectAssignment(ByteBuffer _bb, ProjectAssignment obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ProjectAssignment __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int AssignmentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int UserId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Project { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProjectBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetProjectBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetProjectArray() { return __p.__vector_as_array<byte>(8); }
  public string Role { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRoleBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetRoleBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetRoleArray() { return __p.__vector_as_array<byte>(10); }
  public string StartDate { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStartDateBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetStartDateBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetStartDateArray() { return __p.__vector_as_array<byte>(12); }
  public string EndDate { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEndDateBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetEndDateBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetEndDateArray() { return __p.__vector_as_array<byte>(14); }
  public string Status { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStatusBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetStatusBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetStatusArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<FlatBuffersModels.ProjectAssignment> CreateProjectAssignment(FlatBufferBuilder builder,
      int assignment_id = 0,
      int user_id = 0,
      StringOffset projectOffset = default(StringOffset),
      StringOffset roleOffset = default(StringOffset),
      StringOffset start_dateOffset = default(StringOffset),
      StringOffset end_dateOffset = default(StringOffset),
      StringOffset statusOffset = default(StringOffset)) {
    builder.StartTable(7);
    ProjectAssignment.AddStatus(builder, statusOffset);
    ProjectAssignment.AddEndDate(builder, end_dateOffset);
    ProjectAssignment.AddStartDate(builder, start_dateOffset);
    ProjectAssignment.AddRole(builder, roleOffset);
    ProjectAssignment.AddProject(builder, projectOffset);
    ProjectAssignment.AddUserId(builder, user_id);
    ProjectAssignment.AddAssignmentId(builder, assignment_id);
    return ProjectAssignment.EndProjectAssignment(builder);
  }

  public static void StartProjectAssignment(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddAssignmentId(FlatBufferBuilder builder, int assignmentId) { builder.AddInt(0, assignmentId, 0); }
  public static void AddUserId(FlatBufferBuilder builder, int userId) { builder.AddInt(1, userId, 0); }
  public static void AddProject(FlatBufferBuilder builder, StringOffset projectOffset) { builder.AddOffset(2, projectOffset.Value, 0); }
  public static void AddRole(FlatBufferBuilder builder, StringOffset roleOffset) { builder.AddOffset(3, roleOffset.Value, 0); }
  public static void AddStartDate(FlatBufferBuilder builder, StringOffset startDateOffset) { builder.AddOffset(4, startDateOffset.Value, 0); }
  public static void AddEndDate(FlatBufferBuilder builder, StringOffset endDateOffset) { builder.AddOffset(5, endDateOffset.Value, 0); }
  public static void AddStatus(FlatBufferBuilder builder, StringOffset statusOffset) { builder.AddOffset(6, statusOffset.Value, 0); }
  public static Offset<FlatBuffersModels.ProjectAssignment> EndProjectAssignment(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatBuffersModels.ProjectAssignment>(o);
  }
}


static public class ProjectAssignmentVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*AssignmentId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*UserId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Project*/, false)
      && verifier.VerifyString(tablePos, 10 /*Role*/, false)
      && verifier.VerifyString(tablePos, 12 /*StartDate*/, false)
      && verifier.VerifyString(tablePos, 14 /*EndDate*/, false)
      && verifier.VerifyString(tablePos, 16 /*Status*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
