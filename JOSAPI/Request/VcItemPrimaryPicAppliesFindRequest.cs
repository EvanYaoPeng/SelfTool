using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class VcItemPrimaryPicAppliesFindRequest : IJdRequest<VcItemPrimaryPicAppliesFindResponse>
{
		                                                                                                                                                                   
public   		string
   wareId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   name  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   brandId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		Nullable<int>
   categoryId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		Nullable<int>
   state  { get; set; }

                  
                                                            
                                                          
public   		string
   beginApplyTime  { get; set; }

                  
                                                                                                                                                            
                                                          
public   		string
   endApplyTime  { get; set; }

                  
                                                                                                                                                            
                                                          
public   		string
   page  { get; set; }

                  
                                                            
                                                          
public   		string
   length  { get; set; }

                  
                                                            
                                                          
public   		string
   sidx  { get; set; }

                  
                                                            
                                                          
public   		string
   sord  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.vc.item.primaryPic.applies.find";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("ware_id", this.wareId);
			parameters.Add("name", this.name);
			parameters.Add("brand_id", this.brandId);
			parameters.Add("category_id", this.categoryId);
			parameters.Add("state", this.state);
			parameters.Add("begin_apply_time", this.beginApplyTime);
			parameters.Add("end_apply_time", this.endApplyTime);
			parameters.Add("page", this.page);
			parameters.Add("length", this.length);
			parameters.Add("sidx", this.sidx);
			parameters.Add("sord", this.sord);
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








        
 

