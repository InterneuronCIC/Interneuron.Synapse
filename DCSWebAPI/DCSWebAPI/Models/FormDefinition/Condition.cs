﻿//Interneuron Synapse

//Copyright(C) 2021  Interneuron CIC

//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

//See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.If not, see<http://www.gnu.org/licenses/>.


﻿using Newtonsoft.Json;

namespace DCSWebAPI.Models.FormDefinition
{
    public class Condition
    {
        [JsonProperty("field_id")]
        public string FieldId { get; set; }

        [JsonProperty("comparetype")]
        public string CompareType { get; set; }

        [JsonProperty("compareoperator")]
        public string CompareOperator { get; set; }

        [JsonProperty("comparevalue")]
        public object[] CompareValue { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("logicoperator")]
        public string LogicOperator { get; set; }

        [JsonProperty("comparedatevalue", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CompareDateValue { get; set; }
    }
}