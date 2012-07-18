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
  public class PostingClientTest : BaseTestCase
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
    private PostingClient postingClient;

    [TestInitialize()]
    public void setUp()
    {
      postingClient = ThreetapsClient.getInstance().setAuthID(API_KEY).postingClient;
    }

    //
    //Use TestCleanup to run code after each test has run
    //[TestCleanup()]
    //public void MyTestCleanup()
    //{
    //}
    //

    #endregion

    /// <summary>
    ///A test for create
    ///</summary>
    [TestMethod()]
    public void createTest()
    {
      Posting posting1 = new Posting();
      posting1.source = "3TAPS";
      posting1.category = "VAUT";
      posting1.heading = "This is a Test Posting";
      posting1.location = "LAX";
      posting1.timestamp = new DateTime();

      Posting posting2 = new Posting();
      posting2.source = "3TAPS";
      posting2.category = "VAUT";
      posting2.heading = "This is a Test Posting";
      posting2.location = "LAX";

      List<Posting> postingsToCreate = new List<Posting>();
      postingsToCreate.Add(posting1);
      postingsToCreate.Add(posting2);

      List<CreateResponse> responses = postingClient.create(postingsToCreate);

      Assert.IsTrue(responses.Count == 2);
      /*TODO: implement these
    Assert.IsTrue(responses.get(0).getPostKey() != null);
    Assert.IsTrue(responses.get(0).getError() == null);
    Assert.IsTrue(responses.get(1).getPostKey() == null);
    Assert.IsTrue(responses.get(1).getError() != null);  
    */
    }


    /// <summary>
    ///A test for get
    ///</summary>
    [TestMethod()]
    public void getTest()
    {
      Posting posting = postingClient.get("BDY6869");
      Assert.IsNotNull(posting);
    }
  }
}