using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class AirplaneServiceApiJosJosQueryFlightRequest : IJdRequest<AirplaneServiceApiJosJosQueryFlightResponse>
{
		                                                                                                                                  
public   		string
   pageNo  { get; set; }

                  
                                                            
                                                          
public   		string
   pageSize  { get; set; }

                  
                                                            
                                                          
public   		string
   airways  { get; set; }

                  
                                                            
                                                          
public   		string
   arrCity  { get; set; }

                  
                                                            
                                                          
public   		string
   arrDate  { get; set; }

                  
                                                            
                                                          
public   		string
   arrTime  { get; set; }

                  
                                                            
                                                          
public   		string
   classNo  { get; set; }

                  
                                                            
                                                          
public   		string
   depCity  { get; set; }

                  
                                                            
                                                          
public   		string
   depDate  { get; set; }

                  
                                                            
                                                          
public   		string
   depTime  { get; set; }

                  
                                                            
                                                          
public   		string
   lineType  { get; set; }

                  
                                                            
                                                          
public   		string
   queryModule  { get; set; }

                  
                                                            
                                                          
public   		string
   sourceId  { get; set; }

                  
                                                            
                                                          
public   		string
   clientVersion  { get; set; }

                  
                                                            
                                                          
public   		string
   goTime  { get; set; }

                  
                                                            
                                                          
public   		string
   backTime  { get; set; }

                  
                                                            
                                                          
public   		string
   oneBox  { get; set; }

                  
                                                            
                                                          
public   		string
   queryType  { get; set; }

                  
                                                            
                                                          
public   		string
   flightNo  { get; set; }

                  
                                                            
                                                          
public   		string
   bookingClass  { get; set; }

                  
                                                            
                                                          
public   		string
   secondQueryFlag  { get; set; }

                  
                                                            
                                                          
public   		string
   queryAdtFlag  { get; set; }

                  
                                                            
                                                          
public   		string
   queryAdtNum  { get; set; }

                  
                                                            
                                                          
public   		string
   userPin  { get; set; }

                  
                                                            
                                                          
public   		string
   source  { get; set; }

                  
                                                            
                                                          
public   		string
   sortType  { get; set; }

                  
                                                            
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.airplane.service.api.jos.JosQueryFlight";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("pageNo", this.pageNo);
			parameters.Add("pageSize", this.pageSize);
			parameters.Add("airways", this.airways);
			parameters.Add("arrCity", this.arrCity);
			parameters.Add("arrDate", this.arrDate);
			parameters.Add("arrTime", this.arrTime);
			parameters.Add("classNo", this.classNo);
			parameters.Add("depCity", this.depCity);
			parameters.Add("depDate", this.depDate);
			parameters.Add("depTime", this.depTime);
			parameters.Add("lineType", this.lineType);
			parameters.Add("queryModule", this.queryModule);
			parameters.Add("sourceId", this.sourceId);
			parameters.Add("clientVersion", this.clientVersion);
			parameters.Add("goTime", this.goTime);
			parameters.Add("backTime", this.backTime);
			parameters.Add("oneBox", this.oneBox);
			parameters.Add("queryType", this.queryType);
			parameters.Add("flightNo", this.flightNo);
			parameters.Add("bookingClass", this.bookingClass);
			parameters.Add("secondQueryFlag", this.secondQueryFlag);
			parameters.Add("queryAdtFlag", this.queryAdtFlag);
			parameters.Add("queryAdtNum", this.queryAdtNum);
			parameters.Add("userPin", this.userPin);
			parameters.Add("source", this.source);
			parameters.Add("sortType", this.sortType);
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








        
 

