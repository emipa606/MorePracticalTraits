using System.Collections.Generic;
using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x02000010 RID: 16
    public class MPTModExtension : DefModExtension
    {
        // Token: 0x04000016 RID: 22
        public PawnCapacityDef requireCapacityOfOther;

        // Token: 0x04000015 RID: 21
        public PawnCapacityDef requireCapacityOfPawn;

        // Token: 0x04000013 RID: 19
        public bool sameFactionOnly;

        // Token: 0x04000017 RID: 23
        public List<TraitDef> triggerTraits;

        // Token: 0x04000014 RID: 20
        public bool validWithDisfigured;
    }
}