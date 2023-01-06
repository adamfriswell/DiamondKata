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
        public void B_should_give_full_diamond_letters()
        {
            Assert.Equal("A\nBB\nA\n", Diamond.Create('B'));
        }

        [Fact]
        public void C_should_should_give_full_diamond_letters()
        {
            Assert.Equal("A\nBB\nCCC\nBB\nA\n", Diamond.Create('C'));
        }
    }
}