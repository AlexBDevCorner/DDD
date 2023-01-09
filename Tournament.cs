namespace mtgtour;

public class Tournament : Entity 
{
    public string Rules { get; }

    public List<Creature> Participants { get; }

    public TournamentStatus Status { get; }

    public string CurrentResults { get; }

    public string GetFinalResults() 
    {
        return CurrentResults;
    }

    public void RunNextStage() 
    {

    }
}