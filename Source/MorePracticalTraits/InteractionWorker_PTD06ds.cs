using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x02000007 RID: 7
    public class InteractionWorker_PTD06ds : InteractionWorker
    {
        // Token: 0x0600000B RID: 11 RVA: 0x0000216C File Offset: 0x0000036C
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTD06ds) &&
                initiator.relations.OpinionOf(recipient) <= 30)
            {
                return 0.1f;
            }

            return 0f;
        }
    }
}