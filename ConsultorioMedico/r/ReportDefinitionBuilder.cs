// ReportDefinitionBuilder.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsultorioMedico
{
    internal sealed class ReportDefinitionBuilder
    {
        private sealed class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => new UTF8Encoding(false);
        }

        private sealed class ReportColumn
        {
            public string OriginalName { get; }
            public string FieldName { get; }

            public ReportColumn(string originalName, string fieldName)
            {
                OriginalName = originalName;
                FieldName = fieldName;
            }
        }

        private const double UsableWidth = 10.0;
        private static readonly XNamespace Ns = "http://schemas.microsoft.com/sqlserver/reporting/2008/01/reportdefinition";
        private static readonly XNamespace Rd = "http://schemas.microsoft.com/SQLServer/reporting/reportdesigner";

        public string Build(DataTable table, string reportTitle)
        {
            if (table == null) throw new ArgumentNullException(nameof(table));

            if (table.Columns.Count == 0)
            {
                table.Columns.Add("Mensaje", typeof(string));
                table.Rows.Add("Sin datos para mostrar");
            }

            var cols = table.Columns
                .Cast<DataColumn>()
                .Select((c, i) => new ReportColumn(c.ColumnName, SafeFieldName(c.ColumnName, i)))
                .ToList();

            double colWidth = UsableWidth / Math.Max(1, cols.Count);
            colWidth = Math.Max(0.65, Math.Min(2.0, colWidth));
            double reportWidth = colWidth * cols.Count;
            if (reportWidth > UsableWidth)
            {
                colWidth = UsableWidth / Math.Max(1, cols.Count);
                reportWidth = UsableWidth;
            }

            XElement TextRun(string value) =>
                new XElement(Ns + "TextRun",
                    new XElement(Ns + "Value", value),
                    new XElement(Ns + "Style"));

            XElement Paragraph(string value) =>
                new XElement(Ns + "Paragraph",
                    new XElement(Ns + "TextRuns", TextRun(value)),
                    new XElement(Ns + "Style"));

            XElement Textbox(string name, IEnumerable<XElement> extras, string value, XElement style) =>
                new XElement(Ns + "Textbox", new XAttribute("Name", name),
                    extras,
                    new XElement(Ns + "CanGrow", "true"),
                    new XElement(Ns + "Paragraphs", Paragraph(value)),
                    style);

            XElement HeaderCell(ReportColumn col) =>
                new XElement(Ns + "TablixCell",
                    new XElement(Ns + "CellContents",
                        Textbox($"hdr_{col.FieldName}", null, col.OriginalName,
                            new XElement(Ns + "Style",
                                new XElement(Ns + "Border",
                                    new XElement(Ns + "Style", "Solid"),
                                    new XElement(Ns + "Color", "#334155")),
                                new XElement(Ns + "BackgroundColor", "#1E293B"),
                                new XElement(Ns + "Color", "White"),
                                new XElement(Ns + "FontFamily", "Segoe UI"),
                                new XElement(Ns + "FontSize", "10pt"),
                                new XElement(Ns + "FontWeight", "Bold"),
                                new XElement(Ns + "TextAlign", "Center"),
                                new XElement(Ns + "VerticalAlign", "Middle"),
                                new XElement(Ns + "PaddingLeft", "6pt"),
                                new XElement(Ns + "PaddingRight", "6pt"),
                                new XElement(Ns + "PaddingTop", "6pt"),
                                new XElement(Ns + "PaddingBottom", "6pt")))));

            XElement DataCell(ReportColumn col) =>
                new XElement(Ns + "TablixCell",
                    new XElement(Ns + "CellContents",
                        Textbox($"txt_{col.FieldName}", null, $"=Fields!{col.FieldName}.Value",
                            new XElement(Ns + "Style",
                                new XElement(Ns + "Border",
                                    new XElement(Ns + "Style", "Solid"),
                                    new XElement(Ns + "Color", "#E2E8F0")),
                                new XElement(Ns + "BackgroundColor",
                                    "=IIF(RowNumber(Nothing) MOD 2 = 0, \"#F8FAFC\", \"White\")"),
                                new XElement(Ns + "Color", "#334155"),
                                new XElement(Ns + "FontFamily", "Segoe UI"),
                                new XElement(Ns + "FontSize", "9pt"),
                                new XElement(Ns + "VerticalAlign", "Middle"),
                                new XElement(Ns + "PaddingLeft", "6pt"),
                                new XElement(Ns + "PaddingRight", "6pt"),
                                new XElement(Ns + "PaddingTop", "5pt"),
                                new XElement(Ns + "PaddingBottom", "5pt")))));

            var doc = new XDocument(
                new XDeclaration("1.0", "utf-8", null),
                new XElement(Ns + "Report",
                    new XAttribute(XNamespace.Xmlns + "rd", Rd),
                    new XElement(Ns + "Language", "es-DO"),
                    new XElement(Ns + "Body",
                        new XElement(Ns + "ReportItems",
                            new XElement(Ns + "Tablix", new XAttribute("Name", "Tablix1"),
                                new XElement(Ns + "Top", "0in"),
                                new XElement(Ns + "Left", "0in"),
                                new XElement(Ns + "TablixBody",
                                    new XElement(Ns + "TablixColumns",
                                        cols.Select(_ => new XElement(Ns + "TablixColumn",
                                            new XElement(Ns + "Width", $"{colWidth:0.###}in")))),
                                    new XElement(Ns + "TablixRows",
                                        new XElement(Ns + "TablixRow",
                                            new XElement(Ns + "Height", "0.35in"),
                                            new XElement(Ns + "TablixCells", cols.Select(HeaderCell))),
                                        new XElement(Ns + "TablixRow",
                                            new XElement(Ns + "Height", "0.30in"),
                                            new XElement(Ns + "TablixCells", cols.Select(DataCell))))),
                                new XElement(Ns + "TablixColumnHierarchy",
                                    new XElement(Ns + "TablixMembers",
                                        cols.Select(_ => new XElement(Ns + "TablixMember")))),
                                new XElement(Ns + "TablixRowHierarchy",
                                    new XElement(Ns + "TablixMembers",
                                        new XElement(Ns + "TablixMember",
                                            new XElement(Ns + "KeepWithGroup", "After")),
                                        new XElement(Ns + "TablixMember",
                                            new XElement(Ns + "Group",
                                                new XAttribute("Name", "Details"))))),
                                new XElement(Ns + "DataSetName", "DataSet1"),
                                new XElement(Ns + "Height", "0.65in"),
                                new XElement(Ns + "Width", $"{reportWidth:0.###}in"),
                                new XElement(Ns + "Style"))),
                        new XElement(Ns + "Height", "3in"),
                        new XElement(Ns + "Style")),
                    new XElement(Ns + "Width", $"{reportWidth:0.###}in"),
                    new XElement(Ns + "Page",
                        new XElement(Ns + "PageWidth", "11in"),
                        new XElement(Ns + "PageHeight", "8.5in"),
                        new XElement(Ns + "LeftMargin", "0.5in"),
                        new XElement(Ns + "RightMargin", "0.5in"),
                        new XElement(Ns + "TopMargin", "0.5in"),
                        new XElement(Ns + "BottomMargin", "0.5in"),
                        new XElement(Ns + "Style"),
                        new XElement(Ns + "PageHeader",
                            new XElement(Ns + "Height", "0.75in"),
                            new XElement(Ns + "PrintOnFirstPage", "true"),
                            new XElement(Ns + "PrintOnLastPage", "true"),
                            new XElement(Ns + "ReportItems",
                                Textbox("txtTituloReporte",
                                    new[]
                                    {
                                        new XElement(Ns + "Top", "0in"),
                                        new XElement(Ns + "Left", "0in"),
                                        new XElement(Ns + "Height", "0.45in"),
                                        new XElement(Ns + "Width", "10in")
                                    },
                                    reportTitle,
                                    new XElement(Ns + "Style",
                                        new XElement(Ns + "FontFamily", "Segoe UI"),
                                        new XElement(Ns + "FontSize", "22pt"),
                                        new XElement(Ns + "FontWeight", "Bold"),
                                        new XElement(Ns + "TextAlign", "Center"),
                                        new XElement(Ns + "VerticalAlign", "Middle"),
                                        new XElement(Ns + "Color", "#0F172A"),
                                        new XElement(Ns + "PaddingBottom", "6pt"))),
                                Textbox("txtFechaReporte",
                                    new[]
                                    {
                                        new XElement(Ns + "Top", "0.45in"),
                                        new XElement(Ns + "Left", "0in"),
                                        new XElement(Ns + "Height", "0.25in"),
                                        new XElement(Ns + "Width", "10in")
                                    },
                                    "=Format(Globals!ExecutionTime, \"dd/MM/yyyy\")",
                                    new XElement(Ns + "Style",
                                        new XElement(Ns + "FontFamily", "Segoe UI"),
                                        new XElement(Ns + "FontSize", "10pt"),
                                        new XElement(Ns + "TextAlign", "Center"),
                                        new XElement(Ns + "VerticalAlign", "Middle"),
                                        new XElement(Ns + "Color", "#64748B")))), // FIX: Added 4th parenthesis to properly close ReportItems
                            new XElement(Ns + "Style"))
                    ), // <-- properly close Page
                    new XElement(Ns + "AutoRefresh", "0"),
                    new XElement(Ns + "DataSources",
                        new XElement(Ns + "DataSource", new XAttribute("Name", "ReporteLocal"),
                            new XElement(Ns + "ConnectionProperties",
                                new XElement(Ns + "DataProvider", "System.Data.DataSet"),
                                new XElement(Ns + "ConnectString", "/* Local Connection */")),
                            new XElement(Rd + "DataSourceID",
                                "6f60a1aa-abb3-48e7-96ba-28963e824df0"))),
                    new XElement(Ns + "DataSets",
                        new XElement(Ns + "DataSet", new XAttribute("Name", "DataSet1"),
                            new XElement(Ns + "Query",
                                new XElement(Ns + "DataSourceName", "ReporteLocal"),
                                new XElement(Ns + "CommandText", "/* Local Query */")),
                            new XElement(Ns + "Fields",
                                cols.Select(c =>
                                    new XElement(Ns + "Field", new XAttribute("Name", c.FieldName),
                                        new XElement(Ns + "DataField", c.OriginalName),
                                        new XElement(Rd + "TypeName", "System.String")))))),
                    new XElement(Rd + "ReportUnitType", "Inch"),
                    new XElement(Rd + "ReportID", "ed2cd13d-f30a-45b1-b00e-9aceb6dab8ce")));

            using var sw = new Utf8StringWriter();
            doc.Save(sw);
            return sw.ToString();
        }

        private static string SafeFieldName(string name, int index)
        {
            var sb = new StringBuilder();
            if (string.IsNullOrWhiteSpace(name))
                name = $"Col{index + 1}";

            foreach (var ch in name)
            {
                if (char.IsLetterOrDigit(ch) || ch == '_')
                    sb.Append(ch);
                else
                    sb.Append('_');
            }

            if (sb.Length == 0 || char.IsDigit(sb[0]))
                sb.Insert(0, '_');

            return sb.ToString();
        }
    }
}