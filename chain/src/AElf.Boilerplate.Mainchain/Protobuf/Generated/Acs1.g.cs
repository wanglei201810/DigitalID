// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs1.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Acs1 {

  /// <summary>Holder for reflection information generated from acs1.proto</summary>
  internal static partial class Acs1Reflection {

    #region Descriptor
    /// <summary>File descriptor for acs1.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Acs1Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgphY3MxLnByb3RvEgRhY3MxGhJhZWxmL29wdGlvbnMucHJvdG8aG2dvb2ds",
            "ZS9wcm90b2J1Zi9lbXB0eS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBw",
            "ZXJzLnByb3RvGg9hZWxmL2NvcmUucHJvdG8iQAoKTWV0aG9kRmVlcxITCgtt",
            "ZXRob2RfbmFtZRgBIAEoCRIdCgRmZWVzGAIgAygLMg8uYWNzMS5NZXRob2RG",
            "ZWUiLgoJTWV0aG9kRmVlEg4KBnN5bWJvbBgBIAEoCRIRCgliYXNpY19mZWUY",
            "AiABKBIiVgoMTWV0aG9kRmVlU2V0Eg4KBm1ldGhvZBgBIAEoCRIOCgZzeW1i",
            "b2wYAiABKAkSDwoHb2xkX2ZlZRgDIAEoEhIPCgduZXdfZmVlGAQgASgSOgSg",
            "uxgBIl4KDUF1dGhvcml0eUluZm8SJwoQY29udHJhY3RfYWRkcmVzcxgBIAEo",
            "CzINLmFlbGYuQWRkcmVzcxIkCg1vd25lcl9hZGRyZXNzGAIgASgLMg0uYWVs",
            "Zi5BZGRyZXNzMrgCChlNZXRob2RGZWVQcm92aWRlckNvbnRyYWN0EjoKDFNl",
            "dE1ldGhvZEZlZRIQLmFjczEuTWV0aG9kRmVlcxoWLmdvb2dsZS5wcm90b2J1",
            "Zi5FbXB0eSIAEkoKGUNoYW5nZU1ldGhvZEZlZUNvbnRyb2xsZXISEy5hY3Mx",
            "LkF1dGhvcml0eUluZm8aFi5nb29nbGUucHJvdG9idWYuRW1wdHkiABJFCgxH",
            "ZXRNZXRob2RGZWUSHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUaEC5h",
            "Y3MxLk1ldGhvZEZlZXMiBYiJ9wEBEkwKFkdldE1ldGhvZEZlZUNvbnRyb2xs",
            "ZXISFi5nb29nbGUucHJvdG9idWYuRW1wdHkaEy5hY3MxLkF1dGhvcml0eUlu",
            "Zm8iBYiJ9wEBQgmKkvQBBGFjczFQAFABUAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.OptionsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::AElf.Types.CoreReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Acs1.MethodFees), global::Acs1.MethodFees.Parser, new[]{ "MethodName", "Fees" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Acs1.MethodFee), global::Acs1.MethodFee.Parser, new[]{ "Symbol", "BasicFee" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Acs1.MethodFeeSet), global::Acs1.MethodFeeSet.Parser, new[]{ "Method", "Symbol", "OldFee", "NewFee" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Acs1.AuthorityInfo), global::Acs1.AuthorityInfo.Parser, new[]{ "ContractAddress", "OwnerAddress" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class MethodFees : pb::IMessage<MethodFees> {
    private static readonly pb::MessageParser<MethodFees> _parser = new pb::MessageParser<MethodFees>(() => new MethodFees());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MethodFees> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Acs1.Acs1Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MethodFees() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MethodFees(MethodFees other) : this() {
      methodName_ = other.methodName_;
      fees_ = other.fees_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MethodFees Clone() {
      return new MethodFees(this);
    }

    /// <summary>Field number for the "method_name" field.</summary>
    public const int MethodNameFieldNumber = 1;
    private string methodName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MethodName {
      get { return methodName_; }
      set {
        methodName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fees" field.</summary>
    public const int FeesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Acs1.MethodFee> _repeated_fees_codec
        = pb::FieldCodec.ForMessage(18, global::Acs1.MethodFee.Parser);
    private readonly pbc::RepeatedField<global::Acs1.MethodFee> fees_ = new pbc::RepeatedField<global::Acs1.MethodFee>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Acs1.MethodFee> Fees {
      get { return fees_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MethodFees);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MethodFees other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MethodName != other.MethodName) return false;
      if(!fees_.Equals(other.fees_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MethodName.Length != 0) hash ^= MethodName.GetHashCode();
      hash ^= fees_.GetHashCode();
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
      if (MethodName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MethodName);
      }
      fees_.WriteTo(output, _repeated_fees_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MethodName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MethodName);
      }
      size += fees_.CalculateSize(_repeated_fees_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MethodFees other) {
      if (other == null) {
        return;
      }
      if (other.MethodName.Length != 0) {
        MethodName = other.MethodName;
      }
      fees_.Add(other.fees_);
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
            MethodName = input.ReadString();
            break;
          }
          case 18: {
            fees_.AddEntriesFrom(input, _repeated_fees_codec);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class MethodFee : pb::IMessage<MethodFee> {
    private static readonly pb::MessageParser<MethodFee> _parser = new pb::MessageParser<MethodFee>(() => new MethodFee());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MethodFee> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Acs1.Acs1Reflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MethodFee() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MethodFee(MethodFee other) : this() {
      symbol_ = other.symbol_;
      basicFee_ = other.basicFee_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MethodFee Clone() {
      return new MethodFee(this);
    }

    /// <summary>Field number for the "symbol" field.</summary>
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Symbol {
      get { return symbol_; }
      set {
        symbol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "basic_fee" field.</summary>
    public const int BasicFeeFieldNumber = 2;
    private long basicFee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BasicFee {
      get { return basicFee_; }
      set {
        basicFee_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MethodFee);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MethodFee other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Symbol != other.Symbol) return false;
      if (BasicFee != other.BasicFee) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Symbol.Length != 0) hash ^= Symbol.GetHashCode();
      if (BasicFee != 0L) hash ^= BasicFee.GetHashCode();
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
      if (Symbol.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Symbol);
      }
      if (BasicFee != 0L) {
        output.WriteRawTag(16);
        output.WriteSInt64(BasicFee);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Symbol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Symbol);
      }
      if (BasicFee != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(BasicFee);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MethodFee other) {
      if (other == null) {
        return;
      }
      if (other.Symbol.Length != 0) {
        Symbol = other.Symbol;
      }
      if (other.BasicFee != 0L) {
        BasicFee = other.BasicFee;
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
            Symbol = input.ReadString();
            break;
          }
          case 16: {
            BasicFee = input.ReadSInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Events
  /// </summary>
  internal sealed partial class MethodFeeSet : pb::IMessage<MethodFeeSet> {
    private static readonly pb::MessageParser<MethodFeeSet> _parser = new pb::MessageParser<MethodFeeSet>(() => new MethodFeeSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MethodFeeSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Acs1.Acs1Reflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MethodFeeSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MethodFeeSet(MethodFeeSet other) : this() {
      method_ = other.method_;
      symbol_ = other.symbol_;
      oldFee_ = other.oldFee_;
      newFee_ = other.newFee_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MethodFeeSet Clone() {
      return new MethodFeeSet(this);
    }

    /// <summary>Field number for the "method" field.</summary>
    public const int MethodFieldNumber = 1;
    private string method_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Method {
      get { return method_; }
      set {
        method_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "symbol" field.</summary>
    public const int SymbolFieldNumber = 2;
    private string symbol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Symbol {
      get { return symbol_; }
      set {
        symbol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "old_fee" field.</summary>
    public const int OldFeeFieldNumber = 3;
    private long oldFee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long OldFee {
      get { return oldFee_; }
      set {
        oldFee_ = value;
      }
    }

    /// <summary>Field number for the "new_fee" field.</summary>
    public const int NewFeeFieldNumber = 4;
    private long newFee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NewFee {
      get { return newFee_; }
      set {
        newFee_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MethodFeeSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MethodFeeSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Method != other.Method) return false;
      if (Symbol != other.Symbol) return false;
      if (OldFee != other.OldFee) return false;
      if (NewFee != other.NewFee) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Method.Length != 0) hash ^= Method.GetHashCode();
      if (Symbol.Length != 0) hash ^= Symbol.GetHashCode();
      if (OldFee != 0L) hash ^= OldFee.GetHashCode();
      if (NewFee != 0L) hash ^= NewFee.GetHashCode();
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
      if (Method.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Method);
      }
      if (Symbol.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Symbol);
      }
      if (OldFee != 0L) {
        output.WriteRawTag(24);
        output.WriteSInt64(OldFee);
      }
      if (NewFee != 0L) {
        output.WriteRawTag(32);
        output.WriteSInt64(NewFee);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Method.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Method);
      }
      if (Symbol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Symbol);
      }
      if (OldFee != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(OldFee);
      }
      if (NewFee != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(NewFee);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MethodFeeSet other) {
      if (other == null) {
        return;
      }
      if (other.Method.Length != 0) {
        Method = other.Method;
      }
      if (other.Symbol.Length != 0) {
        Symbol = other.Symbol;
      }
      if (other.OldFee != 0L) {
        OldFee = other.OldFee;
      }
      if (other.NewFee != 0L) {
        NewFee = other.NewFee;
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
            Method = input.ReadString();
            break;
          }
          case 18: {
            Symbol = input.ReadString();
            break;
          }
          case 24: {
            OldFee = input.ReadSInt64();
            break;
          }
          case 32: {
            NewFee = input.ReadSInt64();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class AuthorityInfo : pb::IMessage<AuthorityInfo> {
    private static readonly pb::MessageParser<AuthorityInfo> _parser = new pb::MessageParser<AuthorityInfo>(() => new AuthorityInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AuthorityInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Acs1.Acs1Reflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthorityInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthorityInfo(AuthorityInfo other) : this() {
      contractAddress_ = other.contractAddress_ != null ? other.contractAddress_.Clone() : null;
      ownerAddress_ = other.ownerAddress_ != null ? other.ownerAddress_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthorityInfo Clone() {
      return new AuthorityInfo(this);
    }

    /// <summary>Field number for the "contract_address" field.</summary>
    public const int ContractAddressFieldNumber = 1;
    private global::AElf.Types.Address contractAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address ContractAddress {
      get { return contractAddress_; }
      set {
        contractAddress_ = value;
      }
    }

    /// <summary>Field number for the "owner_address" field.</summary>
    public const int OwnerAddressFieldNumber = 2;
    private global::AElf.Types.Address ownerAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address OwnerAddress {
      get { return ownerAddress_; }
      set {
        ownerAddress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AuthorityInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AuthorityInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ContractAddress, other.ContractAddress)) return false;
      if (!object.Equals(OwnerAddress, other.OwnerAddress)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (contractAddress_ != null) hash ^= ContractAddress.GetHashCode();
      if (ownerAddress_ != null) hash ^= OwnerAddress.GetHashCode();
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
      if (contractAddress_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ContractAddress);
      }
      if (ownerAddress_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(OwnerAddress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (contractAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContractAddress);
      }
      if (ownerAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OwnerAddress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AuthorityInfo other) {
      if (other == null) {
        return;
      }
      if (other.contractAddress_ != null) {
        if (contractAddress_ == null) {
          ContractAddress = new global::AElf.Types.Address();
        }
        ContractAddress.MergeFrom(other.ContractAddress);
      }
      if (other.ownerAddress_ != null) {
        if (ownerAddress_ == null) {
          OwnerAddress = new global::AElf.Types.Address();
        }
        OwnerAddress.MergeFrom(other.OwnerAddress);
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
            if (contractAddress_ == null) {
              ContractAddress = new global::AElf.Types.Address();
            }
            input.ReadMessage(ContractAddress);
            break;
          }
          case 18: {
            if (ownerAddress_ == null) {
              OwnerAddress = new global::AElf.Types.Address();
            }
            input.ReadMessage(OwnerAddress);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code