//namespace BIT.Algorithms.Challenges
//{
//    public class LRU
//    {
//        public static (int, IEnumerable<int>) PaginateExample(int n, int s, int[] a)
//        {
//            LinkedList<List<int>> llist = new();

//            var elements = new List<int>();
//            elements.Add(a[0]);
//            var node = llist.AddFirst(elements);

//            int faults = 0;
//            foreach (int number in a)
//            {
//                List<int> temp;
//                if (node.Value.Contains(number))
//                {
//                    temp = node.Value;
//                    temp.Remove(number);
//                }
//                else
//                {
//                    faults++;
//                    temp = node.Value.SkipLast(1).ToList();
//                }

//                temp.Insert(0, number);
//                llist.AddAfter(node, new LinkedListNode<List<int>>(temp));

//                if (llist.Count > s)
//                {
//                    llist.RemoveFirst();
//                }
//            }
         
//            return (1, null);
//        }
//    }
//}

//	//      public bool SearchNode(LinkedList<List<int>> llist, LinkedListNode<List<int>> firstNode, LinkedListNode<List<int>> node, int capacityLeft, int numberToSearch)
//		//{
//  //          if (node.Value.Contains(numberToSearch))
//  //          {
//  //              var temp = node.Value;
//  //              temp.Remove(numberToSearch);
//  //              temp.Insert(0, numberToSearch);
//  //              llist.AddAfter(firstNode, new LinkedListNode<List<int>>(temp));
//  //          }
//		//	else
//		//	{
//  //              faults++;
//  //              SearchNode(llist, firstNode, node.Previous, capacityLeft - 1, numberToSearch);
//  //          }
//  //      }
//	}

//    //Given:								//Output:
//    //N: no of elements						//PF: No.of page faults.
//    //S: max.capacity of cache				//State of LRU cache.
//    //a[i]: N no.of integers

//    //Page falut occures when the element is not found in the cache.
//    //In LRU algo , the least recently elements is removed first when no free space is avalaible in cache.

//    //Input Format							//Output Format

//    //N: no of elements						//PF:page fault
//    //S: max.capacity of cache				//elements in LRU cache.
//    //a[i]: N no. of integers
//    //Constraints

//    //N, S & a[i] all are integers

//    //Sample Input							//Sample Output

//    //10 4									//7	
//    //1 2 3 2 5 3 4 5 8 9					//9 8 5 4

//    //Explanation

//    //Initially cache will be empty.

//    //1 _ _ _      1    (_, _, 1)
//    //2 1 _ _      2    (_, _, 2)
//    //3 2 1 _      3    (_, _, 3)
//    //2 3 1 _      3    (_, _, 2)
//    //5 2 3 1      4    (_, _, 5)
//    //3 5 2 1      4    (_, _, 3)
//    //4 3 5 2      5    (_, _, 4)
//    //5 4 3 2      5    (_, _, 5)
//    //8 5 4 3      6    (_, _, 8)
//    //9 8 5 4      7    (_, _, 9)
//    //therefore: pagefaults = 7.state : 9 8 5 4.

//    //class Program
//    //{
//    //    #region Methods

//    //    static void lru_OnRemoveItem(LRUCache<int, Image<Gray, byte>> sender, KeyValuePair<int, Image<Gray, byte>> item, bool userRequested)
//    //    {
//    //        sender.Oldest.Value.Dispose();
//    //        GC.Collect();

//    //        Console.WriteLine("Kicked out!");
//    //    }

//    //    static void Main(string[] args)
//    //    {
//    //        if (IntPtr.Size == 4)
//    //        {
//    //            Console.ForegroundColor = ConsoleColor.Red;
//    //            Console.WriteLine("Warning: the application is 32-bit which may cause OutOfMemoryException due to 2GiB limit.");
//    //            Console.ResetColor();
//    //        }

//    //        //testLRUCache();  //uncomment to run
//    //        testLazyMemCache();
//    //    }

//    //    /// <summary>
//    //    /// Creates and tests lazy memory cache where elements are constructed on demand and evicted based on LRU strategy only if the RAM usage above specified limits.
//    //    /// </summary>
//    //    static void testLazyMemCache()
//    //    {
//    //        ComputerInfo computerInfo = new ComputerInfo(); //reference to Microsoft.VisualBasic assembly.

//    //        //construction
//    //        var memCache = new LazyMemoryCache<int, Image<Gray, int>>
//    //          (
//    //           (currentSize) =>
//    //           {
//    //               var occupied = computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory;
//    //               var occupiedPercentage = (float)occupied / computerInfo.TotalPhysicalMemory;

//    //               //WATCH OUT! You can get OutOfMemoryException although the RAM is not full:
//    //               //when creating fields with zeros I assume there are some OS optimizations like block sharing
//    //               //if you compile this as 32-bit (when it consumes 2 GiB it will throw OutOfMemoryException)
//    //               if (occupiedPercentage > 0.45)
//    //                   return true;

//    //               return false;
//    //           },

//    //            (img) => (ulong)(img.Stride * img.Height),

//    //            //set false to not to call GC.Collect() when an item is evicted => may fill more RAM than it has been set, but shortens delays caused by GC
//    //            forceCollectionOnRemoval: true
//    //           );

//    //        Console.WriteLine("Filling lazy cache (with constructors)...");
//    //        const int MAX_KEY = 100;
//    //        //adding elements (you can also use stream as IEnumerable to populate cache)
//    //        for (int key = 0; key <= MAX_KEY; key++)
//    //        {
//    //            memCache.AddOrUpdate(key, () =>
//    //            {
//    //                //simulate getting image from a disc (slow operation)
//    //                var img = new Image<Gray, int>(640, 480);
//    //                img.SetValue(key);
//    //                Thread.Sleep(60);

//    //                return img;
//    //            },
//    //            (img) => { img.Dispose(); });
//    //        }

//    //        //accessing elements (run Task Manager to see memory allocation!)
//    //        Console.WriteLine("Accessing elements (run Task Manager to see memory allocation!):");
//    //        Random rand = new Random();
//    //        while (!Console.KeyAvailable)
//    //        {
//    //            var key = rand.Next(0, MAX_KEY + 1);
//    //            ILazy<Image<Gray, int>> lazyVal;
//    //            memCache.TryGetValue(key, out lazyVal);

//    //            Console.ForegroundColor = lazyVal.IsValueCreated ? ConsoleColor.Green : ConsoleColor.Red;
//    //            Image<Gray, int> val = null;
//    //            var elapsed = Diagnostics.MeasureTime(() =>
//    //            {
//    //                val = lazyVal.Value;
//    //            });

//    //            Console.Write("\r Accessing {0}. Access time: {1} ms.", key, elapsed);
//    //        }

//    //        //accessing elements (run Task Manager to see memory allocation!)
//    //        /*foreach (var item in memCache)
//    //        {
//    //             var lazyVal = item.Value;

//    //            Console.WriteLine(lazyVal.Value);
//    //            Console.WriteLine(memCache.HardFaults);
//    //        }*/
//    //    }

//    //    /// <summary>
//    //    /// Creates a new instance of LRU cache where elements are evicted based on least frequently usage.
//    //    /// </summary>
//    //    static void testLRUCache()
//    //    {
//    //        ComputerInfo computerInfo = new ComputerInfo(); //reference to Microsoft.VisualBasic assembly.

//    //        var lru = new LRUCache<int, Image<Gray, byte>>(
//    //                                                (currentSize) =>
//    //                                                {
//    //                                                    var occupied = computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory;
//    //                                                    var occupiedPercentage = (float)occupied / computerInfo.TotalPhysicalMemory;

//    //                                                    if (occupiedPercentage > 0.85)
//    //                                                        return true;

//    //                                                    return false;
//    //                                                },
//    //                                                (img) => (ulong)(img.Stride * img.Height));

//    //        lru.OnRemoveItem += lru_OnRemoveItem;

//    //        /***************** add some elements ****************/
//    //        var image = new Image<Gray, byte>(5 * 1024 * 1024, 1, 0);
//    //        image.SetValue(5 % 256);
//    //        lru.Add(1, image);

//    //        image = new Image<Gray, byte>(5 * 1024 * 1024, 1, 0);
//    //        image.SetValue(5 % 256);
//    //        lru.Add(1, image);
//    //        /***************** add some elements ****************/

//    //        List<Image<Gray, byte>> a = new List<Image<Gray, byte>>();

//    //        Random rand = new Random();

//    //        int i = 0;
//    //        while (i < 10000)
//    //        {
//    //            image = new Image<Gray, byte>(1024 * 1024, 1, 0);
//    //            image.SetValue(i % 256);
//    //            lru.Add(i, image);

//    //            //Thread.Sleep(1);
//    //            Console.WriteLine(computerInfo.AvailablePhysicalMemory / 1024 / 1024);
//    //            i++;
//    //        }

//    //        //discover more properties and methods!
//    //    }

//    //    #endregion Methods
//    //}

//    //class LRUCacheDemoConsole
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        LRUCache<int, int> lruCache = new LRUCache<int, int>(5);

//    //        Console.WriteLine(lruCache.Size());

//    //        lruCache.Insert(0, 10);
//    //        lruCache.Insert(1, 20);
//    //        lruCache.Insert(2, 30);
//    //        lruCache.Insert(3, 40);
//    //        lruCache.Insert(4, 50);

//    //        Console.WriteLine(lruCache.Size());
//    //        Console.WriteLine(lruCache.CacheFeed());

//    //        lruCache.GetItem(0);
//    //        lruCache.GetItem(1);
//    //        lruCache.GetItem(2);

//    //        Console.WriteLine(lruCache.Size());
//    //        Console.WriteLine(lruCache.CacheFeed());

//    //        lruCache.Insert(5, 60);
//    //        lruCache.Insert(6, 70);
//    //        lruCache.Insert(7, 80);
//    //        lruCache.Insert(8, 90);
//    //        lruCache.Insert(9, 100);

//    //        Console.WriteLine(lruCache.Size());
//    //        Console.WriteLine(lruCache.CacheFeed());
//    //    }
//    //}
