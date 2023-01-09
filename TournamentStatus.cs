namespace mtgtour;

public class TournamentStatus : ValueObject<TournamentStatus>
{
    public int CurrentStage { get; }
    public bool IsFinished { get; }

    protected override bool EqualsCore(TournamentStatus other) 
    {
        return CurrentStage == other.CurrentStage
            && IsFinished == other.IsFinished;
    }

    protected override int GetHashCodeCore() 
    {
        unchecked
        {
            int hashCode = 17;
            hashCode = hashCode * 31 + CurrentStage.GetHashCode();
            hashCode = hashCode * 31 + IsFinished.GetHashCode();
            return hashCode;
        }
    }
}