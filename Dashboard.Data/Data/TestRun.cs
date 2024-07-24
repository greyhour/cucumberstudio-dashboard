using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Data.Data
{
    public class TestRun
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ProjectFK")]
        public Project Project { get; set; }

        public int ForeignId { get; set; }

        public string Name { get; set; }

        public int PassedTests { get; set; } = 0;

        public int FailedTests { get; set; } = 0;

        public int OtherTests { get; set; } = 0;
    }
}
