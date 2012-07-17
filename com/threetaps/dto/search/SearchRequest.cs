using System;
using System.Collections.Generic;
using com.threetaps.util;

namespace com.threetaps.dto.search
{
    public class SearchRequest : IQueryRequest
    {
        /**
        * The number of results to return per page. Default is 100.
        */
        public int rpp { get; set; }
        /**
         * The page number of results to return, where 0 is the
         * first page of results. Default is 0.
         */
        public int page { get; set; }
        /**
         * 5-character code reprepresenting the source that
         * postings must be associated with to be found/processed.
         * Multiple sources may be specified by passing in
         * multiple source codes, separated by +OR+.
         */
        public string source { get; set; }
        /**
         * 4-character code representing the category that postings must be
         * associated with to be found/processed. Multiple categories may be
         * specified by passing in multiple category codes, separated by +OR+.
         */
        public string category { get; set; }
        public string location { get; set; }
        public string heading { get; set; }
        public string body { get; set; }
        public string text { get; set; }
        public string externalID { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public Dictionary<string, string> annotations { get; set; }
        public Dictionary<string, string> trustedAnnotations { get; set; }
        public List<string> retvals = new List<string>();


        public Dictionary<string, string> getQueryParams()
        {
            Dictionary<string, string> queryParams = new Dictionary<string, string>();

            if (rpp != null)
            {
                queryParams["rpp"] = rpp.ToString();
            }

            if (page != null)
            {
                queryParams["page"] = page.ToString();
            }

            if (source != null)
            {
                queryParams["source"] = source;
            }

            if (category != null)
            {
                queryParams["category"] = category;
            }
            if (location != null)
            {
                queryParams["location"] = location;
            }
            if (heading != null)
            {
                queryParams["heading"] = heading;
            }
            if (body != null)
            {
                queryParams["body"] = body;
            }
            if (text != null)
            {
                queryParams["text"] = text;
            }
            if (externalID != null)
            {
                queryParams["externalID"] = externalID;
            }

            //DateFormat df = new SimpleDateFormat(Constants.DATE_FORMAT);

            if (start != null)
            {
                queryParams["start"] = start.ToString(Constants.DATE_FORMAT);
            }
            if (end != null)
            {
                queryParams["end"] = end.ToString(Constants.DATE_FORMAT);
            }

            /*
        final Type annotationType = new TypeToken<Map<String, String>>()
        {
        }.getType();
        final Gson gson = new GsonBuilder()
            .registerTypeAdapter(Map.class, new GeneralObjectDeserializer())
            .create();
            */

            if (annotations != null && annotations.Count > 0)
            {
                throw new NotImplementedException();
                //queryParams["annotations"] = gson.toJson(annotations, annotationType);
            }

            if (trustedAnnotations != null && trustedAnnotations.Count > 0)
            {
                throw new NotImplementedException();
                // queryParams["trustedAnnotations"] = gson.toJson(trustedAnnotations, annotationType);
            }

            queryParams["retvals"] = Utils.Join(retvals);

            return queryParams;
        }
    }
}