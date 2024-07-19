using System.Text.Json;
using CloudAwesome.Adf;
using CloudAwesome.Adf.Models;
using CloudAwesome.Adf.Parsers;
using CloudAwesome.Adf.Pdf;

Console.WriteLine("Started!");

 const string filePath = "C:\\Source\\Clarion\\adf-supermetrics\\src\\pipeline";
 const string outputFilePath =
	 "C:\\Users\\ArthurNicholson-Gumu\\OneDrive - Cloud Awesome\\Work\\Cloud Awesome\\Projects\\Clarion\\SuperMetrics\\Documentation.pdf";

 var options = new JsonSerializerOptions
 {
	 Converters =
	 {
		 new PipelineConverter()
	 }
 };

 var factory = new Factory
 { 
	 Pipelines = AdfJsonParser.Parse<Pipeline>(filePath, options)
 };
 
 
 GeneratePdf.Run(factory, outputFilePath);


 Console.WriteLine("Completed!");