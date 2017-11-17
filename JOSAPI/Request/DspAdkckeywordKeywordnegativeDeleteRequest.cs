using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspAdkckeywordKeywordnegativeDeleteRequest : IJdRequest<DspAdkckeywordKeywordnegativeDeleteResponse>
{
		                                                                                                                                                                                                                                                                                                                                                                        		public  		string
   id  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   keywordName  { get; set; }
                                                                                                                                                                                                                                                                  
public   		Nullable<long>
   adGroupId  { get; set; }

                  
                                                            

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.adkckeyword.keywordnegative.delete";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("id", this.id);
			parameters.Add("keywordName", this.keywordName);
			parameters.Add("adGroupId", this.adGroupId);
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








        
 

