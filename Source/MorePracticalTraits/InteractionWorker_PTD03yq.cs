using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x02000004 RID: 4
    public class InteractionWorker_PTD03yq : InteractionWorker
    {
        // Token: 0x06000005 RID: 5 RVA: 0x000020C0 File Offset: 0x000002C0
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTD03yq))
            {
                return 0.15f;
            }

            return 0f;
        }
    }
}