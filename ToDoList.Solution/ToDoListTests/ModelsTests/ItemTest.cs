using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests
  {

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      String description = "Walk the dog.";
      Item newItem = new Item(description);
      Assert.AreEqual(description, result);
    }
  }
}