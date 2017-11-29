using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class LogisticsO2oCancellstatusUpdateRequest : IJdRequest<LogisticsO2oCancellstatusUpdateResponse>
{
		                                                                                                       
public   		string
   stationNo  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   orderId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   stateOperator  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   orderCancelReason  { get; set; }

                  
                                                                                                                                                            
                                                          
public   		string
   orderCancelRemark  { get; set; }

                  
                                                                                                                                                            

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.logistics.o2o.cancellstatus.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("station_no", this.stationNo);
			parameters.Add("order_id", this.orderId);
			parameters.Add("state_operator", this.stateOperator);
			parameters.Add("order_cancel_reason", this.orderCancelReason);
			parameters.Add("order_cancel_remark", this.orderCancelRemark);
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








        
 

