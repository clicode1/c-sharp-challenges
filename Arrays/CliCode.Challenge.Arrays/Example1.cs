namespace CliCode.Array
{
    public class Example1
    {
        static void Main()
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
                // process stream value
			}
        }
    }
}