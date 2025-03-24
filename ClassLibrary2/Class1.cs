using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {

        // Метод для сортировки массива
        public int[] SortArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Null array");
            }
            return array.OrderBy(x => x).ToArray();
        }

        // Метод для фильтрации массива 
        public int[] FilterArr(int[] array, Func<int, bool> filter)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Null array");

            }

            if (filter == null)
            {
                throw new ArgumentNullException("filter null");
            }

            return array.Where(filter).ToArray();
        }

        // Метод для поиска элемента в массиве
        public int FindElem(int[] array, int element)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Null array");

            }

            return Array.IndexOf(array, element);
        }
    }
}

