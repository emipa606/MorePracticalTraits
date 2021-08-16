using RimWorld;
using Verse;

namespace MorePracticalTraits
{
    // Token: 0x02000012 RID: 18
    public class ThoughtWorker_TitleSeniority : ThoughtWorker
    {
        // Token: 0x0600001F RID: 31 RVA: 0x000026EE File Offset: 0x000008EE
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            return true;
        }

        // Token: 0x06000020 RID: 32 RVA: 0x000026EE File Offset: 0x000008EE
        protected override ThoughtState CurrentSocialStateInternal(Pawn p, Pawn otherPawn)
        {
            return true;
        }

        // Token: 0x06000021 RID: 33 RVA: 0x000026F6 File Offset: 0x000008F6
        public override string PostProcessLabel(Pawn p, string label)
        {
            if (p.royalty.MainTitle() != null)
            {
                label = label + "(" + p.royalty.MainTitle().GetLabelFor(p) + ")";
            }

            return label;
        }

        // Token: 0x06000022 RID: 34 RVA: 0x0000272C File Offset: 0x0000092C
        public override float MoodMultiplier(Pawn p)
        {
            if (p.royalty.MainTitle() != null)
            {
                return (p.royalty.MainTitle().seniority - 200) * 0.01f;
            }

            return -3f;
        }
    }
}