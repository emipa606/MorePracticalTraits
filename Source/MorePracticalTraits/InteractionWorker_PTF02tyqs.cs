using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x02000008 RID: 8
    public class InteractionWorker_PTF02tyqs : InteractionWorker
    {
        // Token: 0x0600000D RID: 13 RVA: 0x000021B0 File Offset: 0x000003B0
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(MorePracticalTraitsDefOf.PTF02tyqs))
            {
                return 0.1f;
            }

            return 0f;
        }
    }
}