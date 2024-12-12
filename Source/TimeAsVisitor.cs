using Verse;
using RimWorld;

namespace TimeAsSlave
{
    public class RecordWorker_TimeAsVisitor : RecordWorker
    {
        public override bool ShouldMeasureTimeNow(Pawn pawn)
        {
            if( pawn.Faction == Faction.OfPlayer )
                return false;
            if( pawn.IsPrisoner )
                return false;
            if( pawn.Faction?.HostileTo( Faction.OfPlayer ) ?? true )
                return false;
            return true;
        }
    }
}
