using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x0200000B RID: 11
    public class InteractionWorker_PTD04ajDT : InteractionWorker
    {
        // Token: 0x06000013 RID: 19 RVA: 0x000023F0 File Offset: 0x000005F0
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTD04aj) &&
                initiator.relations.OpinionOf(recipient) >= 30)
            {
                return 0.1f;
            }

            return 0f;
        }
    }
}