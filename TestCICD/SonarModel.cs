namespace TestCICD;

public class SonarModel
{
        public void ConnectToDatabase()
        {
            // SonarQube باید این را به عنوان "اعتبارنامه hardcoded" تشخیص دهد (S2068)
            string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=SuperSecret123!;";

            // کد زیر صرفاً برای جلوگیری از هشدار "متغیر استفاده نشده" است و روی خود آسیب‌پذیری تأثیری ندارد
            System.Console.WriteLine(connectionString);
        }
    }