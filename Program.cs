using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 2, 4, 6, 1, 3, 2, 6 };

            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", MergeSort(array, 0, array.Length - 1)));

            Console.ReadLine();
        }
        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)//((A,p,q,r))
        {
        var left = lowIndex;
        var right = middleIndex + 1;
        var tempArray = new int[highIndex - lowIndex + 1];
        var index = 0;

        while ((left <= middleIndex) && (right <= highIndex))
        {
            if (array[left] < array[right])
            {
                tempArray[index] = array[left];
                left++;
            }
            else
            {
                tempArray[index] = array[right];
                right++;
            }

            index++;
        }

        for (var i = left; i <= middleIndex; i++)
        {
            tempArray[index] = array[i];
            index++;
        }

        for (var i = right; i <= highIndex; i++)
        {
            tempArray[index] = array[i];
            index++;
        }

        for (var i = 0; i < tempArray.Length; i++)
        {
            array[lowIndex + i] = tempArray[i];
            }
    }
        git remote add origin https://github.com/Shmonyajik/MergeSort.git
        
    static int[] MergeSort(int[] array, int lowIndex, int highIndex)//(A, p, r) 
    {
        if (lowIndex < highIndex)
        {
            var middle = (lowIndex + highIndex) / 2;
            MergeSort(array, lowIndex, middle);
            MergeSort(array, middle + 1, highIndex);
            Merge(array, lowIndex, middle, highIndex);
        }

        return array;
    }


    


    }
}
