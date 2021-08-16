using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x02000009 RID: 9
    public class InteractionWorker_ChitChatWLKJ : InteractionWorker
    {
        // Token: 0x0600000F RID: 15 RVA: 0x000021E4 File Offset: 0x000003E4
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTE06wlkjjm) ||
                recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTE06wlkjjm))
            {
                return 0.1f;
            }

            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTE07wlkjcm) ||
                recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTE07wlkjcm))
            {
                return 0.1f;
            }

            return 0f;
        }
    }
}