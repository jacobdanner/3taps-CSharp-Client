using com.threetaps.client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using com.threetaps.model;
using System.Collections.Generic;
using com.threetaps.dto.posting;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for PostingClientTest and is intended
    ///to contain all PostingClientTest Unit Tests
    ///</summary>
  [TestClass()]
  public class PostingClientTest
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
    ///A test for PostingClient Constructor
    ///</summary>
    [TestMethod()]
    public void PostingClientConstructorTest()
    {
      PostingClient target = new PostingClient();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for create
    ///</summary>
    [TestMethod()]
    public void createTest()
    {
      PostingClient target = new PostingClient(); // TODO: Initialize to an appropriate value
      List<Posting> postingsToCreate = null; // TODO: Initialize to an appropriate value
      List<CreateResponse> expected = null; // TODO: Initialize to an appropriate value
      List<CreateResponse> actual;
      actual = target.create(postingsToCreate);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for delete
    ///</summary>
    [TestMethod()]
    public void deleteTest()
    {
      PostingClient target = new PostingClient(); // TODO: Initialize to an appropriate value
      List<string> postKeysToDelete = null; // TODO: Initialize to an appropriate value
      DeleteResponse expected = null; // TODO: Initialize to an appropriate value
      DeleteResponse actual;
      actual = target.delete(postKeysToDelete);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for get
    ///</summary>
    [TestMethod()]
    public void getTest()
    {
      PostingClient target = new PostingClient(); // TODO: Initialize to an appropriate value
      string postKey = string.Empty; // TODO: Initialize to an appropriate value
      Posting expected = null; // TODO: Initialize to an appropriate value
      Posting actual;
      actual = target.get(postKey);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for getInstance
    ///</summary>
    [TestMethod()]
    public void getInstanceTest()
    {
      PostingClient expected = null; // TODO: Initialize to an appropriate value
      PostingClient actual;
      actual = PostingClient.getInstance();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for update
    ///</summary>
    [TestMethod()]
    public void updateTest()
    {
      PostingClient target = new PostingClient(); // TODO: Initialize to an appropriate value
      List<Posting> postingsToUpdate = null; // TODO: Initialize to an appropriate value
      UpdateResponse expected = null; // TODO: Initialize to an appropriate value
      UpdateResponse actual;
      actual = target.update(postingsToUpdate);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
