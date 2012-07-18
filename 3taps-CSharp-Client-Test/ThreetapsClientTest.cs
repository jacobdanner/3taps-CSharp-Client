using com.threetaps.client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for ThreetapsClientTest and is intended
    ///to contain all ThreetapsClientTest Unit Tests
    ///</summary>
  [TestClass()]
  public class ThreetapsClientTest
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
    ///A test for ThreetapsClient Constructor
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void ThreetapsClientConstructorTest()
    {
      ThreetapsClient_Accessor target = new ThreetapsClient_Accessor();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for getAuthID
    ///</summary>
    [TestMethod()]
    public void getAuthIDTest()
    {
      ThreetapsClient_Accessor target = new ThreetapsClient_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      actual = target.getAuthID();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for getInstance
    ///</summary>
    [TestMethod()]
    public void getInstanceTest()
    {
      ThreetapsClient expected = null; // TODO: Initialize to an appropriate value
      ThreetapsClient actual;
      actual = ThreetapsClient.getInstance();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for setAuthID
    ///</summary>
    [TestMethod()]
    public void setAuthIDTest()
    {
      ThreetapsClient_Accessor target = new ThreetapsClient_Accessor(); // TODO: Initialize to an appropriate value
      string authID = string.Empty; // TODO: Initialize to an appropriate value
      ThreetapsClient expected = null; // TODO: Initialize to an appropriate value
      ThreetapsClient actual;
      actual = target.setAuthID(authID);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for geocoderClient
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void geocoderClientTest()
    {
      ThreetapsClient_Accessor target = new ThreetapsClient_Accessor(); // TODO: Initialize to an appropriate value
      GeocoderClient expected = null; // TODO: Initialize to an appropriate value
      GeocoderClient actual;
      target.geocoderClient = expected;
      actual = target.geocoderClient;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for postingClient
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void postingClientTest()
    {
      ThreetapsClient_Accessor target = new ThreetapsClient_Accessor(); // TODO: Initialize to an appropriate value
      PostingClient expected = null; // TODO: Initialize to an appropriate value
      PostingClient actual;
      target.postingClient = expected;
      actual = target.postingClient;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for referenceClient
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void referenceClientTest()
    {
      ThreetapsClient_Accessor target = new ThreetapsClient_Accessor(); // TODO: Initialize to an appropriate value
      ReferenceClient expected = null; // TODO: Initialize to an appropriate value
      ReferenceClient actual;
      target.referenceClient = expected;
      actual = target.referenceClient;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for searchClient
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void searchClientTest()
    {
      ThreetapsClient_Accessor target = new ThreetapsClient_Accessor(); // TODO: Initialize to an appropriate value
      SearchClient expected = null; // TODO: Initialize to an appropriate value
      SearchClient actual;
      target.searchClient = expected;
      actual = target.searchClient;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for statusClient
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void statusClientTest()
    {
      ThreetapsClient_Accessor target = new ThreetapsClient_Accessor(); // TODO: Initialize to an appropriate value
      StatusClient expected = null; // TODO: Initialize to an appropriate value
      StatusClient actual;
      target.statusClient = expected;
      actual = target.statusClient;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
