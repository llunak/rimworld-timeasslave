using Verse;
using RimWorld;

namespace TimeAsSlave
{
    public class RecordWorker_TimeAsSlave : RecordWorker
    {
        public override bool ShouldMeasureTimeNow(Pawn pawn)
        {
            if (pawn.Faction == Faction.OfPlayer && !pawn.HasExtraHomeFaction() && pawn.IsSlave)
                return !pawn.IsPrisoner;
            return false;
        }
    }
}
