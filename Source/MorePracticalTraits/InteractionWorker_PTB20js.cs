using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x0200000E RID: 14
    public class InteractionWorker_PTB20js : InteractionWorker
    {
        // Token: 0x06000019 RID: 25 RVA: 0x000024BC File Offset: 0x000006BC
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (!initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTB20js) &&
                !initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTB21sm) &&
                !initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTC15zj) &&
                !initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTS04zrzz))
            {
                return 0f;
            }

            if (recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTB20js) ||
                recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTB21sm) ||
                recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTC15zj) ||
                recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTS04zrzz))
            {
                return 0f;
            }

            return 0.125f;
        }
    }
}