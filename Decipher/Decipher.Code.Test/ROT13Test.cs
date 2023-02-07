namespace Decipher.Code.Test;

public class ROT13Test
{
    [Theory]
    [InlineData("ROT13 example.", "EBG13 rknzcyr.")]
    [InlineData("Guvf vf zl svefg EBG13 rkprepvfr!", "This is my first ROT13 excercise!")]
    [InlineData("klm", "xyz")]
    public void TestRot13(string expect, string input)
    {
        //abcdefghijklm
        //nopqrstuvwxyz
        //Arrange

        //Act
        var result = ROT13.Rot13(input);
        //Assert
        Assert.Equal(expect, result);
    }
}