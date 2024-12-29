namespace VotingSystem.Project_main_architecture.Entities
{
    public class Party : Entity
    {
        List<Candidate> candidates {  get; set; }
        Candidate Leader { get; set; }

        int NumOfVotes {  get; set; } //get from db. by all votes of candidates combined
    }
}
