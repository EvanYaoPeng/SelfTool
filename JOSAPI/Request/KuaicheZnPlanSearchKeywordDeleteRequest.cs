using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class KuaicheZnPlanSearchKeywordDeleteRequest : IJdRequest<KuaicheZnPlanSearchKeywordDeleteResponse>
{
		                                                                                                                                        
public   		Nullable<long>
   planId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   keywordIds  { get; set; }

                  
                                                                                                                                    

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.kuaiche.zn.plan.search.keyword.delete";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("plan_id", this.planId);
			parameters.Add("keyword_ids", this.keywordIds);
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








        
 

