using FluentAssertions;

namespace CD;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var result = Python.Get_box_svg();

        result.Should().NotBeNullOrEmpty();
    }
}
