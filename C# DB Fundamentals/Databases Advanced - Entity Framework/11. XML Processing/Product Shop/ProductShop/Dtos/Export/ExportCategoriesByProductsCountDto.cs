﻿namespace ProductShop.Dtos.Export
{
    using System.Xml.Serialization;

    [XmlType("Category")]
    public class ExportCategoriesByProductsCountDto
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("count")]
        public int Count { get; set; }

        [XmlElement("averagePrice")]
        public decimal AveragePrice { get => TotalRevenue / Count;}

        [XmlElement("totalRevenue")]
        public decimal TotalRevenue { get; set; }
    }
}
