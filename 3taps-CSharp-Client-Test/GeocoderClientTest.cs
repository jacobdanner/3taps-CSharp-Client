using com.threetaps.client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using com.threetaps.dto.geocoder;
using System.Collections.Generic;

namespace _3taps_CSharp_Client_Test
{
  /// <summary>
  ///This is a test class for GeocoderClientTest and is intended
  ///to contain all GeocoderClientTest Unit Tests
  ///</summary>
  [TestClass()]
  public class GeocoderClientTest : BaseTestCase
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
    ///A test for geocode
    ///</summary>
    [TestMethod()]
    public void geocodeTest()
    {
      GeocoderClient geocoderClient =
        ThreetapsClient.getInstance().setAuthID(API_KEY).geocoderClient;

      GeocoderRequest geocoderRequest = new GeocoderRequest();
      geocoderRequest.text = "Los Angeles, CA";

      List<GeocoderRequest> geocoderRequests = new List<GeocoderRequest>();
      geocoderRequests.Add(geocoderRequest);

      List<GeocoderResponse> geocoderResponses = geocoderClient.geocode(geocoderRequests);

      Assert.IsTrue(geocoderResponses.Count >= 1);
      Assert.IsTrue(geocoderResponses.Exists(item => item.code == "LAX"));
    }
  }
}