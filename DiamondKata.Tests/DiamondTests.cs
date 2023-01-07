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
        public void B_should_give_full_diamond_with_underscores_for_middle_gap()
        {
            Assert.Equal("A\nB_B\nA\n", Diamond.Create('B'));
        }

        [Fact]
        public void C_should_give_full_diamond_with_underscores_for_middle_gap()
        {
            Assert.Equal("A\nB_B\nC___C\nB_B\nA\n", Diamond.Create('C'));
        }
    }
}