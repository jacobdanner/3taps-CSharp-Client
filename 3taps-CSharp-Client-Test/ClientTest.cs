using com.threetaps.client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;

namespace _3taps_CSharp_Client_Test
{
  /// <summary>
  ///This is a test class for ClientTest and is intended
  ///to contain all ClientTest Unit Tests
  ///</summary>
  [TestClass()]
  public class ClientTest : BaseTestCase
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
    ///A test for Client Constructor
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void ClientConstructorTest()
    {
      Client_Accessor target = new Client_Accessor();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for Client Constructor
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void ClientConstructorTest1()
    {
      string url = string.Empty; // TODO: Initialize to an appropriate value
      int port = 0; // TODO: Initialize to an appropriate value
      Client_Accessor target = new Client_Accessor(url, port);
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for createEncodedString
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void createEncodedStringTest()
    {
      Client_Accessor target = new Client_Accessor(); // TODO: Initialize to an appropriate value
      Dictionary<string, string> parameters = null; // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      actual = target.createEncodedString(parameters);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for execute
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void executeTest()
    {
      Client_Accessor target = new Client_Accessor(); // TODO: Initialize to an appropriate value
      WebRequest request = null; // TODO: Initialize to an appropriate value
      WebResponse expected = null; // TODO: Initialize to an appropriate value
      WebResponse actual;
      actual = target.execute(request);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for executeGet
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void executeGetTest()
    {
      Client_Accessor target = new Client_Accessor(); // TODO: Initialize to an appropriate value
      string endpoint = string.Empty; // TODO: Initialize to an appropriate value
      WebResponse expected = null; // TODO: Initialize to an appropriate value
      WebResponse actual;
      actual = target.executeGet(endpoint);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for executeGet
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void executeGetTest1()
    {
      Client_Accessor target = new Client_Accessor(); // TODO: Initialize to an appropriate value
      string endpoint = string.Empty; // TODO: Initialize to an appropriate value
      Dictionary<string, string> parameters = null; // TODO: Initialize to an appropriate value
      WebResponse expected = null; // TODO: Initialize to an appropriate value
      WebResponse actual;
      actual = target.executeGet(endpoint, parameters);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for executePost
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void executePostTest()
    {
      Client_Accessor target = new Client_Accessor(); // TODO: Initialize to an appropriate value
      string endpoint = string.Empty; // TODO: Initialize to an appropriate value
      Dictionary<string, string> parameters = null; // TODO: Initialize to an appropriate value
      WebResponse expected = null; // TODO: Initialize to an appropriate value
      WebResponse actual;
      actual = target.executePost(endpoint, parameters);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}