using com.threetaps.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for PostingHistoryTest and is intended
    ///to contain all PostingHistoryTest Unit Tests
    ///</summary>
  [TestClass()]
  public class PostingHistoryTest
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
    ///A test for PostingHistory Constructor
    ///</summary>
    [TestMethod()]
    public void PostingHistoryConstructorTest()
    {
      PostingHistory target = new PostingHistory();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for attributes
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void attributesTest()
    {
      PostingHistory_Accessor target = new PostingHistory_Accessor(); // TODO: Initialize to an appropriate value
      Dictionary<string, object> expected = null; // TODO: Initialize to an appropriate value
      Dictionary<string, object> actual;
      target.attributes = expected;
      actual = target.attributes;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for errors
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void errorsTest()
    {
      PostingHistory_Accessor target = new PostingHistory_Accessor(); // TODO: Initialize to an appropriate value
      List<Message> expected = null; // TODO: Initialize to an appropriate value
      List<Message> actual;
      target.errors = expected;
      actual = target.errors;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for timestamp
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void timestampTest()
    {
      PostingHistory_Accessor target = new PostingHistory_Accessor(); // TODO: Initialize to an appropriate value
      DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
      DateTime actual;
      target.timestamp = expected;
      actual = target.timestamp;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
