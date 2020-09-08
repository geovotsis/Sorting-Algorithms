using Assignment4.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please make your CMD window full screen to be able to see the list Better");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to Continue");
            Console.ReadLine();
            Console.Clear();

            SyntheticData db = new SyntheticData();

            var newList = new List<Shirt>(db.Shirts);

            Console.WriteLine("List NOT sorted yet!");

            foreach (var item in newList)
            {
                item.Output();
            }

            Console.WriteLine("Press any key to Continue");
            Console.ReadLine();
            Console.Clear();

            // Bubble Sort
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            BubbleSort.SortBySizeAsc(newList);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BUBBLESORT");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("List Sorted Ascending By Size!!!");

            foreach (var item in newList)
            {
                item.Output();
            }

            Console.WriteLine("Press any other key to Continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            BubbleSort.SortBySizeDesc(newList);
            Console.WriteLine("List Sorted Descending By Size!!!");

            foreach (var item in newList)
            {
                item.Output();
            }

            Console.WriteLine("Keep your hand to the keyboard,Press another key");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            BubbleSort.SortByColorAsc(newList);
            Console.WriteLine("List Sorted Ascending By Color!!!");

            foreach (var item in newList)
            {
                item.Output();
            }

            Console.WriteLine("You wanted 24 different sortings, press it");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            BubbleSort.SortByColorDesc(newList);
            Console.WriteLine("List Sorted Descending By Color!!!");

            foreach (var item in newList)
            {
                item.Output();
            }

            Console.WriteLine("There are more where this came for,keep going");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            BubbleSort.SortByFabricAsc(newList);
            Console.WriteLine("List Sorted Ascending By Fabric!!!");

            foreach (var item in newList)
            {
                item.Output();
            }

            Console.WriteLine("Press any button ONE more time");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            BubbleSort.SortByFabricDesc(newList);
            Console.WriteLine("List Sorted Descending By Fabric!!!");

            foreach (var item in newList)
            {
                item.Output();
            }

            Console.WriteLine("Congratulations BubbleSort sorting ended 2 more sorting Algorithms to check before u grade");
            Console.ReadLine();
            Console.Clear();

            // Bucket Sort
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            var sortedListBucketSAsc = BucketSort.SortShirtsSize(newList);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BUCKETSORT only Ascending");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("List Sorted Ascending By Size!!!");

            foreach (var item in sortedListBucketSAsc)
            {
                item.Output();
            }

            Console.WriteLine("keep pressing");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            var sortedListBucketCAsc = BucketSort.SortShirtsColor(newList);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BUCKETSORT only Ascending");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("List Sorted Ascending By Color!!!");

            foreach (var item in sortedListBucketCAsc)
            {
                item.Output();
            }

            Console.WriteLine("still more to see");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            var sortedListBucketFAsc = BucketSort.SortShirtsFabric(newList);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BUCKETSORT only Ascending");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("List Sorted Ascending By Fabric!!!");

            foreach (var item in sortedListBucketFAsc)
            {
                item.Output();
            }

            Console.WriteLine("press those buttons");
            Console.ReadLine();
            Console.Clear();

            //QuickSort
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            QuickSort.SortShirtsColorDesc(newList);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("QUICKSORT only Descending");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("List Sorted Descending By Color!!!");

            foreach (var item in newList)
            {
                item.Output();
            }

            Console.WriteLine("Keep going");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            QuickSort.SortShirtsSizeDesc(newList);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("QUICKSORT only Descending");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("List Sorted Descending By Color!!!");

            foreach (var item in newList)
            {
                item.Output();
            }

            Console.WriteLine("Almost done");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            QuickSort.SortShirtsFabricDesc(newList);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("QUICKSORT only Descending");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("List Sorted Descending By Color!!!");

            foreach (var item in newList)
            {
                item.Output();
            }

            Console.WriteLine("Last one");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            Console.WriteLine("Press any key to continue . . . after that program will end");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            Console.WriteLine("Press any key to continue . . . seriously its the last one you will press ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

            

           



        }
    }
}
