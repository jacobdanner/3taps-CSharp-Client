using com.threetaps.model.annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for AnnotationTest and is intended
    ///to contain all AnnotationTest Unit Tests
    ///</summary>
  [TestClass()]
  public class AnnotationTest
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
    ///A test for Annotation Constructor
    ///</summary>
    [TestMethod()]
    public void AnnotationConstructorTest()
    {
      Annotation target = new Annotation();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for annotationType
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void annotationTypeTest()
    {
      Annotation_Accessor target = new Annotation_Accessor(); // TODO: Initialize to an appropriate value
      AnnotationType expected = new AnnotationType(); // TODO: Initialize to an appropriate value
      AnnotationType actual;
      target.annotationType = expected;
      actual = target.annotationType;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for name
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void nameTest()
    {
      Annotation_Accessor target = new Annotation_Accessor(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.name = expected;
      actual = target.name;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for options
    ///</summary>
    [TestMethod()]
    [DeploymentItem("3taps-CSharp-Client.dll")]
    public void optionsTest()
    {
      Annotation_Accessor target = new Annotation_Accessor(); // TODO: Initialize to an appropriate value
      List<AnnotationOption> expected = null; // TODO: Initialize to an appropriate value
      List<AnnotationOption> actual;
      target.options = expected;
      actual = target.options;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
