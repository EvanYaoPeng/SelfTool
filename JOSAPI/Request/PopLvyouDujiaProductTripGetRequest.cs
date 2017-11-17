using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class PopLvyouDujiaProductTripGetRequest : IJdRequest<PopLvyouDujiaProductTripGetResponse>
{
		                                                                                                                                  
public   		string
   productId  { get; set; }

                  
                                                            
                                                                                           
public   		Nullable<int>
   tripDayNum  { get; set; }

                  
                                                            
                                                          
public   		string
   hasTripDesc  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.pop.lvyou.dujia.product.trip.get";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("productId", this.productId);
			parameters.Add("tripDayNum", this.tripDayNum);
			parameters.Add("hasTripDesc", this.hasTripDesc);
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








        
 

