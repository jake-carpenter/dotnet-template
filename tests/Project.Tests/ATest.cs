using Shouldly;

namespace Projects.Tests;

public class ATest
{
    [Test]
    [DisplayName("At least one test is needed or the test suite will fail...")]
    public void Test1()
    {
        true.ShouldBeTrue();
    }
}
