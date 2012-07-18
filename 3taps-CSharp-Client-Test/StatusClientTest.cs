using com.threetaps.client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using com.threetaps.model;
using System.Collections.Generic;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for StatusClientTest and is intended
    ///to contain all StatusClientTest Unit Tests
    ///</summary>
  [TestClass()]
  public class StatusClientTest
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
    ///A test for StatusClient Constructor
    ///</summary>
    [TestMethod()]
    public void StatusClientConstructorTest()
    {
      StatusClient target = new StatusClient();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for get
    ///</summary>
    [TestMethod()]
    public void getTest()
    {
      StatusClient target = new StatusClient(); // TODO: Initialize to an appropriate value
      List<Posting> postingsToCheck = null; // TODO: Initialize to an appropriate value
      List<Posting> expected = null; // TODO: Initialize to an appropriate value
      List<Posting> actual;
      actual = target.get(postingsToCheck);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for getInstance
    ///</summary>
    [TestMethod()]
    public void getInstanceTest()
    {
      StatusClient expected = null; // TODO: Initialize to an appropriate value
      StatusClient actual;
      actual = StatusClient.getInstance();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for system
    ///</summary>
    [TestMethod()]
    public void systemTest()
    {
      StatusClient target = new StatusClient(); // TODO: Initialize to an appropriate value
      Message expected = null; // TODO: Initialize to an appropriate value
      Message actual;
      actual = target.system();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for update
    ///</summary>
    [TestMethod()]
    public void updateTest()
    {
      StatusClient target = new StatusClient(); // TODO: Initialize to an appropriate value
      List<Posting> postingsToUpdate = null; // TODO: Initialize to an appropriate value
      Message expected = null; // TODO: Initialize to an appropriate value
      Message actual;
      actual = target.update(postingsToUpdate);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
