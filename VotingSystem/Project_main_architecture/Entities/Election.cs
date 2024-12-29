using System.Data.SqlTypes;

namespace VotingSystem.Project_main_architecture.Entities
{
    public class Election
    {

        public bool Open {  get; set; }
        public SqlDateTime StartDate { get; set; }
        public SqlDateTime EndDate { get; set; }
        public Candidate.CandidateCategory[] LegalCandidates { get; set; }         
        Voter.VoterCategory[] LegalVoters { get; set; }
        public Candidate[] AllowedCandidates { get; set; } //from db
        Voter[] AllowedVoters { get; set; } //from db
    }
}
