using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Data.Data
{
    public class TestRun
    {
        public TestRun() { }
        public TestRun(int _projectId, int _foreignId, string _name) 
        {
            ProjectId = _projectId;
            ForeignId = _foreignId;
            Name = _name;
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        public int ForeignId { get; set; }
        public string Name { get; set; }

        public ICollection<TestGroup> TestGroups { get; internal set; } = new List<TestGroup>();
    }
}
