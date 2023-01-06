namespace DiamondKata.Tests
{
    public class DiamonTests
    {
        [Fact]
        public void A_should_give_singelton_diamond()
        {
            Assert.Equal("A", Diamond.Create('A'));
        }
    }
}