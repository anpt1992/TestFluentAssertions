using FluentAssertions;

namespace TestFluentAssertions
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var b1 = new Blah { Id = 1, Description = "test1", Name = "HHH", Children = new List<string> { "3", "4", "5" }, Birthday = "2021" };
            var b2 = new Blah { Id = 1, Description = "test1", Name = "HHH", Children = new List<string> { "4", "5", "3" }, Birthday = "2023" };
            b2.Should().BeEquivalentTo(b1, options => options.Excluding(o => o.Birthday));
            //Assert.Equal(b1, b2);
        }
    }

    public class Blah
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Blah";
        public string? Description { get; set; }
        public IList<string> Children { get; set; } = new List<string>();
        public string Birthday { get; set; }
    }
}