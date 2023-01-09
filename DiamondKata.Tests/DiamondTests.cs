namespace DiamondKata.Tests
{
    public class DiamondTests
    {
        [Theory]
        [InlineData('A')]
        [InlineData('a')]
        public void A_should_give_singelton_diamond(char letter)
        {
            Assert.Equal("A\n", Diamond.Create(letter));
        }

        [Theory]
        [InlineData('B')]
        [InlineData('b')]
        public void B_should_give_full_diamond(char letter)
        {
            Assert.Equal(" A\nB B\n A\n", Diamond.Create(letter));
        }

        [Theory]
        [InlineData('C')]
        [InlineData('c')]
        public void C_should_give_full_diamond(char letter)
        {
            Assert.Equal("  A\n B B\nC   C\n B B\n  A\n", Diamond.Create(letter));
        }

        [Theory]
        [InlineData('1')]
        [InlineData('%')]
        public void Non_alphabetic_char_throws_exception(char letter)
        {
            Action act = () => Diamond.Create(letter);

            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Invalid input", exception.Message);
        }
    }
}