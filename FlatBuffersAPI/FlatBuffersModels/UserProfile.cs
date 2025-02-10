// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatBuffersModels
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct UserProfile : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_1_24(); }
  public static UserProfile GetRootAsUserProfile(ByteBuffer _bb) { return GetRootAsUserProfile(_bb, new UserProfile()); }
  public static UserProfile GetRootAsUserProfile(ByteBuffer _bb, UserProfile obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public UserProfile __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int ProfileId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int UserId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Bio { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBioBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetBioBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetBioArray() { return __p.__vector_as_array<byte>(8); }
  public string ProfilePicture { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProfilePictureBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetProfilePictureBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetProfilePictureArray() { return __p.__vector_as_array<byte>(10); }
  public string Website { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetWebsiteBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetWebsiteBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetWebsiteArray() { return __p.__vector_as_array<byte>(12); }
  public string DateOfBirth { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDateOfBirthBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetDateOfBirthBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetDateOfBirthArray() { return __p.__vector_as_array<byte>(14); }
  public string CreatedAt { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCreatedAtBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetCreatedAtBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetCreatedAtArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<FlatBuffersModels.UserProfile> CreateUserProfile(FlatBufferBuilder builder,
      int profile_id = 0,
      int user_id = 0,
      StringOffset bioOffset = default(StringOffset),
      StringOffset profile_pictureOffset = default(StringOffset),
      StringOffset websiteOffset = default(StringOffset),
      StringOffset date_of_birthOffset = default(StringOffset),
      StringOffset created_atOffset = default(StringOffset)) {
    builder.StartTable(7);
    UserProfile.AddCreatedAt(builder, created_atOffset);
    UserProfile.AddDateOfBirth(builder, date_of_birthOffset);
    UserProfile.AddWebsite(builder, websiteOffset);
    UserProfile.AddProfilePicture(builder, profile_pictureOffset);
    UserProfile.AddBio(builder, bioOffset);
    UserProfile.AddUserId(builder, user_id);
    UserProfile.AddProfileId(builder, profile_id);
    return UserProfile.EndUserProfile(builder);
  }

  public static void StartUserProfile(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddProfileId(FlatBufferBuilder builder, int profileId) { builder.AddInt(0, profileId, 0); }
  public static void AddUserId(FlatBufferBuilder builder, int userId) { builder.AddInt(1, userId, 0); }
  public static void AddBio(FlatBufferBuilder builder, StringOffset bioOffset) { builder.AddOffset(2, bioOffset.Value, 0); }
  public static void AddProfilePicture(FlatBufferBuilder builder, StringOffset profilePictureOffset) { builder.AddOffset(3, profilePictureOffset.Value, 0); }
  public static void AddWebsite(FlatBufferBuilder builder, StringOffset websiteOffset) { builder.AddOffset(4, websiteOffset.Value, 0); }
  public static void AddDateOfBirth(FlatBufferBuilder builder, StringOffset dateOfBirthOffset) { builder.AddOffset(5, dateOfBirthOffset.Value, 0); }
  public static void AddCreatedAt(FlatBufferBuilder builder, StringOffset createdAtOffset) { builder.AddOffset(6, createdAtOffset.Value, 0); }
  public static Offset<FlatBuffersModels.UserProfile> EndUserProfile(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatBuffersModels.UserProfile>(o);
  }
}


static public class UserProfileVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ProfileId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*UserId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Bio*/, false)
      && verifier.VerifyString(tablePos, 10 /*ProfilePicture*/, false)
      && verifier.VerifyString(tablePos, 12 /*Website*/, false)
      && verifier.VerifyString(tablePos, 14 /*DateOfBirth*/, false)
      && verifier.VerifyString(tablePos, 16 /*CreatedAt*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
