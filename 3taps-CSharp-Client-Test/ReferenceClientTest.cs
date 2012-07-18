using com.threetaps.client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using com.threetaps.model;
using System.Collections.Generic;

namespace _3taps_CSharp_Client_Test
{
  /// <summary>
  ///This is a test class for ReferenceClientTest and is intended
  ///to contain all ReferenceClientTest Unit Tests
  ///</summary>
  [TestClass()]
  public class ReferenceClientTest : BaseTestCase
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
    private ReferenceClient refClient;

    [TestInitialize()]
    public void setUp()
    {
      refClient = ThreetapsClient.getInstance().setAuthID(API_KEY).referenceClient;
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
    ///A test for getCategories
    ///</summary>
    [TestMethod()]
    public void getCategoriesTest()
    {
      List<Category> categories = refClient.getCategories();
      Assert.IsNotNull(categories);
      Assert.IsTrue(categories.Count > 0);
    }

    /// <summary>
    ///A test for getCategory
    ///</summary>
    [TestMethod()]
    public void getCategoryTest()
    {
      Category category = refClient.getCategory("VAUT");
      Assert.IsNotNull(category);
    }

    
    /// <summary>
    ///A test for getLocations
    ///</summary>
    [TestMethod()]
    public void getLocationsTest()
    {
      List<Location> locations = refClient.getLocations();
      Assert.IsNotNull(locations);
      Assert.IsTrue(locations.Count > 0);
    }

    /// <summary>
    ///A test for getSources
    ///</summary>
    [TestMethod()]
    public void getSourcesTest()
    {
      List<Source> sources = refClient.getSources();
      Assert.IsNotNull(sources);
      Assert.IsTrue(sources.Count > 0);
    }
  }
}