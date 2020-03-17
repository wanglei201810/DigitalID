// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: aedpos_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.Consensus.AEDPoS {

  #region Events
  internal partial class IrreversibleBlockFound : aelf::IEvent<IrreversibleBlockFound>
  {
    public global::System.Collections.Generic.IEnumerable<IrreversibleBlockFound> GetIndexed()
    {
      yield return new IrreversibleBlockFound
      {
        IrreversibleBlockHeight = IrreversibleBlockHeight
      };
      yield break;
    }

    public IrreversibleBlockFound GetNonIndexed()
    {
      return new IrreversibleBlockFound
      {
      };
    }
  }

  internal partial class IrreversibleBlockHeightUnacceptable : aelf::IEvent<IrreversibleBlockHeightUnacceptable>
  {
    public global::System.Collections.Generic.IEnumerable<IrreversibleBlockHeightUnacceptable> GetIndexed()
    {
      yield break;
    }

    public IrreversibleBlockHeightUnacceptable GetNonIndexed()
    {
      return new IrreversibleBlockHeightUnacceptable
      {
        DistanceToIrreversibleBlockHeight = DistanceToIrreversibleBlockHeight,
      };
    }
  }

  internal partial class MiningInformationUpdated : aelf::IEvent<MiningInformationUpdated>
  {
    public global::System.Collections.Generic.IEnumerable<MiningInformationUpdated> GetIndexed()
    {
      yield return new MiningInformationUpdated
      {
        Pubkey = Pubkey
      };
      yield return new MiningInformationUpdated
      {
        MiningTime = MiningTime
      };
      yield return new MiningInformationUpdated
      {
        Behaviour = Behaviour
      };
      yield return new MiningInformationUpdated
      {
        BlockHeight = BlockHeight
      };
      yield return new MiningInformationUpdated
      {
        PreviousBlockHash = PreviousBlockHash
      };
      yield break;
    }

    public MiningInformationUpdated GetNonIndexed()
    {
      return new MiningInformationUpdated
      {
      };
    }
  }

  internal partial class SecretSharingInformation : aelf::IEvent<SecretSharingInformation>
  {
    public global::System.Collections.Generic.IEnumerable<SecretSharingInformation> GetIndexed()
    {
      yield return new SecretSharingInformation
      {
        PreviousRound = PreviousRound
      };
      yield break;
    }

    public SecretSharingInformation GetNonIndexed()
    {
      return new SecretSharingInformation
      {
        CurrentRoundId = CurrentRoundId,
        PreviousRoundId = PreviousRoundId,
      };
    }
  }

  internal partial class MiningRewardGenerated : aelf::IEvent<MiningRewardGenerated>
  {
    public global::System.Collections.Generic.IEnumerable<MiningRewardGenerated> GetIndexed()
    {
      yield return new MiningRewardGenerated
      {
        TermNumber = TermNumber
      };
      yield break;
    }

    public MiningRewardGenerated GetNonIndexed()
    {
      return new MiningRewardGenerated
      {
        Amount = Amount,
      };
    }
  }

  #endregion
  internal static partial class AEDPoSContractContainer
  {
    static readonly string __ServiceName = "AEDPoSContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Contracts.Consensus.AEDPoS.InitialAElfConsensusContractInput> __Marshaller_InitialAElfConsensusContractInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Consensus.AEDPoS.InitialAElfConsensusContractInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Consensus.AEDPoS.Round> __Marshaller_Round = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Consensus.AEDPoS.Round.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Consensus.AEDPoS.UpdateValueInput> __Marshaller_UpdateValueInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Consensus.AEDPoS.UpdateValueInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Consensus.AEDPoS.TinyBlockInput> __Marshaller_TinyBlockInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Consensus.AEDPoS.TinyBlockInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Consensus.AEDPoS.ConsensusInformation> __Marshaller_ConsensusInformation = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Consensus.AEDPoS.ConsensusInformation.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.SInt32Value> __Marshaller_aelf_SInt32Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.SInt32Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Consensus.AEDPoS.MinerList> __Marshaller_MinerList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Consensus.AEDPoS.MinerList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Consensus.AEDPoS.PubkeyList> __Marshaller_PubkeyList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Consensus.AEDPoS.PubkeyList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Consensus.AEDPoS.MinerListWithRoundNumber> __Marshaller_MinerListWithRoundNumber = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Consensus.AEDPoS.MinerListWithRoundNumber.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.SInt64Value> __Marshaller_aelf_SInt64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.SInt64Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Consensus.AEDPoS.GetMinerListInput> __Marshaller_GetMinerListInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Consensus.AEDPoS.GetMinerListInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.BoolValue> __Marshaller_google_protobuf_BoolValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.BoolValue.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.InitialAElfConsensusContractInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_InitialAElfConsensusContract = new aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.InitialAElfConsensusContractInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "InitialAElfConsensusContract",
        __Marshaller_InitialAElfConsensusContractInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.Round, global::Google.Protobuf.WellKnownTypes.Empty> __Method_FirstRound = new aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.Round, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "FirstRound",
        __Marshaller_Round,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.UpdateValueInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateValue = new aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.UpdateValueInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "UpdateValue",
        __Marshaller_UpdateValueInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.Round, global::Google.Protobuf.WellKnownTypes.Empty> __Method_NextRound = new aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.Round, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "NextRound",
        __Marshaller_Round,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.Round, global::Google.Protobuf.WellKnownTypes.Empty> __Method_NextTerm = new aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.Round, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "NextTerm",
        __Marshaller_Round,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.TinyBlockInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateTinyBlockInformation = new aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.TinyBlockInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "UpdateTinyBlockInformation",
        __Marshaller_TinyBlockInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.ConsensusInformation, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateConsensusInformation = new aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.ConsensusInformation, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "UpdateConsensusInformation",
        __Marshaller_ConsensusInformation,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.SInt32Value, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetMaximumMinersCount = new aelf::Method<global::AElf.Types.SInt32Value, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetMaximumMinersCount",
        __Marshaller_aelf_SInt32Value,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt32Value> __Method_GetMaximumBlocksCount = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt32Value>(
        aelf::MethodType.Action,
        __ServiceName,
        "GetMaximumBlocksCount",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_SInt32Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.MinerList> __Method_GetCurrentMinerList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.MinerList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCurrentMinerList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_MinerList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.PubkeyList> __Method_GetCurrentMinerPubkeyList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.PubkeyList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCurrentMinerPubkeyList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_PubkeyList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.MinerListWithRoundNumber> __Method_GetCurrentMinerListWithRoundNumber = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.MinerListWithRoundNumber>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCurrentMinerListWithRoundNumber",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_MinerListWithRoundNumber);

    static readonly aelf::Method<global::AElf.Types.SInt64Value, global::AElf.Contracts.Consensus.AEDPoS.Round> __Method_GetRoundInformation = new aelf::Method<global::AElf.Types.SInt64Value, global::AElf.Contracts.Consensus.AEDPoS.Round>(
        aelf::MethodType.View,
        __ServiceName,
        "GetRoundInformation",
        __Marshaller_aelf_SInt64Value,
        __Marshaller_Round);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value> __Method_GetCurrentRoundNumber = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCurrentRoundNumber",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_SInt64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.Round> __Method_GetCurrentRoundInformation = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.Round>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCurrentRoundInformation",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Round);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.Round> __Method_GetPreviousRoundInformation = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.Round>(
        aelf::MethodType.View,
        __ServiceName,
        "GetPreviousRoundInformation",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Round);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value> __Method_GetCurrentTermNumber = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCurrentTermNumber",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_SInt64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value> __Method_GetCurrentWelfareReward = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCurrentWelfareReward",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_SInt64Value);

    static readonly aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.GetMinerListInput, global::AElf.Contracts.Consensus.AEDPoS.MinerList> __Method_GetMinerList = new aelf::Method<global::AElf.Contracts.Consensus.AEDPoS.GetMinerListInput, global::AElf.Contracts.Consensus.AEDPoS.MinerList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMinerList",
        __Marshaller_GetMinerListInput,
        __Marshaller_MinerList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.MinerList> __Method_GetPreviousMinerList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.MinerList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetPreviousMinerList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_MinerList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value> __Method_GetMinedBlocksOfPreviousTerm = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMinedBlocksOfPreviousTerm",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_SInt64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue> __Method_GetNextMinerPubkey = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue>(
        aelf::MethodType.View,
        __ServiceName,
        "GetNextMinerPubkey",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_StringValue);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue> __Method_GetCurrentMinerPubkey = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCurrentMinerPubkey",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_StringValue);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.BoolValue> __Method_IsCurrentMiner = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.BoolValue>(
        aelf::MethodType.View,
        __ServiceName,
        "IsCurrentMiner",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_BoolValue);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value> __Method_GetNextElectCountDown = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetNextElectCountDown",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_SInt64Value);

    static readonly aelf::Method<global::AElf.Types.SInt64Value, global::AElf.Contracts.Consensus.AEDPoS.Round> __Method_GetPreviousTermInformation = new aelf::Method<global::AElf.Types.SInt64Value, global::AElf.Contracts.Consensus.AEDPoS.Round>(
        aelf::MethodType.View,
        __ServiceName,
        "GetPreviousTermInformation",
        __Marshaller_aelf_SInt64Value,
        __Marshaller_Round);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.Consensus.AEDPoS.AedposContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Contracts.Consensus.AEDPoS.AedposContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class AEDPoSContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Contracts.Consensus.AEDPoS.InitialAElfConsensusContractInput, global::Google.Protobuf.WellKnownTypes.Empty> InitialAElfConsensusContract
      {
        get { return __factory.Create(__Method_InitialAElfConsensusContract); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Consensus.AEDPoS.Round, global::Google.Protobuf.WellKnownTypes.Empty> FirstRound
      {
        get { return __factory.Create(__Method_FirstRound); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Consensus.AEDPoS.UpdateValueInput, global::Google.Protobuf.WellKnownTypes.Empty> UpdateValue
      {
        get { return __factory.Create(__Method_UpdateValue); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Consensus.AEDPoS.Round, global::Google.Protobuf.WellKnownTypes.Empty> NextRound
      {
        get { return __factory.Create(__Method_NextRound); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Consensus.AEDPoS.Round, global::Google.Protobuf.WellKnownTypes.Empty> NextTerm
      {
        get { return __factory.Create(__Method_NextTerm); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Consensus.AEDPoS.TinyBlockInput, global::Google.Protobuf.WellKnownTypes.Empty> UpdateTinyBlockInformation
      {
        get { return __factory.Create(__Method_UpdateTinyBlockInformation); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Consensus.AEDPoS.ConsensusInformation, global::Google.Protobuf.WellKnownTypes.Empty> UpdateConsensusInformation
      {
        get { return __factory.Create(__Method_UpdateConsensusInformation); }
      }

      public aelf::IMethodStub<global::AElf.Types.SInt32Value, global::Google.Protobuf.WellKnownTypes.Empty> SetMaximumMinersCount
      {
        get { return __factory.Create(__Method_SetMaximumMinersCount); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt32Value> GetMaximumBlocksCount
      {
        get { return __factory.Create(__Method_GetMaximumBlocksCount); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.MinerList> GetCurrentMinerList
      {
        get { return __factory.Create(__Method_GetCurrentMinerList); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.PubkeyList> GetCurrentMinerPubkeyList
      {
        get { return __factory.Create(__Method_GetCurrentMinerPubkeyList); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.MinerListWithRoundNumber> GetCurrentMinerListWithRoundNumber
      {
        get { return __factory.Create(__Method_GetCurrentMinerListWithRoundNumber); }
      }

      public aelf::IMethodStub<global::AElf.Types.SInt64Value, global::AElf.Contracts.Consensus.AEDPoS.Round> GetRoundInformation
      {
        get { return __factory.Create(__Method_GetRoundInformation); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value> GetCurrentRoundNumber
      {
        get { return __factory.Create(__Method_GetCurrentRoundNumber); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.Round> GetCurrentRoundInformation
      {
        get { return __factory.Create(__Method_GetCurrentRoundInformation); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.Round> GetPreviousRoundInformation
      {
        get { return __factory.Create(__Method_GetPreviousRoundInformation); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value> GetCurrentTermNumber
      {
        get { return __factory.Create(__Method_GetCurrentTermNumber); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value> GetCurrentWelfareReward
      {
        get { return __factory.Create(__Method_GetCurrentWelfareReward); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Consensus.AEDPoS.GetMinerListInput, global::AElf.Contracts.Consensus.AEDPoS.MinerList> GetMinerList
      {
        get { return __factory.Create(__Method_GetMinerList); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Consensus.AEDPoS.MinerList> GetPreviousMinerList
      {
        get { return __factory.Create(__Method_GetPreviousMinerList); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value> GetMinedBlocksOfPreviousTerm
      {
        get { return __factory.Create(__Method_GetMinedBlocksOfPreviousTerm); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue> GetNextMinerPubkey
      {
        get { return __factory.Create(__Method_GetNextMinerPubkey); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue> GetCurrentMinerPubkey
      {
        get { return __factory.Create(__Method_GetCurrentMinerPubkey); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.BoolValue> IsCurrentMiner
      {
        get { return __factory.Create(__Method_IsCurrentMiner); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.SInt64Value> GetNextElectCountDown
      {
        get { return __factory.Create(__Method_GetNextElectCountDown); }
      }

      public aelf::IMethodStub<global::AElf.Types.SInt64Value, global::AElf.Contracts.Consensus.AEDPoS.Round> GetPreviousTermInformation
      {
        get { return __factory.Create(__Method_GetPreviousTermInformation); }
      }

    }
  }
}
#endregion

