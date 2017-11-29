using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class LogisticsO2oDispatchstatusUpdateRequest : IJdRequest<LogisticsO2oDispatchstatusUpdateResponse>
{
		                                                                                                       
public   		string
   stationNo  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   orderId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   stateOperator  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   antiDispatcherRemark  { get; set; }

                  
                                                                                                                                                            

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.logistics.o2o.dispatchstatus.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("station_no", this.stationNo);
			parameters.Add("order_id", this.orderId);
			parameters.Add("state_operator", this.stateOperator);
			parameters.Add("anti_dispatcher_remark", this.antiDispatcherRemark);
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








        
 

