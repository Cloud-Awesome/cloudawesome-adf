using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CloudAwesome.Adf.Pdf.Sections;

public static class TitlePage
{
	public static void Generate(IDocumentContainer container)
	{
		container.Page(page =>
		{
			page.Size(PageSizes.A4);
			page.Margin(2, Unit.Centimetre);
			page.PageColor(Colors.White);
			page.DefaultTextStyle(x => x.FontSize(12));

			page.Header()
				.Text("ADF Documentation")
				.SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);
		});
	}
}