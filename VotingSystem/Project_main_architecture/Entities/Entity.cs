using Npgsql.Internal.TypeHandlers.DateTimeHandlers;
using System.Data.SqlTypes;

namespace VotingSystem.Project_main_architecture.Entities
{
    public class Entity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SqlDateTime CreationDate { get; set; }

    }
}
