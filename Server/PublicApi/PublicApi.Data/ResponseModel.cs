﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PublicApi.Data
{
	public class ResponseModel
	{
		/// <summary>
		/// List of images -> for each image there is list of Label:Confidency pairs 
		/// Key is string representation of label and Value is confidence in percentages (0.0 to 1.0) 
		/// </summary>
		public List<Dictionary<string, float>> Data { get; set; }
		[JsonIgnore]
		public bool IsOk { get; set; }
		[JsonIgnore]
		public TimeSpan Taken { get; set; }
	}
}
