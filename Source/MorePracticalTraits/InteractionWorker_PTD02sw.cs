using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x02000003 RID: 3
    public class InteractionWorker_PTD02sw : InteractionWorker
    {
        // Token: 0x06000003 RID: 3 RVA: 0x0000208C File Offset: 0x0000028C
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTD02sw))
            {
                return 0.15f;
            }

            return 0f;
        }
    }
}