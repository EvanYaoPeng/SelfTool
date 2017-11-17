using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class KuaicheZnPlanSearchKeywordAddRequest : IJdRequest<KuaicheZnPlanSearchKeywordAddResponse>
{
		                                                                                                                                        
public   		Nullable<long>
   planId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   keywordPrice  { get; set; }

                  
                                                                                                                                    

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.kuaiche.zn.plan.search.keyword.add";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("plan_id", this.planId);
			parameters.Add("keyword_price", this.keywordPrice);
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








        
 

