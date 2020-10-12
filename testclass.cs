using translator;
using Xunit;

public class testclass {
    [Fact]
    public void PassingAddTest() {
        Assert.Equal(4, Program.Add(2,2));
    }
}