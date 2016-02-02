using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Food_Hygiene_Ratings.Models{

    internal class Business
    {
        [JsonProperty("addressline1")]
        public string Addressline1 { get; set; }

        [JsonProperty("addressline2")]
        public string Addressline2 { get; set; }

        [JsonProperty("addressline3")]
        public string Addressline3 { get; set; }

        [JsonProperty("addressline4")]
        public string Addressline4 { get; set; }

        [JsonProperty("businessname")]
        public string Businessname { get; set; }

        [JsonProperty("businesstype")]
        public string Businesstype { get; set; }

        [JsonProperty("businesstypeid")]
        public string Businesstypeid { get; set; }

        [JsonProperty("confidenceinmanagementscore")]
        public string Confidenceinmanagementscore { get; set; }

        [JsonProperty("fhrsid")]
        public string Fhrsid { get; set; }

        [JsonProperty("hygienescore")]
        public string Hygienescore { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("localauthoritybusinessid")]
        public string Localauthoritybusinessid { get; set; }

        [JsonProperty("location")]
        public Business Location { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("newratingpending")]
        public bool Newratingpending { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("ratingdate")]
        public string Ratingdate { get; set; }

        [JsonProperty("ratingkey")]
        public string Ratingkey { get; set; }

        [JsonProperty("ratingvalue")]
        public string Ratingvalue { get; set; }

        [JsonProperty("structuralscore")]
        public string Structuralscore { get; set; }
    }

}