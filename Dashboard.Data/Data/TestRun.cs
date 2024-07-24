using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Data.Data
{
    public class TestRun
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        public int ForeignId { get; set; }
        public string Name { get; set; }

        public int PassedTests { get; set; } = 0;
        public int FailedTests { get; set; } = 0;
        public int OtherTests { get; set; } = 0;
    }
}
