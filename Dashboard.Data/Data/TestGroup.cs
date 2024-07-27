using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Data.Data
{
    public enum TestType
    {
        Passed,
        Failed,
        Other
    }

    public class TestGroup
    {
        public TestGroup() { }
        public TestGroup(TestType _testType, int _testCount)
        {
            TestType = _testType;
            TestCount = _testCount;
        }


        public int Id { get; set; }
        
        [NotMapped]
        private TestType testType;
        public TestType TestType
        {
            get
            {
                return this.testType;
            }
            set
            {
                this.TestTypeString = Enum.GetName(value.GetType(), value) ?? "";
                this.testType = value;
            }
        }
        [NotMapped]
        public string TestTypeString { get; set; }
        public int TestCount { get; set; } = 0;


        public int TestRunId { get; set; }
        public TestRun TestRun { get; set; } = null!;
    }
}
