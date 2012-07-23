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
  public class StatusClientTest : BaseTestCase
  {
    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get { return testContextInstance; }
      set { testContextInstance = value; }
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
    private StatusClient statusClient;

    [TestInitialize()]
    public void setUp()
    {
      statusClient = ThreetapsClient.getInstance().setAuthID(API_KEY).statusClient;
    }

    //Use TestCleanup to run code after each test has run
    //[TestCleanup()]
    //public void MyTestCleanup()
    //{
    //}
    //

    #endregion

    /// <summary>
    ///A test for get
    ///</summary>
    [TestMethod()]
    public void getTest()
    {
      Posting posting = new Posting();
      posting.externalID = "NOTANID";
      posting.source = "E_BAY";

      List<Posting> postingsToCheck = new List<Posting>();
      postingsToCheck.Add(posting);

      List<Posting> result = statusClient.get(postingsToCheck);
      Assert.Equals(result.Count, 1);
      Assert.IsTrue(result.ToArray()[0].exists == false);
    }


    /// <summary>
    ///A test for system
    ///</summary>
    [TestMethod()]
    public void systemTest()
    {
      Message message = statusClient.system();
      Assert.IsNotNull(message.code);
    }

    /// <summary>
    ///A test for update
    ///</summary>
    [TestMethod()]
    public void updateTest()
    {
      Posting posting = new Posting();
      posting.externalID = "NOTANIDAGAIN";
      posting.source = "E_BAY";
      posting.status = "test";

      List<Posting> postingsToUpdate = new List<Posting>();
      postingsToUpdate.Add(posting);

      Message result = statusClient.update(postingsToUpdate);
      Assert.Equals(result.code, "200");
    }
  }
}