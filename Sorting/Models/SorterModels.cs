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
  }
}
