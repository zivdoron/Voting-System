using System.Data.SqlTypes;

namespace VotingSystem.Project_main_architecture.Entities
{
    public class Voter : Entity
    {
        public Candidate VotedFor {  get; set; }
        public VoterCategory Category {  get; set; }
        public SqlDateTime BirthDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public enum VoterCategory { }
    }
}
