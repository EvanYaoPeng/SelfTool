using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspAdkckeywordKeywordDeleteRequest : IJdRequest<DspAdkckeywordKeywordDeleteResponse>
{
		                                                                                                       
public   		Nullable<long>
   adGroupId  { get; set; }

                  
                                                            
                                                                                                                                                                                                                                                                                                                                                                                            		public  		string
   keyWordsName  { get; set; }
                                                                                                                                      
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.adkckeyword.keyword.delete";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("adGroupId", this.adGroupId);
			parameters.Add("keyWordsName", this.keyWordsName);
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








        
 

