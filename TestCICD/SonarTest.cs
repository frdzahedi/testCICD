namespace TestCICD;

public class SonarTest
{
    public void TestMethod()
    {
        int unusedNumber = 42;  // ← این خط مشکل‌دار است
                                // متغیر تعریف شده اما هیچ جا استفاده نمی‌شود
    }
}
