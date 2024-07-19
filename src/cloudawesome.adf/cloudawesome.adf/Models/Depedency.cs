using System.Text.Json.Serialization;

namespace CloudAwesome.Adf.Models;

public class Depedency
{
	[JsonPropertyName("activity")]
	public string Activity { get; set; }
	
	[JsonPropertyName("dependencyConditions")]
	public string[] DependencyConditions { get; set; }
}