// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs3.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using aelf = global::AElf.CSharp.Core;

namespace Acs3 {

  #region Events
  internal partial class ProposalCreated : aelf::IEvent<ProposalCreated>
  {
    public global::System.Collections.Generic.IEnumerable<ProposalCreated> GetIndexed()
    {
      yield break;
    }

    public ProposalCreated GetNonIndexed()
    {
      return new ProposalCreated
      {
        ProposalId = ProposalId,
      };
    }
  }

  internal partial class ProposalReleased : aelf::IEvent<ProposalReleased>
  {
    public global::System.Collections.Generic.IEnumerable<ProposalReleased> GetIndexed()
    {
      yield break;
    }

    public ProposalReleased GetNonIndexed()
    {
      return new ProposalReleased
      {
        ProposalId = ProposalId,
      };
    }
  }

  internal partial class OrganizationCreated : aelf::IEvent<OrganizationCreated>
  {
    public global::System.Collections.Generic.IEnumerable<OrganizationCreated> GetIndexed()
    {
      yield break;
    }

    public OrganizationCreated GetNonIndexed()
    {
      return new OrganizationCreated
      {
        OrganizationAddress = OrganizationAddress,
      };
    }
  }

  #endregion
}
#endregion

