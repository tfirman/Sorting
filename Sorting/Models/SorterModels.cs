using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Sorter.Models
{
  public class SortStuff
  {
    public List<int> BubbleSort (List<int> inputList)
    {
      bool needsSort = true;
      while (needsSort)
      {
        needsSort = false;
        for (int i=1; i < inputList.Count; i++)
        {
          if (inputList[i-1] > inputList[i])
          {
            needsSort = true;
            int temp = inputList[i];
            inputList[i] = inputList[i-1];
            inputList[i-1] = temp;
          }
        }
      }
      return inputList;
    }

    public List<int> InsertionSort (List<int> inputList)
    {
      for (int i=1; i < inputList.Count; i++)
      {
        int desti = i;
        for (int j = i-1; j >= 0; j--)
        {
          if (inputList[j] > inputList[i])
          {
            desti = j;
          } else
          {
            break;
          }
        }
        inputList.Insert (desti, inputList[i]);
        inputList.RemoveAt (i+1);
      }
      return inputList;
    }

    public List<int> MergeSort (List<int> inputList)
    {
      if (inputList.Count > 1)
      {
        List<int> subList1 = inputList.GetRange(0,(inputList.Count/2));
        subList1 = MergeSort (subList1);
        List<int> subList2 = inputList.GetRange((inputList.Count/2),(inputList.Count/2+inputList.Count%2));
        subList2 = MergeSort (subList2);

        subList1.ForEach(i => Console.Write("{0}\t", i));
        Console.WriteLine("out1");
        subList2.ForEach(i => Console.Write("{0}\t", i));
        Console.WriteLine("out2");

        int i2 = 0;
        int i1 = 0;
        List<int> newList = new List<int> {};
        while (i1 < subList1.Count)
        {
          if (i2 < subList2.Count)
          {
            if (subList1[i1] < subList2[i2])
            {
              newList.Add(subList1[i1]);
              i1++;
            } else
            {
              newList.Add(subList2[i2]);
              i2++;
            }
          } else
          {
            newList.Add(subList1[i1]);
            i1++;
          }
        }
        while (i2 < subList2.Count)
        {
          newList.Add(subList2[i2]);
          i2++;
        }
        inputList.ForEach(i => Console.Write("{0}\t", i));
        Console.WriteLine("in");
        inputList = newList;
        inputList.ForEach(i => Console.Write("{0}\t", i));
        Console.WriteLine("out");
      }
      return inputList;
    }
  }
}
