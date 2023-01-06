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
        public void B_should_repeat_characters()
        {
            Assert.Equal("A\nBB\n", Diamond.Create('B'));
        }

        [Fact]
        public void C_should_repeat_characters()
        {
            Assert.Equal("A\nBB\nCCC\n", Diamond.Create('C'));
        }
    }
}