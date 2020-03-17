// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: basic_contract_zero.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.Genesis {

  #region Events
  #endregion
  internal static partial class BasicContractZeroContainer
  {
    static readonly string __ServiceName = "zero.BasicContractZero";

    #region Marshallers
    static readonly aelf::Marshaller<global::Acs0.SystemContractDeploymentInput> __Marshaller_acs0_SystemContractDeploymentInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs0.SystemContractDeploymentInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs0.ContractDeploymentInput> __Marshaller_acs0_ContractDeploymentInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs0.ContractDeploymentInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs0.ContractUpdateInput> __Marshaller_acs0_ContractUpdateInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs0.ContractUpdateInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Hash> __Marshaller_aelf_Hash = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Hash.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs0.ContractCodeCheckInput> __Marshaller_acs0_ContractCodeCheckInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs0.ContractCodeCheckInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs0.ReleaseContractInput> __Marshaller_acs0_ReleaseContractInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs0.ReleaseContractInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs0.InitializeInput> __Marshaller_acs0_InitializeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs0.InitializeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.BoolValue> __Marshaller_google_protobuf_BoolValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.BoolValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.UInt64Value> __Marshaller_google_protobuf_UInt64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.UInt64Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs0.ContractInfo> __Marshaller_acs0_ContractInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs0.ContractInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.SmartContractRegistration> __Marshaller_aelf_SmartContractRegistration = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.SmartContractRegistration.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs0.ValidateSystemContractAddressInput> __Marshaller_acs0_ValidateSystemContractAddressInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs0.ValidateSystemContractAddressInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs1.MethodFees> __Marshaller_acs1_MethodFees = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs1.MethodFees.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs1.AuthorityInfo> __Marshaller_acs1_AuthorityInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs1.AuthorityInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Genesis.AddressList> __Marshaller_zero_AddressList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Genesis.AddressList.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::Acs0.SystemContractDeploymentInput, global::AElf.Types.Address> __Method_DeploySystemSmartContract = new aelf::Method<global::Acs0.SystemContractDeploymentInput, global::AElf.Types.Address>(
        aelf::MethodType.Action,
        __ServiceName,
        "DeploySystemSmartContract",
        __Marshaller_acs0_SystemContractDeploymentInput,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::Acs0.ContractDeploymentInput, global::AElf.Types.Address> __Method_DeploySmartContract = new aelf::Method<global::Acs0.ContractDeploymentInput, global::AElf.Types.Address>(
        aelf::MethodType.Action,
        __ServiceName,
        "DeploySmartContract",
        __Marshaller_acs0_ContractDeploymentInput,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::Acs0.ContractUpdateInput, global::AElf.Types.Address> __Method_UpdateSmartContract = new aelf::Method<global::Acs0.ContractUpdateInput, global::AElf.Types.Address>(
        aelf::MethodType.Action,
        __ServiceName,
        "UpdateSmartContract",
        __Marshaller_acs0_ContractUpdateInput,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::Acs0.ContractDeploymentInput, global::AElf.Types.Hash> __Method_ProposeNewContract = new aelf::Method<global::Acs0.ContractDeploymentInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "ProposeNewContract",
        __Marshaller_acs0_ContractDeploymentInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::Acs0.ContractCodeCheckInput, global::AElf.Types.Hash> __Method_ProposeContractCodeCheck = new aelf::Method<global::Acs0.ContractCodeCheckInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "ProposeContractCodeCheck",
        __Marshaller_acs0_ContractCodeCheckInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::Acs0.ContractUpdateInput, global::AElf.Types.Hash> __Method_ProposeUpdateContract = new aelf::Method<global::Acs0.ContractUpdateInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "ProposeUpdateContract",
        __Marshaller_acs0_ContractUpdateInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::Acs0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ReleaseApprovedContract = new aelf::Method<global::Acs0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ReleaseApprovedContract",
        __Marshaller_acs0_ReleaseContractInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Acs0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ReleaseCodeCheckedContract = new aelf::Method<global::Acs0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ReleaseCodeCheckedContract",
        __Marshaller_acs0_ReleaseContractInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Acs0.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Initialize = new aelf::Method<global::Acs0.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Initialize",
        __Marshaller_acs0_InitializeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.BoolValue, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetContractProposerRequiredState = new aelf::Method<global::Google.Protobuf.WellKnownTypes.BoolValue, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetContractProposerRequiredState",
        __Marshaller_google_protobuf_BoolValue,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetInitialControllerAddress = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetInitialControllerAddress",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.UInt64Value> __Method_CurrentContractSerialNumber = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.UInt64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "CurrentContractSerialNumber",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_UInt64Value);

    static readonly aelf::Method<global::AElf.Types.Address, global::Acs0.ContractInfo> __Method_GetContractInfo = new aelf::Method<global::AElf.Types.Address, global::Acs0.ContractInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetContractInfo",
        __Marshaller_aelf_Address,
        __Marshaller_acs0_ContractInfo);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Types.Address> __Method_GetContractAuthor = new aelf::Method<global::AElf.Types.Address, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetContractAuthor",
        __Marshaller_aelf_Address,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Types.Hash> __Method_GetContractHash = new aelf::Method<global::AElf.Types.Address, global::AElf.Types.Hash>(
        aelf::MethodType.View,
        __ServiceName,
        "GetContractHash",
        __Marshaller_aelf_Address,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address> __Method_GetContractAddressByName = new aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetContractAddressByName",
        __Marshaller_aelf_Hash,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Types.SmartContractRegistration> __Method_GetSmartContractRegistrationByAddress = new aelf::Method<global::AElf.Types.Address, global::AElf.Types.SmartContractRegistration>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSmartContractRegistrationByAddress",
        __Marshaller_aelf_Address,
        __Marshaller_aelf_SmartContractRegistration);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Types.SmartContractRegistration> __Method_GetSmartContractRegistration = new aelf::Method<global::AElf.Types.Hash, global::AElf.Types.SmartContractRegistration>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSmartContractRegistration",
        __Marshaller_aelf_Hash,
        __Marshaller_aelf_SmartContractRegistration);

    static readonly aelf::Method<global::Acs0.ValidateSystemContractAddressInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ValidateSystemContractAddress = new aelf::Method<global::Acs0.ValidateSystemContractAddressInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.View,
        __ServiceName,
        "ValidateSystemContractAddress",
        __Marshaller_acs0_ValidateSystemContractAddressInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Acs1.MethodFees, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetMethodFee = new aelf::Method<global::Acs1.MethodFees, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetMethodFee",
        __Marshaller_acs1_MethodFees,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Acs1.AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeMethodFeeController = new aelf::Method<global::Acs1.AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeMethodFeeController",
        __Marshaller_acs1_AuthorityInfo,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::Acs1.MethodFees> __Method_GetMethodFee = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::Acs1.MethodFees>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMethodFee",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_acs1_MethodFees);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Acs1.AuthorityInfo> __Method_GetMethodFeeController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Acs1.AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMethodFeeController",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs1_AuthorityInfo);

    static readonly aelf::Method<global::Acs1.AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeContractDeploymentController = new aelf::Method<global::Acs1.AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeContractDeploymentController",
        __Marshaller_acs1_AuthorityInfo,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Acs1.AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeCodeCheckController = new aelf::Method<global::Acs1.AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeCodeCheckController",
        __Marshaller_acs1_AuthorityInfo,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Genesis.AddressList> __Method_GetDeployedContractAddressList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Genesis.AddressList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetDeployedContractAddressList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_zero_AddressList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Acs1.AuthorityInfo> __Method_GetContractDeploymentController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Acs1.AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetContractDeploymentController",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs1_AuthorityInfo);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Acs1.AuthorityInfo> __Method_GetCodeCheckController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Acs1.AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCodeCheckController",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs1_AuthorityInfo);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.Genesis.BasicContractZeroReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::Acs0.Acs0Reflection.Descriptor.Services[0],
          global::Acs1.Acs1Reflection.Descriptor.Services[0],
          global::AElf.Contracts.Genesis.BasicContractZeroReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class BasicContractZeroReferenceState : global::AElf.Sdk.CSharp.State.ContractReferenceState
    {
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs0.SystemContractDeploymentInput, global::AElf.Types.Address> DeploySystemSmartContract { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs0.ContractDeploymentInput, global::AElf.Types.Address> DeploySmartContract { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs0.ContractUpdateInput, global::AElf.Types.Address> UpdateSmartContract { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs0.ContractDeploymentInput, global::AElf.Types.Hash> ProposeNewContract { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs0.ContractCodeCheckInput, global::AElf.Types.Hash> ProposeContractCodeCheck { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs0.ContractUpdateInput, global::AElf.Types.Hash> ProposeUpdateContract { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty> ReleaseApprovedContract { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty> ReleaseCodeCheckedContract { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs0.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> Initialize { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.BoolValue, global::Google.Protobuf.WellKnownTypes.Empty> SetContractProposerRequiredState { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> SetInitialControllerAddress { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.UInt64Value> CurrentContractSerialNumber { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Address, global::Acs0.ContractInfo> GetContractInfo { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Address, global::AElf.Types.Address> GetContractAuthor { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Address, global::AElf.Types.Hash> GetContractHash { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::AElf.Types.Address> GetContractAddressByName { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Address, global::AElf.Types.SmartContractRegistration> GetSmartContractRegistrationByAddress { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Hash, global::AElf.Types.SmartContractRegistration> GetSmartContractRegistration { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs0.ValidateSystemContractAddressInput, global::Google.Protobuf.WellKnownTypes.Empty> ValidateSystemContractAddress { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs1.MethodFees, global::Google.Protobuf.WellKnownTypes.Empty> SetMethodFee { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs1.AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> ChangeMethodFeeController { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.StringValue, global::Acs1.MethodFees> GetMethodFee { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.Empty, global::Acs1.AuthorityInfo> GetMethodFeeController { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs1.AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> ChangeContractDeploymentController { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Acs1.AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> ChangeCodeCheckController { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Genesis.AddressList> GetDeployedContractAddressList { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.Empty, global::Acs1.AuthorityInfo> GetContractDeploymentController { get; set; }
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::Google.Protobuf.WellKnownTypes.Empty, global::Acs1.AuthorityInfo> GetCodeCheckController { get; set; }
    }
  }
}
#endregion
