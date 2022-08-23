namespace CliCode.Challenge.Solutions.Arrays
{
    public static class SolutionExample1_A
    {
         public static void Main()
        {
            /**
             * Given a stream of integers create a method that will return the last 5 numbers and their average
             * 
             * i.e. stream 5, 2, 7, 6, 3, 5, 1, 8, 9, 0
             * 
             * 5 => 5, [5]
             * 2 => 3.5, [5,2]
             * 7 => 4.6667, [5, 2, 7]
             * 6 => 5, [5, 2, 7, 6]
             * 3 => 4.6, [5, 2, 7, 6, 3]
             * 5 => 4.6, [2, 7, 6, 3, 5]
             * 1 => 4.4, [7, 6, 3, 5, 1]
             * 8 => 4.6, [6, 3, 5, 1, 8]
             * 9 => 5.2, [3, 5, 1, 8, 9]
             * 0 => 4.6, [5, 1, 8, 9, 0]
             */

            var stream = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for(var i = 0; i < stream.Length; i++)
			{
                Avarage(stream[i]);
			}
        }

        static List<int> list = new List<int>();
        static short toTake = 5;

        private static void Avarage(int number)
		{
            decimal avarage = 0;

            list.Insert(0, number);

            if (list.Count() > 5)
                list.RemoveAt(5);
            

            avarage = Math.Round((decimal)list.Sum() / list.Count, 2);

            Console.WriteLine($"${number} => {avarage}, [{string.Join(",", list.TakeLast(toTake))}]");
		}
    }
}