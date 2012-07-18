using com.threetaps.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for LocationTest and is intended
    ///to contain all LocationTest Unit Tests
    ///</summary>
  [TestClass()]
  public class LocationTest
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
    ///A test for Location Constructor
    ///</summary>
    [TestMethod()]
    public void LocationConstructorTest()
    {
      Location target = new Location();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for city
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void cityTest()
    {
      Location_Accessor target = new Location_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.city = expected;
      actual = target.city;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for cityRank
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void cityRankTest()
    {
      Location_Accessor target = new Location_Accessor(); // TODO: Initialize to an appropriate value
      int expected = 0; // TODO: Initialize to an appropriate value
      int actual;
      target.cityRank = expected;
      actual = target.cityRank;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for code
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void codeTest()
    {
      Location_Accessor target = new Location_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.code = expected;
      actual = target.code;
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
      Location_Accessor target = new Location_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.country = expected;
      actual = target.country;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for countryRank
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void countryRankTest()
    {
      Location_Accessor target = new Location_Accessor(); // TODO: Initialize to an appropriate value
      int expected = 0; // TODO: Initialize to an appropriate value
      int actual;
      target.countryRank = expected;
      actual = target.countryRank;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for hidden
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void hiddenTest()
    {
      Location_Accessor target = new Location_Accessor(); // TODO: Initialize to an appropriate value
      bool expected = false; // TODO: Initialize to an appropriate value
      bool actual;
      target.hidden = expected;
      actual = target.hidden;
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
      Location_Accessor target = new Location_Accessor(); // TODO: Initialize to an appropriate value
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
      Location_Accessor target = new Location_Accessor(); // TODO: Initialize to an appropriate value
      float expected = 0F; // TODO: Initialize to an appropriate value
      float actual;
      target.longitude = expected;
      actual = target.longitude;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for stateCode
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void stateCodeTest()
    {
      Location_Accessor target = new Location_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.stateCode = expected;
      actual = target.stateCode;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for stateName
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void stateNameTest()
    {
      Location_Accessor target = new Location_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.stateName = expected;
      actual = target.stateName;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
