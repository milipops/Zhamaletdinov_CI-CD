using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ClassLibrary2;

namespace ClassLibrary2
{
    public class Test
    {
        public class ZhamaletdinovClassTest
        {
            [Fact]
            // сортировка массива
            public void SortArray()
            {
                // Arrange
                var arrayOps = new Class1();
                int[] array = { 3, 1, 2 };

                // Act
                var sortedArray = arrayOps.SortArray(array);

                // Assert
                Assert.Equal(new[] { 1, 2, 3 }, sortedArray);
            }

            [Fact]
            //(только четные числа)
            public void FilterArray()
            {
                // Arrange
                var arrayOps = new Class1();
                int[] array = { 1, 2, 3, 4, 5 };

                // Act
                var filterArray = arrayOps.FilterArr(array, x => x % 2 == 0);

                // Assert
                Assert.Equal(new[] { 2, 4 }, filterArray);
            }

            [Fact]
            //(только не четные числа)
            public void FilterArray2()
            {
                // Arrange
                var arrayOps = new Class1();
                int[] array = { 1, 2, 3, 4, 5 };

                // Act
                var filterArray = arrayOps.FilterArr(array, x => x % 2 == 1);

                // Assert
                Assert.Equal(new[] { 1, 3, 5 }, filterArray);
            }

            [Fact]
            // поиск индекса элемента массива
            public void FindElement_ReturnIndex()
            {
                // Arrange
                var arrayOps = new Class1();
                int[] array = { 1, 2, 3, 4, 5 };

                // Act
                var index = arrayOps.FindElem(array, 3);

                // Assert
                Assert.Equal(2, index);
            }

            [Fact]
            // вывод -1 если элемент не найден
            public void FindElement_IfNotFound()
            {
                // Arrange
                var arrayOps = new Class1();
                int[] array = { 1, 2, 3, 4, 5 };

                // Act
                var index = arrayOps.FindElem(array, 6);

                // Assert
                Assert.Equal(-1, index);
            }

        }
    }
}
