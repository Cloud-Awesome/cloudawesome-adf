using System.Text.Json.Serialization;

namespace CloudAwesome.Adf.Models;

public class Pipeline
{
	[JsonPropertyName("name")]
	public string? Name { get; set; }
	
	[JsonPropertyName("description")]
	public string? Description { get; set; }
	
	[JsonPropertyName("activities")]
	public List<Activity>? Activities { get; set; }
}