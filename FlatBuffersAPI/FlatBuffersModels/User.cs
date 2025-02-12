// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatBuffersModels
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct User : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_25_1_24(); }
  public static User GetRootAsUser(ByteBuffer _bb) { return GetRootAsUser(_bb, new User()); }
  public static User GetRootAsUser(ByteBuffer _bb, User obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool VerifyUser(ByteBuffer _bb) {Google.FlatBuffers.Verifier verifier = new Google.FlatBuffers.Verifier(_bb); return verifier.VerifyBuffer("", false, UserVerify.Verify); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public User __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int UserId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public int Age { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Email { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEmailBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetEmailBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetEmailArray() { return __p.__vector_as_array<byte>(10); }
  public string PhoneNumber { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPhoneNumberBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetPhoneNumberBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetPhoneNumberArray() { return __p.__vector_as_array<byte>(12); }
  public string Address { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAddressBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetAddressBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetAddressArray() { return __p.__vector_as_array<byte>(14); }
  public string City { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCityBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetCityBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetCityArray() { return __p.__vector_as_array<byte>(16); }
  public string State { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStateBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetStateBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetStateArray() { return __p.__vector_as_array<byte>(18); }
  public string ZipCode { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetZipCodeBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetZipCodeBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetZipCodeArray() { return __p.__vector_as_array<byte>(20); }
  public string Country { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCountryBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetCountryBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetCountryArray() { return __p.__vector_as_array<byte>(22); }
  public string BirthDate { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBirthDateBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetBirthDateBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetBirthDateArray() { return __p.__vector_as_array<byte>(24); }
  public string JoinDate { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetJoinDateBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetJoinDateBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetJoinDateArray() { return __p.__vector_as_array<byte>(26); }
  public float Salary { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string Department { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDepartmentBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetDepartmentBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetDepartmentArray() { return __p.__vector_as_array<byte>(30); }
  public string Position { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPositionBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetPositionBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetPositionArray() { return __p.__vector_as_array<byte>(32); }
  public int ExperienceYears { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool IsActive { get { int o = __p.__offset(36); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public double Rating { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetDouble(o + __p.bb_pos) : (double)0.0; } }
  public string Notes { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNotesBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetNotesBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetNotesArray() { return __p.__vector_as_array<byte>(40); }
  public string Project { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProjectBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetProjectBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetProjectArray() { return __p.__vector_as_array<byte>(42); }
  public string Manager { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetManagerBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetManagerBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetManagerArray() { return __p.__vector_as_array<byte>(44); }
  public string LastPromotionDate { get { int o = __p.__offset(46); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLastPromotionDateBytes() { return __p.__vector_as_span<byte>(46, 1); }
#else
  public ArraySegment<byte>? GetLastPromotionDateBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public byte[] GetLastPromotionDateArray() { return __p.__vector_as_array<byte>(46); }
  public string Hobbies { get { int o = __p.__offset(48); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetHobbiesBytes() { return __p.__vector_as_span<byte>(48, 1); }
#else
  public ArraySegment<byte>? GetHobbiesBytes() { return __p.__vector_as_arraysegment(48); }
#endif
  public byte[] GetHobbiesArray() { return __p.__vector_as_array<byte>(48); }
  public string Skills { get { int o = __p.__offset(50); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSkillsBytes() { return __p.__vector_as_span<byte>(50, 1); }
#else
  public ArraySegment<byte>? GetSkillsBytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public byte[] GetSkillsArray() { return __p.__vector_as_array<byte>(50); }
  public string FavoriteColor { get { int o = __p.__offset(52); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFavoriteColorBytes() { return __p.__vector_as_span<byte>(52, 1); }
#else
  public ArraySegment<byte>? GetFavoriteColorBytes() { return __p.__vector_as_arraysegment(52); }
#endif
  public byte[] GetFavoriteColorArray() { return __p.__vector_as_array<byte>(52); }
  public FlatBuffersModels.ProjectAssignment? ProjectAssignments(int j) { int o = __p.__offset(54); return o != 0 ? (FlatBuffersModels.ProjectAssignment?)(new FlatBuffersModels.ProjectAssignment()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ProjectAssignmentsLength { get { int o = __p.__offset(54); return o != 0 ? __p.__vector_len(o) : 0; } }
  public FlatBuffersModels.UserProfile? UserProfiles(int j) { int o = __p.__offset(56); return o != 0 ? (FlatBuffersModels.UserProfile?)(new FlatBuffersModels.UserProfile()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int UserProfilesLength { get { int o = __p.__offset(56); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatBuffersModels.User> CreateUser(FlatBufferBuilder builder,
      int user_id = 0,
      StringOffset nameOffset = default(StringOffset),
      int age = 0,
      StringOffset emailOffset = default(StringOffset),
      StringOffset phone_numberOffset = default(StringOffset),
      StringOffset addressOffset = default(StringOffset),
      StringOffset cityOffset = default(StringOffset),
      StringOffset stateOffset = default(StringOffset),
      StringOffset zip_codeOffset = default(StringOffset),
      StringOffset countryOffset = default(StringOffset),
      StringOffset birth_dateOffset = default(StringOffset),
      StringOffset join_dateOffset = default(StringOffset),
      float salary = 0.0f,
      StringOffset departmentOffset = default(StringOffset),
      StringOffset positionOffset = default(StringOffset),
      int experience_years = 0,
      bool is_active = false,
      double rating = 0.0,
      StringOffset notesOffset = default(StringOffset),
      StringOffset projectOffset = default(StringOffset),
      StringOffset managerOffset = default(StringOffset),
      StringOffset last_promotion_dateOffset = default(StringOffset),
      StringOffset hobbiesOffset = default(StringOffset),
      StringOffset skillsOffset = default(StringOffset),
      StringOffset favorite_colorOffset = default(StringOffset),
      VectorOffset project_assignmentsOffset = default(VectorOffset),
      VectorOffset user_profilesOffset = default(VectorOffset)) {
    builder.StartTable(27);
    User.AddRating(builder, rating);
    User.AddUserProfiles(builder, user_profilesOffset);
    User.AddProjectAssignments(builder, project_assignmentsOffset);
    User.AddFavoriteColor(builder, favorite_colorOffset);
    User.AddSkills(builder, skillsOffset);
    User.AddHobbies(builder, hobbiesOffset);
    User.AddLastPromotionDate(builder, last_promotion_dateOffset);
    User.AddManager(builder, managerOffset);
    User.AddProject(builder, projectOffset);
    User.AddNotes(builder, notesOffset);
    User.AddExperienceYears(builder, experience_years);
    User.AddPosition(builder, positionOffset);
    User.AddDepartment(builder, departmentOffset);
    User.AddSalary(builder, salary);
    User.AddJoinDate(builder, join_dateOffset);
    User.AddBirthDate(builder, birth_dateOffset);
    User.AddCountry(builder, countryOffset);
    User.AddZipCode(builder, zip_codeOffset);
    User.AddState(builder, stateOffset);
    User.AddCity(builder, cityOffset);
    User.AddAddress(builder, addressOffset);
    User.AddPhoneNumber(builder, phone_numberOffset);
    User.AddEmail(builder, emailOffset);
    User.AddAge(builder, age);
    User.AddName(builder, nameOffset);
    User.AddUserId(builder, user_id);
    User.AddIsActive(builder, is_active);
    return User.EndUser(builder);
  }

  public static void StartUser(FlatBufferBuilder builder) { builder.StartTable(27); }
  public static void AddUserId(FlatBufferBuilder builder, int userId) { builder.AddInt(0, userId, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddAge(FlatBufferBuilder builder, int age) { builder.AddInt(2, age, 0); }
  public static void AddEmail(FlatBufferBuilder builder, StringOffset emailOffset) { builder.AddOffset(3, emailOffset.Value, 0); }
  public static void AddPhoneNumber(FlatBufferBuilder builder, StringOffset phoneNumberOffset) { builder.AddOffset(4, phoneNumberOffset.Value, 0); }
  public static void AddAddress(FlatBufferBuilder builder, StringOffset addressOffset) { builder.AddOffset(5, addressOffset.Value, 0); }
  public static void AddCity(FlatBufferBuilder builder, StringOffset cityOffset) { builder.AddOffset(6, cityOffset.Value, 0); }
  public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset) { builder.AddOffset(7, stateOffset.Value, 0); }
  public static void AddZipCode(FlatBufferBuilder builder, StringOffset zipCodeOffset) { builder.AddOffset(8, zipCodeOffset.Value, 0); }
  public static void AddCountry(FlatBufferBuilder builder, StringOffset countryOffset) { builder.AddOffset(9, countryOffset.Value, 0); }
  public static void AddBirthDate(FlatBufferBuilder builder, StringOffset birthDateOffset) { builder.AddOffset(10, birthDateOffset.Value, 0); }
  public static void AddJoinDate(FlatBufferBuilder builder, StringOffset joinDateOffset) { builder.AddOffset(11, joinDateOffset.Value, 0); }
  public static void AddSalary(FlatBufferBuilder builder, float salary) { builder.AddFloat(12, salary, 0.0f); }
  public static void AddDepartment(FlatBufferBuilder builder, StringOffset departmentOffset) { builder.AddOffset(13, departmentOffset.Value, 0); }
  public static void AddPosition(FlatBufferBuilder builder, StringOffset positionOffset) { builder.AddOffset(14, positionOffset.Value, 0); }
  public static void AddExperienceYears(FlatBufferBuilder builder, int experienceYears) { builder.AddInt(15, experienceYears, 0); }
  public static void AddIsActive(FlatBufferBuilder builder, bool isActive) { builder.AddBool(16, isActive, false); }
  public static void AddRating(FlatBufferBuilder builder, double rating) { builder.AddDouble(17, rating, 0.0); }
  public static void AddNotes(FlatBufferBuilder builder, StringOffset notesOffset) { builder.AddOffset(18, notesOffset.Value, 0); }
  public static void AddProject(FlatBufferBuilder builder, StringOffset projectOffset) { builder.AddOffset(19, projectOffset.Value, 0); }
  public static void AddManager(FlatBufferBuilder builder, StringOffset managerOffset) { builder.AddOffset(20, managerOffset.Value, 0); }
  public static void AddLastPromotionDate(FlatBufferBuilder builder, StringOffset lastPromotionDateOffset) { builder.AddOffset(21, lastPromotionDateOffset.Value, 0); }
  public static void AddHobbies(FlatBufferBuilder builder, StringOffset hobbiesOffset) { builder.AddOffset(22, hobbiesOffset.Value, 0); }
  public static void AddSkills(FlatBufferBuilder builder, StringOffset skillsOffset) { builder.AddOffset(23, skillsOffset.Value, 0); }
  public static void AddFavoriteColor(FlatBufferBuilder builder, StringOffset favoriteColorOffset) { builder.AddOffset(24, favoriteColorOffset.Value, 0); }
  public static void AddProjectAssignments(FlatBufferBuilder builder, VectorOffset projectAssignmentsOffset) { builder.AddOffset(25, projectAssignmentsOffset.Value, 0); }
  public static VectorOffset CreateProjectAssignmentsVector(FlatBufferBuilder builder, Offset<FlatBuffersModels.ProjectAssignment>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateProjectAssignmentsVectorBlock(FlatBufferBuilder builder, Offset<FlatBuffersModels.ProjectAssignment>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateProjectAssignmentsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatBuffersModels.ProjectAssignment>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateProjectAssignmentsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatBuffersModels.ProjectAssignment>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartProjectAssignmentsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUserProfiles(FlatBufferBuilder builder, VectorOffset userProfilesOffset) { builder.AddOffset(26, userProfilesOffset.Value, 0); }
  public static VectorOffset CreateUserProfilesVector(FlatBufferBuilder builder, Offset<FlatBuffersModels.UserProfile>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateUserProfilesVectorBlock(FlatBufferBuilder builder, Offset<FlatBuffersModels.UserProfile>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUserProfilesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatBuffersModels.UserProfile>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUserProfilesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatBuffersModels.UserProfile>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUserProfilesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatBuffersModels.User> EndUser(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatBuffersModels.User>(o);
  }
  public static void FinishUserBuffer(FlatBufferBuilder builder, Offset<FlatBuffersModels.User> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedUserBuffer(FlatBufferBuilder builder, Offset<FlatBuffersModels.User> offset) { builder.FinishSizePrefixed(offset.Value); }
}


static public class UserVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UserId*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*Name*/, false)
      && verifier.VerifyField(tablePos, 8 /*Age*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*Email*/, false)
      && verifier.VerifyString(tablePos, 12 /*PhoneNumber*/, false)
      && verifier.VerifyString(tablePos, 14 /*Address*/, false)
      && verifier.VerifyString(tablePos, 16 /*City*/, false)
      && verifier.VerifyString(tablePos, 18 /*State*/, false)
      && verifier.VerifyString(tablePos, 20 /*ZipCode*/, false)
      && verifier.VerifyString(tablePos, 22 /*Country*/, false)
      && verifier.VerifyString(tablePos, 24 /*BirthDate*/, false)
      && verifier.VerifyString(tablePos, 26 /*JoinDate*/, false)
      && verifier.VerifyField(tablePos, 28 /*Salary*/, 4 /*float*/, 4, false)
      && verifier.VerifyString(tablePos, 30 /*Department*/, false)
      && verifier.VerifyString(tablePos, 32 /*Position*/, false)
      && verifier.VerifyField(tablePos, 34 /*ExperienceYears*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 36 /*IsActive*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 38 /*Rating*/, 8 /*double*/, 8, false)
      && verifier.VerifyString(tablePos, 40 /*Notes*/, false)
      && verifier.VerifyString(tablePos, 42 /*Project*/, false)
      && verifier.VerifyString(tablePos, 44 /*Manager*/, false)
      && verifier.VerifyString(tablePos, 46 /*LastPromotionDate*/, false)
      && verifier.VerifyString(tablePos, 48 /*Hobbies*/, false)
      && verifier.VerifyString(tablePos, 50 /*Skills*/, false)
      && verifier.VerifyString(tablePos, 52 /*FavoriteColor*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 54 /*ProjectAssignments*/, FlatBuffersModels.ProjectAssignmentVerify.Verify, false)
      && verifier.VerifyVectorOfTables(tablePos, 56 /*UserProfiles*/, FlatBuffersModels.UserProfileVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
