using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorter.Models;
using System.Collections.Generic;

namespace Sorter.Tests
{
  [TestClass]
  public class SortStuffTest
  {
    [TestMethod]
    public void BubbleResult_TwoOne_OneTwo()
    {
      SortStuff testSortStuff = new SortStuff();
      List<int> inputList = new List<int> {2, 1};
      CollectionAssert.AreEqual(new List<int> {1, 2}, testSortStuff.BubbleSort(inputList));
    }
    [TestMethod]
    public void BubbleResult_52981736_12356789()
    {
      SortStuff testSortStuff = new SortStuff();
      List<int> inputList = new List<int> {5,2,9,8,1,7,3,6};
      CollectionAssert.AreEqual(new List<int> {1,2,3,5,6,7,8,9}, testSortStuff.BubbleSort(inputList));
    }
    [TestMethod]
    public void InsertionResult_TwoOne_OneTwo()
    {
      SortStuff testSortStuff = new SortStuff();
      List<int> inputList = new List<int> {2, 1};
      CollectionAssert.AreEqual(new List<int> {1, 2}, testSortStuff.InsertionSort(inputList));
    }
    [TestMethod]
    public void InsertionResult_52981736_12356789()
    {
      SortStuff testSortStuff = new SortStuff();
      List<int> inputList = new List<int> {5,2,9,8,1,7,3,6};
      CollectionAssert.AreEqual(new List<int> {1,2,3,5,6,7,8,9}, testSortStuff.InsertionSort(inputList));
    }
  }
}
