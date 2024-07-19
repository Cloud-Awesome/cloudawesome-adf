using System.Text.Json;
using System.Text.Json.Serialization;
using CloudAwesome.Adf.Models;

namespace CloudAwesome.Adf.Parsers;

public class PipelineConverter: JsonConverter<Pipeline>
{
	public override Pipeline Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var jsonObject = JsonDocument.ParseValue(ref reader).RootElement;

		var pipeline = new Pipeline
		{
			Name = jsonObject.GetProperty("name").GetString(),
			Activities = jsonObject.GetProperty("properties").GetProperty("activities").Deserialize<List<Activity>>(options)
		};

		return pipeline;
	}

	public override void Write(Utf8JsonWriter writer, Pipeline value, JsonSerializerOptions options)
	{
		throw new NotImplementedException("Not required in this implementation");
	}
}