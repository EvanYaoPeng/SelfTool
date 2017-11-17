using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class StoreCreateStockInBillRequest : IJdRequest<StoreCreateStockInBillResponse>
{
		                                                                                                                                                                   
public   		Nullable<int>
   arrivalDay  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   comId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		Nullable<long>
   orgId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		Nullable<long>
   whId  { get; set; }

                  
                                                                                                                                    
                                                                                                                                                                                                                                                                                                                                                                                                                                                    		public  		string
   skuCode  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   num  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   remark  { get; set; }
                                                                                                                                                                                                        
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.store.createStockInBill";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("arrivalDay", this.arrivalDay);
			parameters.Add("com_id", this.comId);
			parameters.Add("org_id", this.orgId);
			parameters.Add("wh_id", this.whId);
			parameters.Add("sku_code", this.skuCode);
			parameters.Add("num", this.num);
			parameters.Add("remark", this.remark);
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








        
 

