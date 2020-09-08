using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.SortingAlgorithms
{
    class QuickSort
    {
        public static void SortShirtsColorDesc(List<Shirt> shirts)
        {
            SortByColorDesc(shirts, 0, shirts.Count - 1);
            
        }

        public static void SortShirtsSizeDesc(List<Shirt> shirts)
        {
            SortBySizeDesc(shirts, 0, shirts.Count - 1);

        }

        public static void SortShirtsFabricDesc(List<Shirt> shirts)
        {
            SortByFabricDesc(shirts, 0, shirts.Count - 1);

        }



        private static void SortByColorDesc(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Color;



            while (i <= j)
            {
                while (shirts[i].Color > pivot)
                    i++;
                while (shirts[j].Color < pivot)
                    j--;



                if (i <= j)
                {
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }



            if (left < j)
                SortByColorDesc(shirts, left, j);
            if (i < right)
                SortByColorDesc(shirts, i, right);
        }

        private static void SortBySizeDesc(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Size;



            while (i <= j)
            {
                while (shirts[i].Size > pivot)
                    i++;
                while (shirts[j].Size < pivot)
                    j--;



                if (i <= j)
                {
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }



            if (left < j)
                SortBySizeDesc(shirts, left, j);
            if (i < right)
                SortBySizeDesc(shirts, i, right);
        }

        private static void SortByFabricDesc(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Fabric;



            while (i <= j)
            {
                while (shirts[i].Fabric > pivot)
                    i++;
                while (shirts[j].Fabric < pivot)
                    j--;



                if (i <= j)
                {
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }



            if (left < j)
                SortByFabricDesc(shirts, left, j);
            if (i < right)
                SortByFabricDesc(shirts, i, right);
        }
    }
}
