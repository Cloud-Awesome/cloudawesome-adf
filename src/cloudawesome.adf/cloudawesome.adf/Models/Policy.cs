using System.Text.Json.Serialization;

namespace CloudAwesome.Adf.Models;

public class Policy
{
	[JsonPropertyName("timeout")]
	public string Timeout { get; set; }
	
	[JsonPropertyName("retry")]
	public int Retry { get; set; }
	
	[JsonPropertyName("retryIntervalInSeconds")]
	public int RetryIntervalInSeconds { get; set; }
}