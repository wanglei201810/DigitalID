// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: digitalID.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Contracts.DigitalIDContract {

  /// <summary>Holder for reflection information generated from digitalID.proto</summary>
  public static partial class DigitalIDReflection {

    #region Descriptor
    /// <summary>File descriptor for digitalID.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DigitalIDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9kaWdpdGFsSUQucHJvdG8aD2FlbGYvY29yZS5wcm90bxoSYWVsZi9vcHRp",
            "b25zLnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aHmdvb2ds",
            "ZS9wcm90b2J1Zi93cmFwcGVycy5wcm90byJmCgVTdHVmZhIWCgJpZBgBIAEo",
            "CzIKLmFlbGYuSGFzaBILCgNpZHMYAiABKAkSDAoEbmFtZRgDIAEoCRINCgVl",
            "bWFpbBgEIAEoCRILCgNrZXkYBSABKAkSDgoGbGl2aW5nGAYgASgIMpECChFE",
            "aWdpdGFsSURDb250cmFjdBI7CgdJbml0aWFsEhYuZ29vZ2xlLnByb3RvYnVm",
            "LkVtcHR5GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5IgASLAoIU2V0U3R1ZmYS",
            "Bi5TdHVmZhoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSIAEiwKCERlbFN0dWZm",
            "EgYuU3R1ZmYaFi5nb29nbGUucHJvdG9idWYuRW1wdHkiABIlCghHZXRTdHVm",
            "ZhIKLmFlbGYuSGFzaBoGLlN0dWZmIgWIifcBARo8ssz2ATdBRWxmLkNvbnRy",
            "YWN0cy5EaWdpdGFsSURDb250cmFjdC5EaWdpdGFsSURDb250cmFjdFN0YXRl",
            "QiOqAiBBRWxmLkNvbnRyYWN0cy5EaWdpdGFsSURDb250cmFjdGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Types.CoreReflection.Descriptor, global::AElf.OptionsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.DigitalIDContract.Stuff), global::AElf.Contracts.DigitalIDContract.Stuff.Parser, new[]{ "Id", "Ids", "Name", "Email", "Key", "Living" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Stuff : pb::IMessage<Stuff> {
    private static readonly pb::MessageParser<Stuff> _parser = new pb::MessageParser<Stuff>(() => new Stuff());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Stuff> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.DigitalIDContract.DigitalIDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stuff() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stuff(Stuff other) : this() {
      id_ = other.id_ != null ? other.id_.Clone() : null;
      ids_ = other.ids_;
      name_ = other.name_;
      email_ = other.email_;
      key_ = other.key_;
      living_ = other.living_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stuff Clone() {
      return new Stuff(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::AElf.Types.Hash id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Hash Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "ids" field.</summary>
    public const int IdsFieldNumber = 2;
    private string ids_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Ids {
      get { return ids_; }
      set {
        ids_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 4;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 5;
    private string key_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "living" field.</summary>
    public const int LivingFieldNumber = 6;
    private bool living_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Living {
      get { return living_; }
      set {
        living_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Stuff);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Stuff other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if (Ids != other.Ids) return false;
      if (Name != other.Name) return false;
      if (Email != other.Email) return false;
      if (Key != other.Key) return false;
      if (Living != other.Living) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (Ids.Length != 0) hash ^= Ids.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (Living != false) hash ^= Living.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (id_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
      if (Ids.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Ids);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Email);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Key);
      }
      if (Living != false) {
        output.WriteRawTag(48);
        output.WriteBool(Living);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      if (Ids.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ids);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (Living != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Stuff other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          Id = new global::AElf.Types.Hash();
        }
        Id.MergeFrom(other.Id);
      }
      if (other.Ids.Length != 0) {
        Ids = other.Ids;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.Living != false) {
        Living = other.Living;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (id_ == null) {
              Id = new global::AElf.Types.Hash();
            }
            input.ReadMessage(Id);
            break;
          }
          case 18: {
            Ids = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            Email = input.ReadString();
            break;
          }
          case 42: {
            Key = input.ReadString();
            break;
          }
          case 48: {
            Living = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
