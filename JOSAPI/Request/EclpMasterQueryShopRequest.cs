using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class EclpMasterQueryShopRequest : IJdRequest<EclpMasterQueryShopResponse>
{
		                                                                                                                                  
public   		string
   shopNos  { get; set; }

                  
                                                            
                                                          
public   		string
   isvShopNos  { get; set; }

                  
                                                            
                                                          
public   		string
   deptNo  { get; set; }

                  
                                                            
                                                                  
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.eclp.master.queryShop";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("shopNos", this.shopNos);
			parameters.Add("isvShopNos", this.isvShopNos);
			parameters.Add("deptNo", this.deptNo);
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








        
 

