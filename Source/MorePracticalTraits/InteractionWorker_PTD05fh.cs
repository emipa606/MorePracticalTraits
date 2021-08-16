using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x02000006 RID: 6
    public class InteractionWorker_PTD05fh : InteractionWorker
    {
        // Token: 0x06000009 RID: 9 RVA: 0x00002128 File Offset: 0x00000328
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTD05fh) &&
                initiator.relations.OpinionOf(recipient) <= 30)
            {
                return 0.1f;
            }

            return 0f;
        }
    }
}