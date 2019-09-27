// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: uploads/uploads_service.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace KillrVideo.Uploads {

  /// <summary>Holder for reflection information generated from uploads/uploads_service.proto</summary>
  public static partial class UploadsServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for uploads/uploads_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UploadsServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch11cGxvYWRzL3VwbG9hZHNfc2VydmljZS5wcm90bxISa2lsbHJ2aWRlby51",
            "cGxvYWRzGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhljb21t",
            "b24vY29tbW9uX3R5cGVzLnByb3RvIjAKG0dldFVwbG9hZERlc3RpbmF0aW9u",
            "UmVxdWVzdBIRCglmaWxlX25hbWUYASABKAkiMgocR2V0VXBsb2FkRGVzdGlu",
            "YXRpb25SZXNwb25zZRISCgp1cGxvYWRfdXJsGAEgASgJIi8KGU1hcmtVcGxv",
            "YWRDb21wbGV0ZVJlcXVlc3QSEgoKdXBsb2FkX3VybBgBIAEoCSIcChpNYXJr",
            "VXBsb2FkQ29tcGxldGVSZXNwb25zZSJEChdHZXRTdGF0dXNPZlZpZGVvUmVx",
            "dWVzdBIpCgh2aWRlb19pZBgBIAEoCzIXLmtpbGxydmlkZW8uY29tbW9uLlV1",
            "aWQiYgoYR2V0U3RhdHVzT2ZWaWRlb1Jlc3BvbnNlEi8KC3N0YXR1c19kYXRl",
            "GAEgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIVCg1jdXJyZW50",
            "X3N0YXRlGAIgASgJMu8CCg5VcGxvYWRzU2VydmljZRJ5ChRHZXRVcGxvYWRE",
            "ZXN0aW5hdGlvbhIvLmtpbGxydmlkZW8udXBsb2Fkcy5HZXRVcGxvYWREZXN0",
            "aW5hdGlvblJlcXVlc3QaMC5raWxscnZpZGVvLnVwbG9hZHMuR2V0VXBsb2Fk",
            "RGVzdGluYXRpb25SZXNwb25zZRJzChJNYXJrVXBsb2FkQ29tcGxldGUSLS5r",
            "aWxscnZpZGVvLnVwbG9hZHMuTWFya1VwbG9hZENvbXBsZXRlUmVxdWVzdBou",
            "LmtpbGxydmlkZW8udXBsb2Fkcy5NYXJrVXBsb2FkQ29tcGxldGVSZXNwb25z",
            "ZRJtChBHZXRTdGF0dXNPZlZpZGVvEisua2lsbHJ2aWRlby51cGxvYWRzLkdl",
            "dFN0YXR1c09mVmlkZW9SZXF1ZXN0Giwua2lsbHJ2aWRlby51cGxvYWRzLkdl",
            "dFN0YXR1c09mVmlkZW9SZXNwb25zZUIVqgISS2lsbHJWaWRlby5VcGxvYWRz",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::KillrVideo.Protobuf.CommonTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::KillrVideo.Uploads.GetUploadDestinationRequest), global::KillrVideo.Uploads.GetUploadDestinationRequest.Parser, new[]{ "FileName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::KillrVideo.Uploads.GetUploadDestinationResponse), global::KillrVideo.Uploads.GetUploadDestinationResponse.Parser, new[]{ "UploadUrl" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::KillrVideo.Uploads.MarkUploadCompleteRequest), global::KillrVideo.Uploads.MarkUploadCompleteRequest.Parser, new[]{ "UploadUrl" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::KillrVideo.Uploads.MarkUploadCompleteResponse), global::KillrVideo.Uploads.MarkUploadCompleteResponse.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::KillrVideo.Uploads.GetStatusOfVideoRequest), global::KillrVideo.Uploads.GetStatusOfVideoRequest.Parser, new[]{ "VideoId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::KillrVideo.Uploads.GetStatusOfVideoResponse), global::KillrVideo.Uploads.GetStatusOfVideoResponse.Parser, new[]{ "StatusDate", "CurrentState" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Request to get/generate a location where a video can be uploaded
  /// </summary>
  public sealed partial class GetUploadDestinationRequest : pb::IMessage<GetUploadDestinationRequest> {
    private static readonly pb::MessageParser<GetUploadDestinationRequest> _parser = new pb::MessageParser<GetUploadDestinationRequest>(() => new GetUploadDestinationRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetUploadDestinationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Uploads.UploadsServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUploadDestinationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUploadDestinationRequest(GetUploadDestinationRequest other) : this() {
      fileName_ = other.fileName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUploadDestinationRequest Clone() {
      return new GetUploadDestinationRequest(this);
    }

    /// <summary>Field number for the "file_name" field.</summary>
    public const int FileNameFieldNumber = 1;
    private string fileName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FileName {
      get { return fileName_; }
      set {
        fileName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetUploadDestinationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetUploadDestinationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FileName != other.FileName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FileName.Length != 0) hash ^= FileName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (FileName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FileName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FileName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FileName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetUploadDestinationRequest other) {
      if (other == null) {
        return;
      }
      if (other.FileName.Length != 0) {
        FileName = other.FileName;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            FileName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Response that has the location where a video can be uploaded
  /// </summary>
  public sealed partial class GetUploadDestinationResponse : pb::IMessage<GetUploadDestinationResponse> {
    private static readonly pb::MessageParser<GetUploadDestinationResponse> _parser = new pb::MessageParser<GetUploadDestinationResponse>(() => new GetUploadDestinationResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetUploadDestinationResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Uploads.UploadsServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUploadDestinationResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUploadDestinationResponse(GetUploadDestinationResponse other) : this() {
      uploadUrl_ = other.uploadUrl_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUploadDestinationResponse Clone() {
      return new GetUploadDestinationResponse(this);
    }

    /// <summary>Field number for the "upload_url" field.</summary>
    public const int UploadUrlFieldNumber = 1;
    private string uploadUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UploadUrl {
      get { return uploadUrl_; }
      set {
        uploadUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetUploadDestinationResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetUploadDestinationResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UploadUrl != other.UploadUrl) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UploadUrl.Length != 0) hash ^= UploadUrl.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UploadUrl.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UploadUrl);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UploadUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UploadUrl);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetUploadDestinationResponse other) {
      if (other == null) {
        return;
      }
      if (other.UploadUrl.Length != 0) {
        UploadUrl = other.UploadUrl;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            UploadUrl = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Request to tell the upload service that a video is finished uploading
  /// </summary>
  public sealed partial class MarkUploadCompleteRequest : pb::IMessage<MarkUploadCompleteRequest> {
    private static readonly pb::MessageParser<MarkUploadCompleteRequest> _parser = new pb::MessageParser<MarkUploadCompleteRequest>(() => new MarkUploadCompleteRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MarkUploadCompleteRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Uploads.UploadsServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarkUploadCompleteRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarkUploadCompleteRequest(MarkUploadCompleteRequest other) : this() {
      uploadUrl_ = other.uploadUrl_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarkUploadCompleteRequest Clone() {
      return new MarkUploadCompleteRequest(this);
    }

    /// <summary>Field number for the "upload_url" field.</summary>
    public const int UploadUrlFieldNumber = 1;
    private string uploadUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UploadUrl {
      get { return uploadUrl_; }
      set {
        uploadUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MarkUploadCompleteRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MarkUploadCompleteRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UploadUrl != other.UploadUrl) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UploadUrl.Length != 0) hash ^= UploadUrl.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UploadUrl.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UploadUrl);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UploadUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UploadUrl);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MarkUploadCompleteRequest other) {
      if (other == null) {
        return;
      }
      if (other.UploadUrl.Length != 0) {
        UploadUrl = other.UploadUrl;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            UploadUrl = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Response when marking an upload complete
  /// </summary>
  public sealed partial class MarkUploadCompleteResponse : pb::IMessage<MarkUploadCompleteResponse> {
    private static readonly pb::MessageParser<MarkUploadCompleteResponse> _parser = new pb::MessageParser<MarkUploadCompleteResponse>(() => new MarkUploadCompleteResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MarkUploadCompleteResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Uploads.UploadsServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarkUploadCompleteResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarkUploadCompleteResponse(MarkUploadCompleteResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MarkUploadCompleteResponse Clone() {
      return new MarkUploadCompleteResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MarkUploadCompleteResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MarkUploadCompleteResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MarkUploadCompleteResponse other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  /// <summary>
  ///  Get the current status of an uploaded video
  /// </summary>
  public sealed partial class GetStatusOfVideoRequest : pb::IMessage<GetStatusOfVideoRequest> {
    private static readonly pb::MessageParser<GetStatusOfVideoRequest> _parser = new pb::MessageParser<GetStatusOfVideoRequest>(() => new GetStatusOfVideoRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetStatusOfVideoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Uploads.UploadsServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStatusOfVideoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStatusOfVideoRequest(GetStatusOfVideoRequest other) : this() {
      VideoId = other.videoId_ != null ? other.VideoId.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStatusOfVideoRequest Clone() {
      return new GetStatusOfVideoRequest(this);
    }

    /// <summary>Field number for the "video_id" field.</summary>
    public const int VideoIdFieldNumber = 1;
    private global::KillrVideo.Protobuf.Uuid videoId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::KillrVideo.Protobuf.Uuid VideoId {
      get { return videoId_; }
      set {
        videoId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetStatusOfVideoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetStatusOfVideoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(VideoId, other.VideoId)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (videoId_ != null) hash ^= VideoId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (videoId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(VideoId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (videoId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VideoId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetStatusOfVideoRequest other) {
      if (other == null) {
        return;
      }
      if (other.videoId_ != null) {
        if (videoId_ == null) {
          videoId_ = new global::KillrVideo.Protobuf.Uuid();
        }
        VideoId.MergeFrom(other.VideoId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (videoId_ == null) {
              videoId_ = new global::KillrVideo.Protobuf.Uuid();
            }
            input.ReadMessage(videoId_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Response with the current status of an uploaded video
  /// </summary>
  public sealed partial class GetStatusOfVideoResponse : pb::IMessage<GetStatusOfVideoResponse> {
    private static readonly pb::MessageParser<GetStatusOfVideoResponse> _parser = new pb::MessageParser<GetStatusOfVideoResponse>(() => new GetStatusOfVideoResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetStatusOfVideoResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Uploads.UploadsServiceReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStatusOfVideoResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStatusOfVideoResponse(GetStatusOfVideoResponse other) : this() {
      StatusDate = other.statusDate_ != null ? other.StatusDate.Clone() : null;
      currentState_ = other.currentState_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetStatusOfVideoResponse Clone() {
      return new GetStatusOfVideoResponse(this);
    }

    /// <summary>Field number for the "status_date" field.</summary>
    public const int StatusDateFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp statusDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StatusDate {
      get { return statusDate_; }
      set {
        statusDate_ = value;
      }
    }

    /// <summary>Field number for the "current_state" field.</summary>
    public const int CurrentStateFieldNumber = 2;
    private string currentState_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrentState {
      get { return currentState_; }
      set {
        currentState_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetStatusOfVideoResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetStatusOfVideoResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(StatusDate, other.StatusDate)) return false;
      if (CurrentState != other.CurrentState) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (statusDate_ != null) hash ^= StatusDate.GetHashCode();
      if (CurrentState.Length != 0) hash ^= CurrentState.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (statusDate_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(StatusDate);
      }
      if (CurrentState.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CurrentState);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (statusDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StatusDate);
      }
      if (CurrentState.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrentState);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetStatusOfVideoResponse other) {
      if (other == null) {
        return;
      }
      if (other.statusDate_ != null) {
        if (statusDate_ == null) {
          statusDate_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StatusDate.MergeFrom(other.StatusDate);
      }
      if (other.CurrentState.Length != 0) {
        CurrentState = other.CurrentState;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (statusDate_ == null) {
              statusDate_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(statusDate_);
            break;
          }
          case 18: {
            CurrentState = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code