using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class WarePromotionInfoGetRequest : IJdRequest<WarePromotionInfoGetResponse>
{
		                                                                      
public   		string
   skuId  { get; set; }

                  
                                                            
                                                          
public   		string
   webSite  { get; set; }

                  
                                                            
                                                          
public   		string
   origin  { get; set; }

                  
                                                            

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.ware.promotionInfo.get";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("skuId", this.skuId);
			parameters.Add("webSite", this.webSite);
			parameters.Add("origin", this.origin);
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








        
 

