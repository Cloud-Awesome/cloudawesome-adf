using CloudAwesome.Adf.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CloudAwesome.Adf.Pdf.Sections;

public static class Pipelines
{
	public static void Generate(IDocumentContainer container, Factory factory)
	{
		foreach (var pipeline in factory.Pipelines)
		{
			container.Page(page =>
			{
				page.Margin(2, Unit.Centimetre);
				page.DefaultTextStyle(x => x.FontSize(12));
					
				page.Header()
					.Text($"Pipeline: {pipeline.Name}")
					.SemiBold().FontSize(24).FontColor(Colors.Black);

				page.Content()
					.Column(x =>
					{
						x.Spacing(20);

						x.Item().Text("Activities").Underline();

						foreach (var activity in pipeline.Activities!)
						{
							x.Item().Text(activity.Name);
							x.Item().Text(activity.Description);
						}
					});

			});
		}
	}
}