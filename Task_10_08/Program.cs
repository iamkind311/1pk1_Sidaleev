using System.Dynamic;

namespace Task_10_08
{
    internal class Program
    {
        /*Создайте метод, который на вход принимает
         * одномерный массив и число для поиска,
         * верните индексискомогоэлемента в массиве.
         * Если элемента нет – верните индекс = -1 */
        static void Main(string[] args)
        {
        }
        public int FindElementIndex(int[] array, int numberToFind)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == numberToFind)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
