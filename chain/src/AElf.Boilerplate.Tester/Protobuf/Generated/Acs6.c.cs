// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs6.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using aelf = global::AElf.CSharp.Core;

namespace Acs6 {

  #region Events
  internal partial class RandomNumberRequestHandled : aelf::IEvent<RandomNumberRequestHandled>
  {
    public global::System.Collections.Generic.IEnumerable<RandomNumberRequestHandled> GetIndexed()
    {
      yield break;
    }

    public RandomNumberRequestHandled GetNonIndexed()
    {
      return new RandomNumberRequestHandled
      {
        Requester = Requester,
        TokenHash = TokenHash,
        BlockHeight = BlockHeight,
      };
    }
  }

  internal partial class RandomNumberGenerated : aelf::IEvent<RandomNumberGenerated>
  {
    public global::System.Collections.Generic.IEnumerable<RandomNumberGenerated> GetIndexed()
    {
      yield break;
    }

    public RandomNumberGenerated GetNonIndexed()
    {
      return new RandomNumberGenerated
      {
        TokenHash = TokenHash,
        RandomHash = RandomHash,
      };
    }
  }

  #endregion
}
#endregion

