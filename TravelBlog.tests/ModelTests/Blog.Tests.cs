using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Blog.Models;

namespace Blog.Tests
{
  [TestClass]
  public class BlogTests
  {

    [TestMethod]
    public void IsString_CheckIfUserInputIsString_Bool_True()
    {
      string testSentence = "I went to Rome.";
      bool result = testSentence is string;
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void FilterTest_EnsureThatInputHasWordCharactersOnly_String_True()
    {
      string testSentence = ("#I! wEnT (t)O $rO@@mE.").ToLower();
      Regex Filter = new Regex(@"[^\w\s\d]");
      string result = Filter.Replace(testSentence, "");
      Assert.AreEqual("i went to rome", result);
    }

    [TestMethod]
    public void FilterFunction_EnsureThatInputHasWordCharactersOnly_String_True()
    {
      string testSentence = ("#I! wEnT (t)O $rO@@mE.").ToLower();
      BlogMain blog = new BlogMain();
      string result = blog.Filter(testSentence);
      Assert.AreEqual("i went to rome", result);
    }

    [TestMethod]
    public void FilterFunction_EnsureThatInputHasWordCharactersOnly_String_False()
    {
      string testSentence = ("#I! wEnT3 (t)O $rO@@mE.").ToLower();
      BlogMain blog = new BlogMain();
      string result = blog.Filter(testSentence);
      Assert.AreNotEqual("i went to rome", result);
    }
    [TestMethod]
    public void TestObject()
    {
      string city="seattle";


    }

    }
  }
  // [TestClass]
  // public class ItemTest : IDisposable
  // {
  //   public void Dispose()
  //   {
  //     Item.ClearAll();
  //   }
  //
  //   [TestMethod]
  //   public void ItemConstructor_CreatesInstanceOfItem_Item()
  //   {
  //     Item newItem = new Item("test");
  //     Assert.AreEqual(typeof(Item), newItem.GetType());
  //   }
  //
  //   [TestMethod]
  //   public void GetDescription_ReturnDescription_String()
  //   {
  //     string description = "Walk the dog.";
  //     Item newItem = new Item(description);
  //     string result = newItem.GetDescription();
  //     Assert.AreEqual(description, result);
  //   }
  //
  //   [TestMethod]
  //   public void GetDescription_SetDescription_String()
  //   {
  //     string description = "Walk the dog.";
  //     Item newItem = new Item(description);
  //     string updatedDescription = "Do the dishes.";
  //     newItem.SetDescription(updatedDescription);
  //     string result = newItem.GetDescription();
  //     Assert.AreEqual(updatedDescription, result);
  //   }
  //
  //   [TestMethod]
  //   public void GetAll_ReturnsEmptyList_ItemList()
  //   {
  //     List<Item> newList = new List<Item> {};
  //     List<Item> result = Item.GetAll();
  //
  //     foreach (Item thisItem in result)
  //     {
  //       Console.WriteLine("Output from empty list GetAll test: " + thisItem.GetDescription());
  //     }
  //
  //     CollectionAssert.AreEqual(newList, result);
  //   }
  //
  //   [TestMethod]
  //   public void GetAll_ReturnsItems_ItemList()
  //   {
  //     string description01 = "Walk the dog";
  //     string description02 = "Wash the dishes";
  //     Item newItem01 = new Item(description01);
  //     Item newItem02 = new Item(description02);
  //     List<Item> newList = new List<Item> {newItem01, newItem02};
  //     List<Item> result = Item.GetAll();
  //
  //     foreach (Item thisItem in result)
  //       {
  //         Console.WriteLine("Output from second GetAll test: " + thisItem.GetDescription());
  //       }
  //
  //     CollectionAssert.AreEqual(newList, result);
  //   }
  //
  //   [TestMethod]
  //   public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
  //   {
  //     //Arrange
  //     string description = "Walk the dog.";
  //     Item newItem = new Item(description);
  //
  //     //Act
  //     int result = newItem.GetId();
  //
  //     //Assert
  //     Assert.AreEqual(1, result);
  //   }
  //
  //   [TestMethod]
  //   public void Find_ReturnsCorrectItem_Item()
  //   {
  //     //Arrange
  //     string description01 = "Walk the dog";
  //     string description02 = "Wash the dishes";
  //     Item newItem1 = new Item(description01);
  //     Item newItem2 = new Item(description02);
  //
  //     //Act
  //     Item result = Item.Find(2);
  //
  //     //Assert
  //     Assert.AreEqual(newItem2, result);
  //   }
  // }
}
