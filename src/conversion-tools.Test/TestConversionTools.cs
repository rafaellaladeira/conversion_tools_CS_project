using Xunit;
using FluentAssertions;
using conversion_tools;
using System;

namespace conversion_tools.Test;

public class TestFirstRequirement{
    [Theory]
    [InlineData("1", 1)]
    public void TestConvertStrToInt(string entry, int expected)
    {
       ConversionTools instance = new();

       instance.strVariable.Should().Be(entry);
       var strTypeCheck = instance.strVariable is string;
       strTypeCheck.Should().Be(true);

       instance.ConvertStrToInt();

       instance.intVariable.Should().Be(expected);
       var intTypeCheck = instance.intVariable is int;
       intTypeCheck.Should().Be(true);
    }
}

public class TestSecondRequirement{
    [Theory]
    [InlineData("1.0", 1.0)]
    public void TestConvertStrToDouble(string entry, double expected)
    {
        ConversionTools instance = new();

        instance.strVariable.Should().Be(entry);
        var strTypeCheck = instance.strVariable is string;
        strTypeCheck.Should().Be(true);

        instance.ConvertStrToDouble();

        instance.doubleVariable.Should().Be(expected);
        var doubleTypeCheck = instance.doubleVariable is double;
        doubleTypeCheck.Should().Be(true);
    }
}

public class TestThirdRequirement{
    [Theory]
    [InlineData(1, "1")]
    public void TestConvertIntToStr(int entry, string expected)
    {
        throw new NotImplementedException();
    }
}

public class TestFourthRequirement{
    [Theory]
    [InlineData(4.1, "4.1")]
    public void TestConvertDoubleToStr(double entry, string expected)
    {
        throw new NotImplementedException();
    }
}
