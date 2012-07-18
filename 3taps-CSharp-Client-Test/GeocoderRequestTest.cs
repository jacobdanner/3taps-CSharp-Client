using com.threetaps.dto.geocoder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for GeocoderRequestTest and is intended
    ///to contain all GeocoderRequestTest Unit Tests
    ///</summary>
  [TestClass()]
  public class GeocoderRequestTest
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
    ///A test for GeocoderRequest Constructor
    ///</summary>
    [TestMethod()]
    public void GeocoderRequestConstructorTest()
    {
      GeocoderRequest target = new GeocoderRequest();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for city
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void cityTest()
    {
      GeocoderRequest_Accessor target = new GeocoderRequest_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.city = expected;
      actual = target.city;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for country
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void countryTest()
    {
      GeocoderRequest_Accessor target = new GeocoderRequest_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.country = expected;
      actual = target.country;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for latitude
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void latitudeTest()
    {
      GeocoderRequest_Accessor target = new GeocoderRequest_Accessor(); // TODO: Initialize to an appropriate value
      float expected = 0F; // TODO: Initialize to an appropriate value
      float actual;
      target.latitude = expected;
      actual = target.latitude;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for locality
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void localityTest()
    {
      GeocoderRequest_Accessor target = new GeocoderRequest_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.locality = expected;
      actual = target.locality;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for longitude
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void longitudeTest()
    {
      GeocoderRequest_Accessor target = new GeocoderRequest_Accessor(); // TODO: Initialize to an appropriate value
      float expected = 0F; // TODO: Initialize to an appropriate value
      float actual;
      target.longitude = expected;
      actual = target.longitude;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for postal
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void postalTest()
    {
      GeocoderRequest_Accessor target = new GeocoderRequest_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.postal = expected;
      actual = target.postal;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for state
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void stateTest()
    {
      GeocoderRequest_Accessor target = new GeocoderRequest_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.state = expected;
      actual = target.state;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for text
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void textTest()
    {
      GeocoderRequest_Accessor target = new GeocoderRequest_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.text = expected;
      actual = target.text;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
