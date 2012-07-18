using com.threetaps.dto.posting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for DeleteResponseTest and is intended
    ///to contain all DeleteResponseTest Unit Tests
    ///</summary>
  [TestClass()]
  public class DeleteResponseTest
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
    ///A test for DeleteResponse Constructor
    ///</summary>
    [TestMethod()]
    public void DeleteResponseConstructorTest()
    {
      DeleteResponse target = new DeleteResponse();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for success
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void successTest()
    {
      DeleteResponse_Accessor target = new DeleteResponse_Accessor(); // TODO: Initialize to an appropriate value
      bool expected = false; // TODO: Initialize to an appropriate value
      bool actual;
      target.success = expected;
      actual = target.success;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
