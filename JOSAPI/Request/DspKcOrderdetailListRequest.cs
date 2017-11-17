using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspKcOrderdetailListRequest : IJdRequest<DspKcOrderdetailListResponse>
{
		                                                                                                                                                              
public   		string
   mySelfList  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   mobileType  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   campaignId  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   adgroupid  { get; set; }

                  
                                                            
                                                          
public   		string
   province  { get; set; }

                  
                                                            
                                                          
public   		Nullable<DateTime>
   clickStartTime  { get; set; }

                  
                                                            
                                                          
public   		Nullable<DateTime>
   clickEndTime  { get; set; }

                  
                                                            
                                                          
public   		Nullable<DateTime>
   startTime  { get; set; }

                  
                                                            
                                                          
public   		Nullable<DateTime>
   endTime  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   orderStatus  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   source  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   realTime  { get; set; }

                  
                                                            
                                                                                                                                                                                                                         
public   		Nullable<int>
   pageNum  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   pageSize  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.kc.orderdetail.list";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("mySelfList", this.mySelfList);
			parameters.Add("mobileType", this.mobileType);
			parameters.Add("campaignId", this.campaignId);
			parameters.Add("adgroupid", this.adgroupid);
			parameters.Add("province", this.province);
			parameters.Add("clickStartTime", this.clickStartTime);
			parameters.Add("clickEndTime", this.clickEndTime);
			parameters.Add("startTime", this.startTime);
			parameters.Add("endTime", this.endTime);
			parameters.Add("orderStatus", this.orderStatus);
			parameters.Add("source", this.source);
			parameters.Add("realTime", this.realTime);
			parameters.Add("pageNum", this.pageNum);
			parameters.Add("pageSize", this.pageSize);
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








        
 

