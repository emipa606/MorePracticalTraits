using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x0200000D RID: 13
    public class InteractionWorker_PTD06dsDT : InteractionWorker
    {
        // Token: 0x06000017 RID: 23 RVA: 0x00002478 File Offset: 0x00000678
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTD06ds) &&
                initiator.relations.OpinionOf(recipient) > 30)
            {
                return 0.1f;
            }

            return 0f;
        }
    }
}