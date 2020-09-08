using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.SortingAlgorithms
{
    class BubbleSort
    {
        private static bool less(int value1, int value2)
        {
            return value1 < value2;
        }

        private static bool more(int value1, int value2)
        {
            return value1 > value2;
        }

        public static void SortBySizeAsc(List<Shirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (more((int)shirts[j].Size, (int)shirts[j + 1].Size))
                    {
                        // swap
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortBySizeDesc(List<Shirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (less((int)shirts[j].Size, (int)shirts[j + 1].Size))
                    {
                        // swap
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortShirtsAlternative(List<Shirt> shirts)
        {
            int size = shirts.Count;
            bool isSorted = false;
            int lastUnsorted = size - 1;
            Shirt temp;

            while (!isSorted)
            {
                isSorted = true;
                //for(int i = 0; i < (size - 1); i++)
                for (int i = 0; i < lastUnsorted; i++)
                {
                    if (more((int)shirts[i].Color, (int)shirts[i + 1].Color))
                    {
                        // swap
                        temp = shirts[i];
                        shirts[i] = shirts[i + 1];
                        shirts[i + 1] = temp;
                        isSorted = false;
                    }
                }
                lastUnsorted--;
            }
        }

        public static void SortByColorAsc(List<Shirt> shirts)
        {
            int color = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (color - 1); i++)
            {
                for (j = 0; j < (color - i - 1); j++)
                {
                    if (more((int)shirts[j].Color, (int)shirts[j + 1].Color))
                    {
                        // swap
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortByColorDesc(List<Shirt> shirts)
        {
            int color = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (color - 1); i++)
            {
                for (j = 0; j < (color - i - 1); j++)
                {
                    if (less((int)shirts[j].Color, (int)shirts[j + 1].Color))
                    {
                        // swap
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortByFabricAsc(List<Shirt> shirts)
        {
            int fabric = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (fabric - 1); i++)
            {
                for (j = 0; j < (fabric - i - 1); j++)
                {
                    if (more((int)shirts[j].Fabric, (int)shirts[j + 1].Fabric))
                    {
                        // swap
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortByFabricDesc(List<Shirt> shirts)
        {
            int fabric = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < (fabric - 1); i++)
            {
                for (j = 0; j < (fabric - i - 1); j++)
                {
                    if (less((int)shirts[j].Fabric, (int)shirts[j + 1].Fabric))
                    {
                        // swap
                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }
                }
            }
        }

        
    }
}
