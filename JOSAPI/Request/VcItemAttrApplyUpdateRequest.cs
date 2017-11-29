using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class VcItemAttrApplyUpdateRequest : IJdRequest<VcItemAttrApplyUpdateResponse>
{
		                                                                                                                                                                   
public   		string
   applyId  { get; set; }

                  
                                                                                                                                    
                                                          
public   		string
   publicName  { get; set; }

                  
                                                                                                                                    
                                                                                                                                                                                                                                                                                                                                                                                                                                                    		public  		string
   wareIds  { get; set; }
                                                                                                                                                                                                                                                                                                                                                                                                                 		public  		string
   colorNames  { get; set; }
                                                                                                                                                                                                                                                                                                                                                                                                                 		public  		string
   colorSorts  { get; set; }
                                                                                                                                                                                                                                                                                                                                                                                                                 		public  		string
   sizeNames  { get; set; }
                                                                                                                                                                                                                                                                                                                                                                                                                 		public  		string
   sizeSorts  { get; set; }
                                                                                                                                                                                                        
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.vc.item.attr.apply.update";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("apply_id", this.applyId);
			parameters.Add("public_name", this.publicName);
			parameters.Add("ware_ids", this.wareIds);
			parameters.Add("color_names", this.colorNames);
			parameters.Add("color_sorts", this.colorSorts);
			parameters.Add("size_names", this.sizeNames);
			parameters.Add("size_sorts", this.sizeSorts);
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








        
 

