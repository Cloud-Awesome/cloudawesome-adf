using CloudAwesome.Adf.Models;
using CloudAwesome.Adf.Pdf.Sections;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CloudAwesome.Adf.Pdf;

public static class GeneratePdf
{
	public static void Run(Factory factory, string outputFilePath)
	{
		QuestPDF.Settings.License = LicenseType.Community;
		
		Document.Create(container =>
		{
			TitlePage.Generate(container);
			Pipelines.Generate(container, factory);
		})
			.GeneratePdf(outputFilePath);
	}
}