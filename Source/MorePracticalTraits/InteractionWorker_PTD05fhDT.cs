using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x0200000C RID: 12
    public class InteractionWorker_PTD05fhDT : InteractionWorker
    {
        // Token: 0x06000015 RID: 21 RVA: 0x00002434 File Offset: 0x00000634
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTD05fh) &&
                initiator.relations.OpinionOf(recipient) > 30)
            {
                return 0.075f;
            }

            return 0f;
        }
    }
}