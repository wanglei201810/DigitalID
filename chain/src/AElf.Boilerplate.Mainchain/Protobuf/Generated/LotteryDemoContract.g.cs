// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: lottery_demo_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Contracts.LotteryDemoContract {

  /// <summary>Holder for reflection information generated from lottery_demo_contract.proto</summary>
  internal static partial class LotteryDemoContractReflection {

    #region Descriptor
    /// <summary>File descriptor for lottery_demo_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LotteryDemoContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chtsb3R0ZXJ5X2RlbW9fY29udHJhY3QucHJvdG8aD2FlbGYvY29yZS5wcm90",
            "bxoSYWVsZi9vcHRpb25zLnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHku",
            "cHJvdG8iOgoiSW5pdGlhbGl6ZUxvdHRlcnlEZW1vQ29udHJhY3RJbnB1dBIU",
            "Cgx0b2tlbl9zeW1ib2wYASABKAkiUAoOTmV3UGVyaW9kSW5wdXQSFQoNcGVy",
            "aW9kX251bWJlchgBIAEoEhInChNyYW5kb21fbnVtYmVyX3Rva2VuGAIgASgL",
            "MgouYWVsZi5IYXNoIr0BCglMb3R0ZXJpZXMSGQoHbG90dGVyeRgBIAMoCzII",
            "LkxvdHRlcnkSJAoNc2FsZXJfYWRkcmVzcxgCIAEoCzINLmFlbGYuQWRkcmVz",
            "cxIXCg9wcm9wb3J0aW9uX3NhbGUYAyABKBESGAoQcHJvcG9ydGlvbl9ib251",
            "cxgEIAEoERIVCg10YXJnZXRfcGVyaW9kGAUgASgREiUKDnNlbmRlcl9hZGRy",
            "ZXNzGAYgASgLMg0uYWVsZi5BZGRyZXNzIiYKB0xvdHRlcnkSDAoEdHlwZRgB",
            "IAEoERINCgV2YWx1ZRgCIAMoETLQAgoTTG90dGVyeURlbW9Db250cmFjdBJe",
            "Ch1Jbml0aWFsaXplTG90dGVyeURlbW9Db250cmFjdBIjLkluaXRpYWxpemVM",
            "b3R0ZXJ5RGVtb0NvbnRyYWN0SW5wdXQaFi5nb29nbGUucHJvdG9idWYuRW1w",
            "dHkiABI2CglOZXdQZXJpb2QSDy5OZXdQZXJpb2RJbnB1dBoWLmdvb2dsZS5w",
            "cm90b2J1Zi5FbXB0eSIAEisKA0JldBIKLkxvdHRlcmllcxoWLmdvb2dsZS5w",
            "cm90b2J1Zi5FbXB0eSIAEjIKClRha2VSZXdhcmQSCi5hZWxmLkhhc2gaFi5n",
            "b29nbGUucHJvdG9idWYuRW1wdHkiABpAssz2ATtBRWxmLkNvbnRyYWN0cy5M",
            "b3R0ZXJ5RGVtb0NvbnRyYWN0LkxvdHRlcnlEZW1vQ29udHJhY3RTdGF0ZUIl",
            "qgIiQUVsZi5Db250cmFjdHMuTG90dGVyeURlbW9Db250cmFjdGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Types.CoreReflection.Descriptor, global::AElf.OptionsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.LotteryDemoContract.InitializeLotteryDemoContractInput), global::AElf.Contracts.LotteryDemoContract.InitializeLotteryDemoContractInput.Parser, new[]{ "TokenSymbol" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.LotteryDemoContract.NewPeriodInput), global::AElf.Contracts.LotteryDemoContract.NewPeriodInput.Parser, new[]{ "PeriodNumber", "RandomNumberToken" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.LotteryDemoContract.Lotteries), global::AElf.Contracts.LotteryDemoContract.Lotteries.Parser, new[]{ "Lottery", "SalerAddress", "ProportionSale", "ProportionBonus", "TargetPeriod", "SenderAddress" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.LotteryDemoContract.Lottery), global::AElf.Contracts.LotteryDemoContract.Lottery.Parser, new[]{ "Type", "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class InitializeLotteryDemoContractInput : pb::IMessage<InitializeLotteryDemoContractInput> {
    private static readonly pb::MessageParser<InitializeLotteryDemoContractInput> _parser = new pb::MessageParser<InitializeLotteryDemoContractInput>(() => new InitializeLotteryDemoContractInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InitializeLotteryDemoContractInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.LotteryDemoContract.LotteryDemoContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeLotteryDemoContractInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeLotteryDemoContractInput(InitializeLotteryDemoContractInput other) : this() {
      tokenSymbol_ = other.tokenSymbol_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeLotteryDemoContractInput Clone() {
      return new InitializeLotteryDemoContractInput(this);
    }

    /// <summary>Field number for the "token_symbol" field.</summary>
    public const int TokenSymbolFieldNumber = 1;
    private string tokenSymbol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TokenSymbol {
      get { return tokenSymbol_; }
      set {
        tokenSymbol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InitializeLotteryDemoContractInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InitializeLotteryDemoContractInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TokenSymbol != other.TokenSymbol) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TokenSymbol.Length != 0) hash ^= TokenSymbol.GetHashCode();
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
      if (TokenSymbol.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TokenSymbol);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TokenSymbol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TokenSymbol);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InitializeLotteryDemoContractInput other) {
      if (other == null) {
        return;
      }
      if (other.TokenSymbol.Length != 0) {
        TokenSymbol = other.TokenSymbol;
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
            TokenSymbol = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class NewPeriodInput : pb::IMessage<NewPeriodInput> {
    private static readonly pb::MessageParser<NewPeriodInput> _parser = new pb::MessageParser<NewPeriodInput>(() => new NewPeriodInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NewPeriodInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.LotteryDemoContract.LotteryDemoContractReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NewPeriodInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NewPeriodInput(NewPeriodInput other) : this() {
      periodNumber_ = other.periodNumber_;
      randomNumberToken_ = other.randomNumberToken_ != null ? other.randomNumberToken_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NewPeriodInput Clone() {
      return new NewPeriodInput(this);
    }

    /// <summary>Field number for the "period_number" field.</summary>
    public const int PeriodNumberFieldNumber = 1;
    private long periodNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long PeriodNumber {
      get { return periodNumber_; }
      set {
        periodNumber_ = value;
      }
    }

    /// <summary>Field number for the "random_number_token" field.</summary>
    public const int RandomNumberTokenFieldNumber = 2;
    private global::AElf.Types.Hash randomNumberToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Hash RandomNumberToken {
      get { return randomNumberToken_; }
      set {
        randomNumberToken_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NewPeriodInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NewPeriodInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PeriodNumber != other.PeriodNumber) return false;
      if (!object.Equals(RandomNumberToken, other.RandomNumberToken)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PeriodNumber != 0L) hash ^= PeriodNumber.GetHashCode();
      if (randomNumberToken_ != null) hash ^= RandomNumberToken.GetHashCode();
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
      if (PeriodNumber != 0L) {
        output.WriteRawTag(8);
        output.WriteSInt64(PeriodNumber);
      }
      if (randomNumberToken_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RandomNumberToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PeriodNumber != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(PeriodNumber);
      }
      if (randomNumberToken_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RandomNumberToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NewPeriodInput other) {
      if (other == null) {
        return;
      }
      if (other.PeriodNumber != 0L) {
        PeriodNumber = other.PeriodNumber;
      }
      if (other.randomNumberToken_ != null) {
        if (randomNumberToken_ == null) {
          RandomNumberToken = new global::AElf.Types.Hash();
        }
        RandomNumberToken.MergeFrom(other.RandomNumberToken);
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
          case 8: {
            PeriodNumber = input.ReadSInt64();
            break;
          }
          case 18: {
            if (randomNumberToken_ == null) {
              RandomNumberToken = new global::AElf.Types.Hash();
            }
            input.ReadMessage(RandomNumberToken);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class Lotteries : pb::IMessage<Lotteries> {
    private static readonly pb::MessageParser<Lotteries> _parser = new pb::MessageParser<Lotteries>(() => new Lotteries());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Lotteries> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.LotteryDemoContract.LotteryDemoContractReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Lotteries() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Lotteries(Lotteries other) : this() {
      lottery_ = other.lottery_.Clone();
      salerAddress_ = other.salerAddress_ != null ? other.salerAddress_.Clone() : null;
      proportionSale_ = other.proportionSale_;
      proportionBonus_ = other.proportionBonus_;
      targetPeriod_ = other.targetPeriod_;
      senderAddress_ = other.senderAddress_ != null ? other.senderAddress_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Lotteries Clone() {
      return new Lotteries(this);
    }

    /// <summary>Field number for the "lottery" field.</summary>
    public const int LotteryFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AElf.Contracts.LotteryDemoContract.Lottery> _repeated_lottery_codec
        = pb::FieldCodec.ForMessage(10, global::AElf.Contracts.LotteryDemoContract.Lottery.Parser);
    private readonly pbc::RepeatedField<global::AElf.Contracts.LotteryDemoContract.Lottery> lottery_ = new pbc::RepeatedField<global::AElf.Contracts.LotteryDemoContract.Lottery>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AElf.Contracts.LotteryDemoContract.Lottery> Lottery {
      get { return lottery_; }
    }

    /// <summary>Field number for the "saler_address" field.</summary>
    public const int SalerAddressFieldNumber = 2;
    private global::AElf.Types.Address salerAddress_;
    /// <summary>
    /// 分销员地址
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address SalerAddress {
      get { return salerAddress_; }
      set {
        salerAddress_ = value;
      }
    }

    /// <summary>Field number for the "proportion_sale" field.</summary>
    public const int ProportionSaleFieldNumber = 3;
    private int proportionSale_;
    /// <summary>
    /// 销售分成 [0, 15] default 0
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ProportionSale {
      get { return proportionSale_; }
      set {
        proportionSale_ = value;
      }
    }

    /// <summary>Field number for the "proportion_bonus" field.</summary>
    public const int ProportionBonusFieldNumber = 4;
    private int proportionBonus_;
    /// <summary>
    /// 兑奖分成 [0, 5] default 0
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ProportionBonus {
      get { return proportionBonus_; }
      set {
        proportionBonus_ = value;
      }
    }

    /// <summary>Field number for the "target_period" field.</summary>
    public const int TargetPeriodFieldNumber = 5;
    private int targetPeriod_;
    /// <summary>
    /// 当前期数，在APP里做
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TargetPeriod {
      get { return targetPeriod_; }
      set {
        targetPeriod_ = value;
      }
    }

    /// <summary>Field number for the "sender_address" field.</summary>
    public const int SenderAddressFieldNumber = 6;
    private global::AElf.Types.Address senderAddress_;
    /// <summary>
    /// 用户地址
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address SenderAddress {
      get { return senderAddress_; }
      set {
        senderAddress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Lotteries);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Lotteries other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!lottery_.Equals(other.lottery_)) return false;
      if (!object.Equals(SalerAddress, other.SalerAddress)) return false;
      if (ProportionSale != other.ProportionSale) return false;
      if (ProportionBonus != other.ProportionBonus) return false;
      if (TargetPeriod != other.TargetPeriod) return false;
      if (!object.Equals(SenderAddress, other.SenderAddress)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= lottery_.GetHashCode();
      if (salerAddress_ != null) hash ^= SalerAddress.GetHashCode();
      if (ProportionSale != 0) hash ^= ProportionSale.GetHashCode();
      if (ProportionBonus != 0) hash ^= ProportionBonus.GetHashCode();
      if (TargetPeriod != 0) hash ^= TargetPeriod.GetHashCode();
      if (senderAddress_ != null) hash ^= SenderAddress.GetHashCode();
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
      lottery_.WriteTo(output, _repeated_lottery_codec);
      if (salerAddress_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SalerAddress);
      }
      if (ProportionSale != 0) {
        output.WriteRawTag(24);
        output.WriteSInt32(ProportionSale);
      }
      if (ProportionBonus != 0) {
        output.WriteRawTag(32);
        output.WriteSInt32(ProportionBonus);
      }
      if (TargetPeriod != 0) {
        output.WriteRawTag(40);
        output.WriteSInt32(TargetPeriod);
      }
      if (senderAddress_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SenderAddress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += lottery_.CalculateSize(_repeated_lottery_codec);
      if (salerAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SalerAddress);
      }
      if (ProportionSale != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(ProportionSale);
      }
      if (ProportionBonus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(ProportionBonus);
      }
      if (TargetPeriod != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(TargetPeriod);
      }
      if (senderAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SenderAddress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Lotteries other) {
      if (other == null) {
        return;
      }
      lottery_.Add(other.lottery_);
      if (other.salerAddress_ != null) {
        if (salerAddress_ == null) {
          SalerAddress = new global::AElf.Types.Address();
        }
        SalerAddress.MergeFrom(other.SalerAddress);
      }
      if (other.ProportionSale != 0) {
        ProportionSale = other.ProportionSale;
      }
      if (other.ProportionBonus != 0) {
        ProportionBonus = other.ProportionBonus;
      }
      if (other.TargetPeriod != 0) {
        TargetPeriod = other.TargetPeriod;
      }
      if (other.senderAddress_ != null) {
        if (senderAddress_ == null) {
          SenderAddress = new global::AElf.Types.Address();
        }
        SenderAddress.MergeFrom(other.SenderAddress);
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
            lottery_.AddEntriesFrom(input, _repeated_lottery_codec);
            break;
          }
          case 18: {
            if (salerAddress_ == null) {
              SalerAddress = new global::AElf.Types.Address();
            }
            input.ReadMessage(SalerAddress);
            break;
          }
          case 24: {
            ProportionSale = input.ReadSInt32();
            break;
          }
          case 32: {
            ProportionBonus = input.ReadSInt32();
            break;
          }
          case 40: {
            TargetPeriod = input.ReadSInt32();
            break;
          }
          case 50: {
            if (senderAddress_ == null) {
              SenderAddress = new global::AElf.Types.Address();
            }
            input.ReadMessage(SenderAddress);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class Lottery : pb::IMessage<Lottery> {
    private static readonly pb::MessageParser<Lottery> _parser = new pb::MessageParser<Lottery>(() => new Lottery());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Lottery> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.LotteryDemoContract.LotteryDemoContractReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Lottery() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Lottery(Lottery other) : this() {
      type_ = other.type_;
      value_ = other.value_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Lottery Clone() {
      return new Lottery(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private int type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private static readonly pb::FieldCodec<int> _repeated_value_codec
        = pb::FieldCodec.ForSInt32(18);
    private readonly pbc::RepeatedField<int> value_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Value {
      get { return value_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Lottery);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Lottery other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if(!value_.Equals(other.value_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      hash ^= value_.GetHashCode();
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
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteSInt32(Type);
      }
      value_.WriteTo(output, _repeated_value_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Type);
      }
      size += value_.CalculateSize(_repeated_value_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Lottery other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      value_.Add(other.value_);
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
          case 8: {
            Type = input.ReadSInt32();
            break;
          }
          case 18:
          case 16: {
            value_.AddEntriesFrom(input, _repeated_value_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code