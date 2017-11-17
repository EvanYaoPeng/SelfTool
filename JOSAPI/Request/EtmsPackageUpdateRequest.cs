using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class EtmsPackageUpdateRequest : IJdRequest<EtmsPackageUpdateResponse>
{
		                                                                                                                                  
public   		string
   customerCode  { get; set; }

                  
                                                            
                                                          
public   		string
   deliveryId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   packageCount  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.etms.package.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("customerCode", this.customerCode);
			parameters.Add("deliveryId", this.deliveryId);
			parameters.Add("packageCount", this.packageCount);
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








        
 

