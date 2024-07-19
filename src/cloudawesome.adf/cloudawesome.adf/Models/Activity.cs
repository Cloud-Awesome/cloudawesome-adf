using System.Text.Json.Serialization;

namespace CloudAwesome.Adf.Models;

public class Activity
{
	[JsonPropertyName("name")]
	public string Name { get; set; }
	
	[JsonPropertyName("description")]
	public string Description { get; set; }
	
	[JsonPropertyName("type")]
	public string Type { get; set; } // Could be an enum
	
	[JsonPropertyName("dependsOn")]
	public List<Depedency> DependsOn { get; set; }
	
	[JsonPropertyName("policy")]
	public Policy Policy { get; set; }
	
}