using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DropshipDpsDeliveryRequest : IJdRequest<DropshipDpsDeliveryResponse>
{
		                                                                                                                                                                   
public   		Nullable<long>
   customOrderId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   carrierId  { get; set; }

                  
                                                            
                                                          
public   		string
   carrierBusinessName  { get; set; }

                  
                                                            
                                                          
public   		string
   shipNo  { get; set; }

                  
                                                            
                                                          
public   		Nullable<DateTime>
   estimateDate  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dropship.dps.delivery";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("customOrderId", this.customOrderId);
			parameters.Add("carrierId", this.carrierId);
			parameters.Add("carrierBusinessName", this.carrierBusinessName);
			parameters.Add("shipNo", this.shipNo);
			parameters.Add("estimateDate", this.estimateDate);
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








        
 

