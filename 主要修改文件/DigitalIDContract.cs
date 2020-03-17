using System;
using AElf.Types;
using Google.Protobuf.WellKnownTypes;

namespace AElf.Contracts.DigitalIDContract
{
    public class DigitalIDContract : DigitalIDContractContainer.DigitalIDContractBase {
        public override Empty Initial(Empty input)
        {
            State.Stuffs[Hash.Empty] = new Stuff
            {
                Id = Hash.Empty,
                Ids = "",
                Name = "",
                Email = "",
                Key = "",
                Living = true
            };
            return new Empty();
        }

        public override Empty SetStuff(Stuff input)
        {
            Assert((State.Stuffs[input.Id] == null)||(State.Stuffs[input.Id].Key==input.Key),"Id already exists or password is wrong");
            State.Stuffs[input.Id] = input;
            return new Empty();
        }
        
        

        public override Stuff GetStuff(Hash input)
        {
            return State.Stuffs[input] ?? new Stuff();
        }
    }
}