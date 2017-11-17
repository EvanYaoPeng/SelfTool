using System;
using System.Collections.Generic;
using Jd.Api.Response;
using Jd.Api.Util;

namespace Jd.Api.Request
{
public class TeamNearbycountGetRequest : IJdRequest<TeamNearbycountGetResponse>
{
		                                                                                                                                  
public   		string
   longitude  { get; set; }

                  
                                                            
                                                          
public   		string
   latitude  { get; set; }

                  
                                                            
                                                          
public   		string
   radius  { get; set; }

                  
                                                            
                                                          
public   		string
   isTeamExternalUrl  { get; set; }

                  
                                                                                                                                                                                    
                                 
		private IDictionary<string, string> otherParameters;

		public string GetApiName()
        {
			return "jingdong.team.nearbycount.get";
        }

		public IDictionary<string, string> GetParameters()
        {
            JdDictionary parameters = new JdDictionary();
			parameters.Add("longitude", this.longitude);
			parameters.Add("latitude", this.latitude);
			parameters.Add("radius", this.radius);
			parameters.Add("is_team_external_url", this.isTeamExternalUrl);
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








        
 

