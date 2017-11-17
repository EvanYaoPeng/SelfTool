using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class DspAdkckeywordUsedKeywordListRequest : IJdRequest<DspAdkckeywordUsedKeywordListResponse>
{
		                                                                                                                                  
public   		string
   startTime  { get; set; }

                  
                                                            
                                                          
public   		string
   endTime  { get; set; }

                  
                                                            
                                                          
public   		string
   orderType  { get; set; }

                  
                                                            
                                                          
public   		Nullable<long>
   adGroupId  { get; set; }

                  
                                                            
                                                          
public   		string
   campaignId  { get; set; }

                  
                                                            
                                                          
public   		string
   type  { get; set; }

                  
                                                            
                                                                                                                                                                                        
public   		string
   pageNum  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   pageSize  { get; set; }

                  
                                                            
                                                                  
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.dsp.adkckeyword.usedKeyword.list";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("startTime", this.startTime);
			parameters.Add("endTime", this.endTime);
			parameters.Add("orderType", this.orderType);
			parameters.Add("adGroupId", this.adGroupId);
			parameters.Add("campaignId", this.campaignId);
			parameters.Add("type", this.type);
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








        
 

