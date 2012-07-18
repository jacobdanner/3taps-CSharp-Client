using com.threetaps.client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using com.threetaps.model;
using System.Collections.Generic;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for ReferenceClientTest and is intended
    ///to contain all ReferenceClientTest Unit Tests
    ///</summary>
  [TestClass()]
  public class ReferenceClientTest
  {


    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    #region Additional test attributes
    // 
    //You can use the following additional attributes as you write your tests:
    //
    //Use ClassInitialize to run code before running the first test in the class
    //[ClassInitialize()]
    //public static void MyClassInitialize(TestContext testContext)
    //{
    //}
    //
    //Use ClassCleanup to run code after all tests in a class have run
    //[ClassCleanup()]
    //public static void MyClassCleanup()
    //{
    //}
    //
    //Use TestInitialize to run code before running each test
    //[TestInitialize()]
    //public void MyTestInitialize()
    //{
    //}
    //
    //Use TestCleanup to run code after each test has run
    //[TestCleanup()]
    //public void MyTestCleanup()
    //{
    //}
    //
    #endregion


    /// <summary>
    ///A test for ReferenceClient Constructor
    ///</summary>
    [TestMethod()]
    public void ReferenceClientConstructorTest()
    {
      ReferenceClient target = new ReferenceClient();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for getCategories
    ///</summary>
    [TestMethod()]
    public void getCategoriesTest()
    {
      ReferenceClient target = new ReferenceClient(); // TODO: Initialize to an appropriate value
      List<Category> expected = null; // TODO: Initialize to an appropriate value
      List<Category> actual;
      actual = target.getCategories();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for getCategory
    ///</summary>
    [TestMethod()]
    public void getCategoryTest()
    {
      ReferenceClient target = new ReferenceClient(); // TODO: Initialize to an appropriate value
      string categoryCode = string.Empty; // TODO: Initialize to an appropriate value
      Category expected = null; // TODO: Initialize to an appropriate value
      Category actual;
      actual = target.getCategory(categoryCode);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for getInstance
    ///</summary>
    [TestMethod()]
    public void getInstanceTest()
    {
      ReferenceClient expected = null; // TODO: Initialize to an appropriate value
      ReferenceClient actual;
      actual = ReferenceClient.getInstance();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for getLocations
    ///</summary>
    [TestMethod()]
    public void getLocationsTest()
    {
      ReferenceClient target = new ReferenceClient(); // TODO: Initialize to an appropriate value
      List<Location> expected = null; // TODO: Initialize to an appropriate value
      List<Location> actual;
      actual = target.getLocations();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for getSources
    ///</summary>
    [TestMethod()]
    public void getSourcesTest()
    {
      ReferenceClient target = new ReferenceClient(); // TODO: Initialize to an appropriate value
      List<Source> expected = null; // TODO: Initialize to an appropriate value
      List<Source> actual;
      actual = target.getSources();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
