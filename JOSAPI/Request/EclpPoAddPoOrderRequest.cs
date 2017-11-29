using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class EclpPoAddPoOrderRequest : IJdRequest<EclpPoAddPoOrderResponse>
{
		                                                                                                                                  
public   		string
   spPoOrderNo  { get; set; }

                  
                                                            
                                                          
public   		string
   deptNo  { get; set; }

                  
                                                            
                                                          
public   		string
   whNo  { get; set; }

                  
                                                            
                                                          
public   		string
   supplierNo  { get; set; }

                  
                                                            
                                                                                                                                                                                                                                                                                                                                                                                             		public  		string
   deptGoodsNo  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   numApplication  { get; set; }
                                                                                                                                                                                                                                                                                                                         		public  		string
   goodsStatus  { get; set; }
                                                                                                                                                                       
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.eclp.po.addPoOrder";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("spPoOrderNo", this.spPoOrderNo);
			parameters.Add("deptNo", this.deptNo);
			parameters.Add("whNo", this.whNo);
			parameters.Add("supplierNo", this.supplierNo);
			parameters.Add("deptGoodsNo", this.deptGoodsNo);
			parameters.Add("numApplication", this.numApplication);
			parameters.Add("goodsStatus", this.goodsStatus);
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








        
 

