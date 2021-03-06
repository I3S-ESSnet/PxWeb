﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace PCAxis.Query
{
    public class TableResponse
    {
        public TableResponse()
        {
            Columns = new List<TableResponseColumn>();
            Comments = new List<TableResponseComment>();
            Data = new List<TableResponseData>();
        }

        [JsonProperty("columns")]
        public List<TableResponseColumn> Columns { get; set; }

        [JsonProperty("comments")]
        public List<TableResponseComment> Comments { get; set; }

        [JsonProperty("data")]
        public List<TableResponseData> Data { get; set; }
    }

    public class TableResponseColumn
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Comment { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("unit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Unit { get; set; }
    }

    public class TableResponseComment
    {
        [JsonProperty("variable")]
        public string Variable { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class TableResponseData
    {
        public TableResponseData()
        {
            Values = new List<string>();
        }

        [JsonProperty("key")]
        public List<string> Key { get; set; }

        [JsonProperty("values")]
        public List<string> Values { get; set; }

        [JsonProperty("comments", DefaultValueHandling=DefaultValueHandling.Ignore)]
        public List<string> Comments { get; set; }
    }
}
