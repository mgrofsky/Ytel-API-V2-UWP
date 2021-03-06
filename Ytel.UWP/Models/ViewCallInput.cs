/*
 * Ytel.UWP
 *
 * This file was automatically generated for ytel by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;


namespace ytel.Models
{
    public class ViewCallInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string callsid;
        private string responseType = "json";

        /// <summary>
        /// The unique identifier for the voice call.
        /// </summary>
        [JsonProperty("callsid")]
        public string Callsid 
        { 
            get 
            {
                return this.callsid; 
            } 
            set 
            {
                this.callsid = value;
                onPropertyChanged("Callsid");
            }
        }

        /// <summary>
        /// Response type format xml or json
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType 
        { 
            get 
            {
                return this.responseType; 
            } 
            set 
            {
                this.responseType = value;
                onPropertyChanged("ResponseType");
            }
        }
    }
} 