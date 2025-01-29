using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class PasswordMaker
{
    [Test]
    public void TestUpperOnly()
    {
        bool upper = true, lower = false, digits = false;
        int len = 5;
        string password = PasswordMakerTask.MakePassword(len, upper, lower, digits);
        Assert.AreEqual(len, password.Length);
        Assert.IsTrue(password.All(char.IsUpper), "Password should contain only uppercase letters.");
        Assert.IsTrue(password.Distinct().Count() == len, "Password contains repeated characters.");
    }

    [Test]
    public void TestLowerOnly()
    {
        bool upper = false, lower = true, digits = false;
        int len = 5;
        string password = PasswordMakerTask.MakePassword(len, upper, lower, digits);
        Assert.AreEqual(len, password.Length);
        Assert.IsTrue(password.All(char.IsLower), "Password should contain only lowercase letters.");
        Assert.IsTrue(password.Distinct().Count() == len, "Password contains repeated characters.");
    }

    [Test]
    public void TestDigitsOnly()
    {
        bool upper = false, lower = false, digits = true;
        int len = 5;
        string password = PasswordMakerTask.MakePassword(len, upper, lower, digits);
        Assert.AreEqual(len, password.Length);
        Assert.IsTrue(password.All(char.IsDigit), "Password should contain only digits.");
        Assert.IsTrue(password.Distinct().Count() == len, "Password contains repeated characters.");
    }

    [Test]
    public void TestUpperAndLower()
    {
        bool upper = true, lower = true, digits = false;
        int len = 8;
        string password = PasswordMakerTask.MakePassword(len, upper, lower, digits);
        Assert.AreEqual(len, password.Length);
        Assert.IsTrue(password.Any(char.IsUpper) && password.Any(char.IsLower), "Password should contain both uppercase and lowercase letters.");
        Assert.IsTrue(password.Distinct().Count() == len, "Password contains repeated characters.");
    }

    [Test]
    public void TestUpperAndDigits()
    {
        bool upper = true, lower = false, digits = true;
        int len = 10;
        string password = PasswordMakerTask.MakePassword(len, upper, lower, digits);
        Assert.AreEqual(len, password.Length);
        Assert.IsTrue(password.Any(char.IsUpper) && password.Any(char.IsDigit), "Password should contain uppercase letters and digits.");
        Assert.IsTrue(password.Distinct().Count() == len, "Password contains repeated characters.");
    }

    [Test]
    public void TestLowerAndDigits()
    {
        bool upper = false, lower = true, digits = true;
        int len = 12;
        string password = PasswordMakerTask.MakePassword(len, upper, lower, digits);
        Assert.AreEqual(len, password.Length);
        Assert.IsTrue(password.Any(char.IsLower) && password.Any(char.IsDigit), "Password should contain lowercase letters and digits.");
        Assert.IsTrue(password.Distinct().Count() == len, "Password contains repeated characters.");
    }

    [Test]
    public void TestAllFlags()
    {
        bool upper = true, lower = true, digits = true;
        int len = 15;
        string password = PasswordMakerTask.MakePassword(len, upper, lower, digits);
        Assert.AreEqual(len, password.Length);
        Assert.IsTrue(password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit), "Password should contain uppercase letters, lowercase letters, and digits.");
        Assert.IsTrue(password.Distinct().Count() == len, "Password contains repeated characters.");
    }

    [Test]
    public void TestMinLength()
    {
        bool upper = true, lower = true, digits = true;
        int len = 1;
        string password = PasswordMakerTask.MakePassword(len, upper, lower, digits);
        Assert.AreEqual(len, password.Length);
        Assert.IsTrue(password.All(c => char.IsUpper(c) || char.IsLower(c) || char.IsDigit(c)), "Password should contain only alphanumeric characters.");
        Assert.IsTrue(password.Distinct().Count() == len, "Password contains repeated characters.");
    }

    [Test]
    public void TestMaxLength()
    {
        bool upper = true, lower = true, digits = true;
        int len = 50;
        string password = PasswordMakerTask.MakePassword(len, upper, lower, digits);
        Assert.AreEqual(len, password.Length);
        Assert.IsTrue(password.All(c => char.IsUpper(c) || char.IsLower(c) || char.IsDigit(c)), "Password should contain only alphanumeric characters.");
        Assert.IsTrue(password.Distinct().Count() == len, "Password contains repeated characters.");
    }
}