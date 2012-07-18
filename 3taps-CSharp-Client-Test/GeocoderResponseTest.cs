using com.threetaps.dto.geocoder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for GeocoderResponseTest and is intended
    ///to contain all GeocoderResponseTest Unit Tests
    ///</summary>
  [TestClass()]
  public class GeocoderResponseTest
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
    ///A test for GeocoderResponse Constructor
    ///</summary>
    [TestMethod()]
    public void GeocoderResponseConstructorTest()
    {
      GeocoderResponse target = new GeocoderResponse();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for code
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void codeTest()
    {
      GeocoderResponse_Accessor target = new GeocoderResponse_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.code = expected;
      actual = target.code;
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
      GeocoderResponse_Accessor target = new GeocoderResponse_Accessor(); // TODO: Initialize to an appropriate value
      float expected = 0F; // TODO: Initialize to an appropriate value
      float actual;
      target.latitude = expected;
      actual = target.latitude;
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
      GeocoderResponse_Accessor target = new GeocoderResponse_Accessor(); // TODO: Initialize to an appropriate value
      float expected = 0F; // TODO: Initialize to an appropriate value
      float actual;
      target.longitude = expected;
      actual = target.longitude;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
