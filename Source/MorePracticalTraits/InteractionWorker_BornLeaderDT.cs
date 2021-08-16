using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x0200000A RID: 10
    public class InteractionWorker_BornLeaderDT : InteractionWorker
    {
        // Token: 0x06000011 RID: 17 RVA: 0x00002264 File Offset: 0x00000464
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (!initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTS03tslx) &&
                !initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTS06fkzs) &&
                !initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTE08wlkjdsz) &&
                !initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTE09gdxwlb) &&
                !initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTC15zj) &&
                !initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTS07ds))
            {
                return 0f;
            }

            if (recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTS03tslx) ||
                recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTS06fkzs) ||
                recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTE08wlkjdsz) ||
                recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTE09gdxwlb) ||
                recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTC15zj) ||
                recipient.story.traits.HasTrait(MorePracticalTraitsDefOf.PTS07ds))
            {
                return 0f;
            }

            if (recipient.mindState.mentalBreaker.BreakMinorIsImminent ||
                recipient.mindState.mentalBreaker.BreakMajorIsImminent ||
                recipient.mindState.mentalBreaker.BreakExtremeIsImminent ||
                recipient.mindState.mentalBreaker.BreakExtremeIsApproaching)
            {
                return 0.15f;
            }

            return 0f;
        }
    }
}