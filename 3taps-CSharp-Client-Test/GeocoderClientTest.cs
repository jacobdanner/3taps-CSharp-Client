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
  public class GeocoderClientTest
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
    ///A test for GeocoderClient Constructor
    ///</summary>
    [TestMethod()]
    public void GeocoderClientConstructorTest()
    {
      GeocoderClient target = new GeocoderClient();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for geocode
    ///</summary>
    [TestMethod()]
    public void geocodeTest()
    {
      GeocoderClient target = new GeocoderClient(); // TODO: Initialize to an appropriate value
      List<GeocoderRequest> geocoderRequests = null; // TODO: Initialize to an appropriate value
      List<GeocoderResponse> expected = null; // TODO: Initialize to an appropriate value
      List<GeocoderResponse> actual;
      actual = target.geocode(geocoderRequests);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for getInstance
    ///</summary>
    [TestMethod()]
    public void getInstanceTest()
    {
      GeocoderClient expected = null; // TODO: Initialize to an appropriate value
      GeocoderClient actual;
      actual = GeocoderClient.getInstance();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
