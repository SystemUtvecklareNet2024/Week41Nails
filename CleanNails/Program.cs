namespace CleanNails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test of nails.
            List<Nail> nails = NailHelper.GetFingerNails();

            foreach (Nail nail in nails)
            {
                Console.WriteLine($"CurrentLength: {nail.CurrentLength:F1}" +
                    $" GrowRate: {nail.DailyGrowRate}" +
                    $" PrefferedLength: {nail.PreferredLength:F1}" +
                    $" Finger: {nail.RightOrLeft} {nail.TypeOfFingerOrToe}" +
                    $" Color: {nail.Color}");
            }

            // End test.

        }
    }
}