namespace DiamondKata.Tests
{
    public class DiamondTests
    {
        [Fact]
        public void A_should_give_singelton_diamond()
        {
            Assert.Equal("A\n", Diamond.Create('A'));
        }

        [Fact]
        public void B_should_give_full_diamond()
        {
            Assert.Equal(" A\nB B\n A\n", Diamond.Create('B'));
        }

        [Fact]
        public void C_should_give_full_diamond()
        {
            Assert.Equal("  A\n B B\nC   C\n B B\n  A\n", Diamond.Create('C'));
        }
    }
}