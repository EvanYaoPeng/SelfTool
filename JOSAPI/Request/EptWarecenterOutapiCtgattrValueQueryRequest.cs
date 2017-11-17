using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class EptWarecenterOutapiCtgattrValueQueryRequest : IJdRequest<EptWarecenterOutapiCtgattrValueQueryResponse>
{
		                                                                                                                                                                   
public   		Nullable<int>
   catId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   propertyId  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.ept.warecenter.outapi.ctgattr.value.query";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("catId", this.catId);
			parameters.Add("propertyId", this.propertyId);
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








        
 

