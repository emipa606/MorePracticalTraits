using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x02000005 RID: 5
    public class InteractionWorker_PTD04aj : InteractionWorker
    {
        // Token: 0x06000007 RID: 7 RVA: 0x000020F4 File Offset: 0x000002F4
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTD04aj))
            {
                return 0.1f;
            }

            return 0f;
        }
    }
}