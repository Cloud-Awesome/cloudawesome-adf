using System.Text.Json;

namespace CloudAwesome.Adf;

public static class AdfJsonParser
{
	public static List<T> Parse<T>(string directoryPath, JsonSerializerOptions options)
	{
		var items = new List<T>();
		var jsonFiles = Directory.GetFiles(directoryPath, "*.json");

		foreach (var file in jsonFiles)
		{
			var json = File.ReadAllText(file);
			var item = JsonSerializer.Deserialize<T>(json, options);
			items.Add(item);
		}

		return items;
	}
}