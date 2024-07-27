using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Data.Data
{
    public class Project
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ForeignId { get; set; }

        public ICollection<TestRun> TestRuns { get; internal set; } = new List<TestRun>();

        [NotMapped]
        public IList<TestGroup> TestGroups { get; internal set; } = new List<TestGroup>();
    }
}
