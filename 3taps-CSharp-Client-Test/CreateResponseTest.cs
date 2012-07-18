using com.threetaps.dto.posting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using com.threetaps.model;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for CreateResponseTest and is intended
    ///to contain all CreateResponseTest Unit Tests
    ///</summary>
  [TestClass()]
  public class CreateResponseTest
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
    ///A test for CreateResponse Constructor
    ///</summary>
    [TestMethod()]
    public void CreateResponseConstructorTest()
    {
      CreateResponse target = new CreateResponse();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for error
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void errorTest()
    {
      CreateResponse_Accessor target = new CreateResponse_Accessor(); // TODO: Initialize to an appropriate value
      Message expected = null; // TODO: Initialize to an appropriate value
      Message actual;
      target.error = expected;
      actual = target.error;
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
      CreateResponse_Accessor target = new CreateResponse_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.postKey = expected;
      actual = target.postKey;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
