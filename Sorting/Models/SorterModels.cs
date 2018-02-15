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

        subList1.ForEach(i => Console.Write("{0}\t", i));
        Console.WriteLine("in1");

        List<int> subList2 = inputList.GetRange((inputList.Count/2),(inputList.Count/2+inputList.Count%2));
        subList2 = MergeSort (subList2);

        subList2.ForEach(i => Console.Write("{0}\t", i));
        Console.WriteLine("in2");

        if (subList1[0] > subList2[0])
        {
          inputList = subList2.Concat(subList1).ToList();
        }

ß        subList1.ForEach(i => Console.Write("{0}\t", i));
        Console.WriteLine("out1");
        subList2.ForEach(i => Console.Write("{0}\t", i));
        Console.WriteLine("out2");
        inputList.ForEach(i => Console.Write("{0}\t", i));
        Console.WriteLine("out");
      }
      return inputList;
    }
  }
}
