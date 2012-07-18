using com.threetaps.client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using com.threetaps.dto.search;

namespace _3taps_CSharp_Client_Test
{
  /// <summary>
  ///This is a test class for SearchClientTest and is intended
  ///to contain all SearchClientTest Unit Tests
  ///</summary>
  [TestClass()]
  public class SearchClientTest : BaseTestCase
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

    private SearchClient searchClient;

    [TestInitialize()]
    public void setUp()
    {
      searchClient = ThreetapsClient.getInstance().setAuthID(API_KEY).searchClient;
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
    ///A test for count
    ///</summary>
    [TestMethod()]
    public void countTest()
    {
  	SearchRequest searchRequest = new SearchRequest();
	
		searchRequest.text = "Nintendo";
		searchRequest.source = "E_BAY";
		searchRequest.location = "LAX";
		
		int count = searchClient.count(searchRequest);
		Assert.IsTrue( count != 0);
    }

   

    /// <summary>
    ///A test for range
    ///</summary>
    [TestMethod()]
    public void rangeTest()
    {
      SearchRequest searchRequest = new SearchRequest();
		searchRequest.text = "Nintendo";
		
		RangeRequest rangeRequest = new RangeRequest();
		rangeRequest.searchRequest = searchRequest;
		rangeRequest.addField("price");
		
		RangeResponse response = searchClient.range(rangeRequest);
		//Assert.IsTrue( response.ranges.get("price").getMin() == 0);
		//assert response.getRanges().get("price").getMax() > 0;   
    }

    /// <summary>
    ///A test for search
    ///</summary>
    [TestMethod()]
    public void searchTest()
    {
      SearchRequest searchRequest = new SearchRequest();
	
		searchRequest.text="Nintendo";
		searchRequest.source= "E_BAY";
		searchRequest.location = "LAX";
		
		SearchResponse searchResponse = searchClient.search(searchRequest);
		Assert.IsTrue(searchResponse.success);
		Assert.IsTrue(searchResponse.numResults > -2);
    }

    /// <summary>
    ///A test for summary
    ///</summary>
    [TestMethod()]
    public void summaryTest()
    {
   	SearchRequest searchRequest = new SearchRequest();	
		searchRequest.text = "Nintendo";
		
		SummaryRequest summaryRequest = new SummaryRequest();
		summaryRequest.searchRequest = searchRequest;
		summaryRequest.dimension = "source";
		
		SummaryResponse summaryResponse = searchClient.summary(summaryRequest);
		Assert.IsTrue(summaryResponse.execTimeMs > 0);
		Assert.IsTrue(summaryResponse.totals.ContainsKey("E_BAY"));
	 }
  }
}