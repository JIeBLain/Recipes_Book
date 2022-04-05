﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Client.Models
{
    public class RecipesList
    {
        [JsonPropertyName("recipes")]
        public IReadOnlyList<RecipeShortInfo> Recipes { get; set; }
        
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}