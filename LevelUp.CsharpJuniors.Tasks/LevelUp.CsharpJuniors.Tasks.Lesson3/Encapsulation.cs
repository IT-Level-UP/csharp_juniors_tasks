namespace LevelUp.CsharpJuniors.Tasks.Lesson3
{
    internal class Encapsulation
    {
        private readonly string _testField = "testFieldValue";
        public string? GetOnlyTestValue { get; init; }
    }

    internal class Sandbox
    {
        public void PlayWithEncapsulation()
        {
            var encapsulation = new Encapsulation { GetOnlyTestValue = "123" };
            // encapsulation._testField = "";

            var student = new Student();
            student.Name = "Ivan";

            var service = new NotificationService();
            service.SendNotification("ivan@test.com", "hello");
        }
    }

    record Student
    {
        public string Name { get; set; } = string.Empty;
    }

    internal class NotificationService
    {
        private readonly string _smtpServerAddress = "emailServer@test.com";
        
        public void SendNotification(string email, string body)
        {
        }
    }
}
