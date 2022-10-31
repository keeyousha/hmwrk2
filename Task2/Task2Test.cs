using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void FillWithAsterisksTest()
    {
        That(FillWithAsterisks("ab", 3), Is.EqualTo("a***b"));
        That(FillWithAsterisks("abcd", 2), Is.EqualTo("a**b**c**d"));
        That(FillWithAsterisks("*", 5), Is.EqualTo("*"));
    }

    [Test]
    public void TabulateSquaresTest()
    {
        That(TabulateSquares(3), Is.EqualTo("1  1\n2  4\n3  9"));
        That(TabulateSquares(4), Is.EqualTo(
@"1  1
2  4
3  9
4 16"));
        That(TabulateSquares(10), Is.EqualTo(
"1  1\n2  4\n3  9\n4 16\n5 25\n6 36\n7 49\n8 64\n9 81\n10 100"));
        
    }
}