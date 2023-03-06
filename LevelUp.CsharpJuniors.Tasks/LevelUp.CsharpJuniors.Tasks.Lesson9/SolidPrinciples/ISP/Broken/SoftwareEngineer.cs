namespace SolidPrinciples.ISP.Broken
{
    public class SoftwareEngineer : IItSpecialist
    {
        public void FillWorklogs()
        {
            Console.WriteLine("OK, working on it...");
        }

        public void WriteCode()
        {
             Console.WriteLine("OK, working on it...");
        }

        public void PrepareAnalytics()
        {
            throw new NotImplementedException();
        }

        public void TestCode()
        {
            throw new NotImplementedException();
        }
    }
}
