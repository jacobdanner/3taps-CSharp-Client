using com.threetaps.dto.search;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for RangeRequestTest and is intended
    ///to contain all RangeRequestTest Unit Tests
    ///</summary>
  [TestClass()]
  public class RangeRequestTest
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
    ///A test for RangeRequest Constructor
    ///</summary>
    [TestMethod()]
    public void RangeRequestConstructorTest()
    {
      RangeRequest target = new RangeRequest();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for addField
    ///</summary>
    [TestMethod()]
    public void addFieldTest()
    {
      RangeRequest target = new RangeRequest(); // TODO: Initialize to an appropriate value
      string field = string.Empty; // TODO: Initialize to an appropriate value
      target.addField(field);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for getQueryParams
    ///</summary>
    [TestMethod()]
    public void getQueryParamsTest()
    {
      RangeRequest target = new RangeRequest(); // TODO: Initialize to an appropriate value
      Dictionary<string, string> expected = null; // TODO: Initialize to an appropriate value
      Dictionary<string, string> actual;
      actual = target.getQueryParams();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for fields
    ///</summary>
    [TestMethod()]
    public void fieldsTest()
    {
      RangeRequest target = new RangeRequest(); // TODO: Initialize to an appropriate value
      List<string> expected = null; // TODO: Initialize to an appropriate value
      List<string> actual;
      target.fields = expected;
      actual = target.fields;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for searchRequest
    ///</summary>
    [TestMethod()]
    public void searchRequestTest()
    {
      RangeRequest target = new RangeRequest(); // TODO: Initialize to an appropriate value
      SearchRequest expected = null; // TODO: Initialize to an appropriate value
      SearchRequest actual;
      target.searchRequest = expected;
      actual = target.searchRequest;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
