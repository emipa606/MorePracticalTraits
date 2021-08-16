using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x02000002 RID: 2
    public class InteractionWorker_PTD01bj : InteractionWorker
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTD01bj))
            {
                return 0.075f;
            }

            return 0f;
        }
    }
}