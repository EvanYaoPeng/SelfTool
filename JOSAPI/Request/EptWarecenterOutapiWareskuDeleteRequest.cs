using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class EptWarecenterOutapiWareskuDeleteRequest : IJdRequest<EptWarecenterOutapiWareskuDeleteResponse>
{
		                                                                                                                                                                   
public   		Nullable<long>
   skuId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   wareId  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.ept.warecenter.outapi.waresku.delete";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("skuId", this.skuId);
			parameters.Add("wareId", this.wareId);
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








        
 

