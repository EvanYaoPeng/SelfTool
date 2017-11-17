using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class ImageWriteDeleteRequest : IJdRequest<ImageWriteDeleteResponse>
{
		                                                                                                                                                                                                                                                                                                       
public   		Nullable<long>
   wareId  { get; set; }

                  
                                                            
                                                                                      
public   		string
   colorIds  { get; set; }

                  
                                                            
                                                                                      
public   		string
   imgIndexes  { get; set; }

                  
                                                            

		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.image.write.delete";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("wareId", this.wareId);
			parameters.Add("colorIds", this.colorIds);
			parameters.Add("imgIndexes", this.imgIndexes);
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








        
 

