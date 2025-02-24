﻿namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class CompleteThePattern16
{
    [Test]
    public void CompleteThePattern16Test()
    {
        var expected = "1";
        Assert.That(CompleteThePattern16Task.Pattern(1), Is.EqualTo(expected));
      
        expected = "22\n21";
        Assert.That(CompleteThePattern16Task.Pattern(2), Is.EqualTo(expected));

        expected = "333\n322\n321";
        Assert.That(CompleteThePattern16Task.Pattern(3), Is.EqualTo(expected));

        expected = "7777777\n7666666\n7655555\n7654444\n7654333\n7654322\n7654321";
        Assert.That(CompleteThePattern16Task.Pattern(7), Is.EqualTo(expected));

        expected = "77777777777777777\n76666666666666666\n76555555555555555\n76544444444444444\n76543333333333333\n76543222222222222\n76543211111111111\n76543210000000000\n76543210999999999\n76543210988888888\n76543210987777777\n76543210987666666\n76543210987655555\n76543210987654444\n76543210987654333\n76543210987654322\n76543210987654321";
        Assert.That(CompleteThePattern16Task.Pattern(17), Is.EqualTo(expected));

        expected = "777777777777777777777777777\n766666666666666666666666666\n765555555555555555555555555\n765444444444444444444444444\n765433333333333333333333333\n765432222222222222222222222\n765432111111111111111111111\n765432100000000000000000000\n765432109999999999999999999\n765432109888888888888888888\n765432109877777777777777777\n765432109876666666666666666\n765432109876555555555555555\n765432109876544444444444444\n765432109876543333333333333\n765432109876543222222222222\n765432109876543211111111111\n765432109876543210000000000\n765432109876543210999999999\n765432109876543210988888888\n765432109876543210987777777\n765432109876543210987666666\n765432109876543210987655555\n765432109876543210987654444\n765432109876543210987654333\n765432109876543210987654322\n765432109876543210987654321";
        Assert.That(CompleteThePattern16Task.Pattern(27), Is.EqualTo(expected));
      
        expected = "";
        Assert.That(CompleteThePattern16Task.Pattern(0), Is.EqualTo(expected));

        expected = "";
        Assert.That(CompleteThePattern16Task.Pattern(-89), Is.EqualTo(expected));
    }
}