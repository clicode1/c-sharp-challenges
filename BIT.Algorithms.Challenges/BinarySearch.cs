namespace BIT.Algorithms.Challenges
{
	public static class BinarySearch
	{
		static void Example()
		{
			// binary search (or binary chop) o(log n) is a Logarithmic algorithm.   
			// Doubling the data only means it needs to do one extra chop.

			int[] data = Enumerable
				.Range(0, 120).ToArray();

			int find = 11;
			int length = data.Length;
			Console.WriteLine(string.Format("Array contains '{0}' items.", data.Length - 1));

			int low = 0;
			int high = data.Length - 1;
			var checkCnt = 0;
			while (low <= high)
			{
				checkCnt++;
				var mid = (low + high) / 2;
				if (find == data[mid])
				{
					Console.WriteLine(string.Format("{0} can be found at number '{1}'", find, mid));
					break;
				}
				else if (find < data[mid])
					high = mid - 1;
				else
					low = mid + 1;
			}
			Console.WriteLine(string.Format("I preformed '{0}' checks", checkCnt));
			Console.ReadLine();
		}
	}
}