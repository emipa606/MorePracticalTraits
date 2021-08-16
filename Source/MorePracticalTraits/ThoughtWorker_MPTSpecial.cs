using System.Linq;
using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x02000011 RID: 17
    public class ThoughtWorker_MPTSpecial : ThoughtWorker
    {
        // Token: 0x0600001D RID: 29 RVA: 0x000025A8 File Offset: 0x000007A8
        protected override ThoughtState CurrentSocialStateInternal(Pawn pawn, Pawn other)
        {
            var modEX = def.GetModExtension<MPTModExtension>();
            if (modEX == null)
            {
                return false;
            }

            if (!other.RaceProps.Humanlike || !RelationsUtility.PawnsKnowEachOther(pawn, other))
            {
                return false;
            }

            if (!modEX.validWithDisfigured && RelationsUtility.IsDisfigured(other))
            {
                return false;
            }

            if (modEX.sameFactionOnly && pawn.Faction != other.Faction)
            {
                return false;
            }

            if (modEX.requireCapacityOfPawn != null && !pawn.health.capacities.CapableOf(modEX.requireCapacityOfPawn))
            {
                return false;
            }

            if (modEX.requireCapacityOfOther != null && !pawn.health.capacities.CapableOf(modEX.requireCapacityOfOther))
            {
                return false;
            }

            if ((from x in other.story.traits.allTraits
                where modEX.triggerTraits.Contains(x.def)
                select x).Any())
            {
                return true;
            }

            return false;
        }
    }
}