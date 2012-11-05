using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.threetaps.model;

namespace _3taps_CSharp_Client_Test
{
  [TestClass]
  public class BaseTestCase
  {
    public static readonly string API_KEY = "jmrfhu59cnmtnzusshd62pbg";
    
    /**
     * "location": {
     "latitude": 42.33143,
     "longitude": -83.04575,
     "accuracy": 4,
     "countryCode": "USA",
     "regionCode": "USA-DET-WAY",
     "stateCode": "USA-MI",
     "metroCode": "CAN-YQG",
     "countyCode": "USA-MI-WAY",
     "cityCode": "USA-DET-DET",
     "localityCode": "USA-DET-DOW",
     "zipCode": "USA-48226"
    */
    protected Location getExampleLocation()
    {
      Location l = new Location();
      l.latitude=42.33143F;
     l.longitude=-83.04575F;
     l.accuracy=4;
     l.countryCode="USA";
     l.regionCode="USA-DET-WAY";
     l.stateCode="USA-MI";
     l.metroCode="CAN-YQG";
     l.countyCode="USA-MI-WAY";
     l.cityCode="USA-DET-DET";
     l.localityCode="USA-DET-DOW";
     l.zipCode ="USA-48226";
      return l;
    }

    /**
     * {
"accountId": 1,
"annotations": {
     "source_account": "gc5kc-3369094038@sale.craigslist.org",
     "source_neighborhood": "flat rock",
     "phone": "7347789547",
     "source_continent": "usa",
     "source_loc": "detroit",
     "source_cat": "sss",
     "source_subloc": "wyn",
     "year": "2012",
     "source_state": "michigan",
     "source_subcat": "ela|ele"
},
"body": "i have a sony home theatre system for sale it is in great condition works perfect i upgraded to a sound bar so i have no use for this system i am asking 50 obo no reasonable offer refused if interested call 7347789547      Location flat rock  its NOT ok to contact this poster with services or other commercial interests    PostingID 3369094038     Copyright copy 2012 craigslist inc  terms of use  privacy policy  feedback forum  ",
"category": "SELE",
"categoryClass": "SSSS",
"categoryClassName": "For Sale",
"categoryName": "Electronics & Photo",
"currency": "USD",
"expirationTimestamp": "2012-12-11T19:53:00Z",
"flags": 1,
"hasImage": false,
"heading": "sony surround sound home theatre system",
"html": "PCFET0NUWVBFIGh0bWwgUFVCTElDICItLy9XM0MvL0RURCBIVE1MIDQuMDEgVHJhbnNpdGlvbmF...",
"id": 91875921,
"images": [],
"immortal": false,
"indexed": "2012-11-05T03:29:41Z",
"language": "EN",
"location": {
     "latitude": 42.33143,
     "longitude": -83.04575,
     "accuracy": 4,
     "countryCode": "USA",
     "regionCode": "USA-DET-WAY",
     "stateCode": "USA-MI",
     "metroCode": "CAN-YQG",
     "countyCode": "USA-MI-WAY",
     "cityCode": "USA-DET-DET",
     "localityCode": "USA-DET-DOW",
     "zipCode": "USA-48226"
},
"postingTimestamp": "2012-10-27T19:53:00Z",
"price": 50,
"source": "CRAIG",
"sourceId": 3369094038,
"sourceUrl": "http://detroit.craigslist.org/wyn/ele/3369094038.html"
}
     */
    protected Posting getExamplePosting()
    {
      Posting p = new Posting();
      p.accountId = "1";// 1;
      p.annotations = createPostingAnnotations();
      p.body = "test example body";
      p.category = "SELE";
      p.categoryClass = "SSSS";
      p.categoryClassName = "For Sale";
      p.categoryName="Electronics & Photo";
      p.currency="USD";
      p.expirationTimestamp= "2012-12-11T19:53:00Z";
      p.flags= 1;
      p.hasImage= false;
      p.heading= "sony surround sound home theatre system";
      p.html= "PCFET0NUWVBFIGh0bWwgUFVCTElDICItLy9XM0MvL0RURCBIVE1MIDQuMDEgVHJhbnNpdGlvbmF...";
      p.id = "91875921";//91875921;
      p.images= new Dictionary<string, string>();
      p.immortal= false;
      p.indexed= "2012-11-05T03:29:41Z";
      p.language= "EN";
      p.location = getExampleLocation();
      p.postingTimestamp="2012-10-27T19:53:00Z";
      p.price = 50F;
      p.source="CRAIG";
      p.sourceId = "3369094038";//3369094038F;
      p.sourceUrl="http://detroit.craigslist.org/wyn/ele/3369094038.html";
      return p;
    }

    /*
     * "annotations": {
     "source_account": "gc5kc-3369094038@sale.craigslist.org",
     "source_neighborhood": "flat rock",
     "phone": "7347789547",
     "source_continent": "usa",
     "source_loc": "detroit",
     "source_cat": "sss",
     "source_subloc": "wyn",
     "year": "2012",
     "source_state": "michigan",
     "source_subcat": "ela|ele"
     */
    private Dictionary<string, string> createPostingAnnotations()
    {
      Dictionary<string, string> anno = new Dictionary<string, string>();
      

        anno.Add("source_account", "gc5kc-3369094038@sale.craigslist.org");
     anno.Add("source_neighborhood", "flat rock");
     anno.Add("phone", "7347789547");
     anno.Add("source_continent", "usa");
     anno.Add("source_loc", "detroit");
     anno.Add("source_cat", "sss");
     anno.Add("source_subloc", "wyn");
     anno.Add("year", "2012");
     anno.Add("source_state", "michigan");
     anno.Add("source_subcat", "ela|ele");
      return anno;
    }


  }
}