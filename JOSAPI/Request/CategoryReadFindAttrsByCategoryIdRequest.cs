using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class CategoryReadFindAttrsByCategoryIdRequest : IJdRequest<CategoryReadFindAttrsByCategoryIdResponse>
{
		                                                                                                                                                                                                                                                                                                       
public   		Nullable<long>
   cid  { get; set; }

                  
                                                            
                                                          
public   		Nullable<int>
   attributeType  { get; set; }

                  
                                                            
                                                                                      
public   		string
   field  { get; set; }

                  
                                                            

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.category.read.findAttrsByCategoryId";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("cid", this.cid);
			parameters.Add("attributeType", this.attributeType);
			parameters.Add("field", this.field);
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








        
 

