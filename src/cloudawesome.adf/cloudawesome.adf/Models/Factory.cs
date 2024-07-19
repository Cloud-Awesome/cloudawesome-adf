using System.Text.Json.Serialization;

namespace CloudAwesome.Adf.Models;

public class Factory
{
	[JsonPropertyName("name")]
	public string Name { get; set; }
	
	[JsonPropertyName("location")]
	public string AzureRegion { get; set; }
	
	public List<Pipeline> Pipelines { get; set; }
	
	public List<Trigger> Triggers { get; set; }
	
	public List<LinkedService> LinkedServices { get; set; }
	
	public List<Dataset> Datasets { get; set; }
}