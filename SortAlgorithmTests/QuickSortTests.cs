using NUnit.Framework;

namespace SortAlgorithmTests
{
    public class QuickSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestQuickSort_RandomOrderOfElements_ReturnsCorrectOrder()
        {
            int[] array = new int[] {1,4,8,2,6};

            Quick_Sort(array, 0, array.Length - 1);

            Assert.AreEqual(array[0], 1);
            Assert.AreEqual(array[1], 2);
            Assert.AreEqual(array[2], 4);
            Assert.AreEqual(array[3], 6);
            Assert.AreEqual(array[4], 8);
        }

        public static void Quick_Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(arr, low, high);

                Quick_Sort(arr, low, pivot - 1);
                Quick_Sort(arr, pivot + 1, high);
            }
        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }
    }
}