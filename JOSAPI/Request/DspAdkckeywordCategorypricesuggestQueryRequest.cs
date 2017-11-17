using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspAdkckeywordCategorypricesuggestQueryRequest : IJdRequest<DspAdkckeywordCategorypricesuggestQueryResponse>
{
		                                                                                                       
public   		string
   key  { get; set; }

                  
                                                            
                                                          
public   		string
   mobileType  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.adkckeyword.categorypricesuggest.query";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("key", this.key);
			parameters.Add("mobileType", this.mobileType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
        }

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new JdDictionary();
            }
            this.otherParameters.Add(key, value);
        }

}
}








        
 

