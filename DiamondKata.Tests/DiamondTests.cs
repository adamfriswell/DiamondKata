namespace DiamondKata.Tests
{
    public class DiamondTests
    {
        [Fact]
        public void A_should_give_singelton_diamond()
        {
            Assert.Equal("A", Diamond.Create('A'));
        }

        [Fact]
        public void B_should_give_character_sequence()
        {
            Assert.Equal("AB", Diamond.Create('B'));
        }
    }
}