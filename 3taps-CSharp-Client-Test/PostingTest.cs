using com.threetaps.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for PostingTest and is intended
    ///to contain all PostingTest Unit Tests
    ///</summary>
  [TestClass()]
  public class PostingTest
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
    ///A test for Posting Constructor
    ///</summary>
    [TestMethod()]
    public void PostingConstructorTest()
    {
      Posting target = new Posting();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for accountID
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void accountIDTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.accountID = expected;
      actual = target.accountID;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for accountName
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void accountNameTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.accountName = expected;
      actual = target.accountName;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for annotations
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void annotationsTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      Dictionary<string, object> expected = null; // TODO: Initialize to an appropriate value
      Dictionary<string, object> actual;
      target.annotations = expected;
      actual = target.annotations;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for body
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void bodyTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.body = expected;
      actual = target.body;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for category
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void categoryTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.category = expected;
      actual = target.category;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for currency
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void currencyTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.currency = expected;
      actual = target.currency;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for errors
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void errorsTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      List<Dictionary<string, string>> expected = null; // TODO: Initialize to an appropriate value
      List<Dictionary<string, string>> actual;
      target.errors = expected;
      actual = target.errors;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for exists
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void existsTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      bool expected = false; // TODO: Initialize to an appropriate value
      bool actual;
      target.exists = expected;
      actual = target.exists;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for expires
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void expiresTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
      DateTime actual;
      target.expires = expected;
      actual = target.expires;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for externalID
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void externalIDTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.externalID = expected;
      actual = target.externalID;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for externalURL
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void externalURLTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.externalURL = expected;
      actual = target.externalURL;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for heading
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void headingTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.heading = expected;
      actual = target.heading;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for history
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void historyTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      List<PostingHistory> expected = null; // TODO: Initialize to an appropriate value
      List<PostingHistory> actual;
      target.history = expected;
      actual = target.history;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for indexed
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void indexedTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
      DateTime actual;
      target.indexed = expected;
      actual = target.indexed;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for language
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void languageTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.language = expected;
      actual = target.language;
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
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      float expected = 0F; // TODO: Initialize to an appropriate value
      float actual;
      target.latitude = expected;
      actual = target.latitude;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for location
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void locationTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.location = expected;
      actual = target.location;
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
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      float expected = 0F; // TODO: Initialize to an appropriate value
      float actual;
      target.longitude = expected;
      actual = target.longitude;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for postKey
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void postKeyTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.postKey = expected;
      actual = target.postKey;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for price
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void priceTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      float expected = 0F; // TODO: Initialize to an appropriate value
      float actual;
      target.price = expected;
      actual = target.price;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for source
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void sourceTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.source = expected;
      actual = target.source;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for status
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void statusTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.status = expected;
      actual = target.status;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for timestamp
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void timestampTest()
    {
      Posting_Accessor target = new Posting_Accessor(); // TODO: Initialize to an appropriate value
      DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
      DateTime actual;
      target.timestamp = expected;
      actual = target.timestamp;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
