using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class PopLvyouJingdianChargeItemAddRequest : IJdRequest<PopLvyouJingdianChargeItemAddResponse>
{
		                                                                                                                                                                   
public   		Nullable<long>
   jingdianId  { get; set; }

                  
                                                            
                                                          
public   		string
   chargeItemName  { get; set; }

                  
                                                            
                                                          
public   		string
   ticketKindName  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   marketPrice  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.pop.lvyou.jingdian.charge.item.add";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("jingdianId", this.jingdianId);
			parameters.Add("chargeItemName", this.chargeItemName);
			parameters.Add("ticketKindName", this.ticketKindName);
			parameters.Add("marketPrice", this.marketPrice);
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








        
 

