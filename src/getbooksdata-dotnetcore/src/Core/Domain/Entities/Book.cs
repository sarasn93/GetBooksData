﻿using System;
using System.Collections.Generic;

namespace Core.Domain.Entities
{
    public class Book1
    {
        public BasicBookData book { get; set; }
    }

    public class BasicBookData
    {
        public string id { get; set; }
        public string title { get; set; }
        public int sourceBookId { get; set; }
        public int canonicalId { get; set; }
        public string description { get; set; }
        public string htmlDescription { get; set; }
        public int PublisherID { get; set; }
        public string publisherSlug { get; set; }
        public double price { get; set; }
        public int numberOfPages { get; set; }
        public double rating { get; set; }
        public bool hasTemporaryOff { get; set; }
        public int beforeOffPrice { get; set; }
        public bool isRtl { get; set; }
        public bool showOverlay { get; set; }
        public int PhysicalPrice { get; set; }
        public string ISBN { get; set; }
        public string publishDate { get; set; }
        public int destination { get; set; }
        public string type { get; set; }
        public string refId { get; set; }
        public string coverUri { get; set; }
        public string shareUri { get; set; }
        public string shareText { get; set; }
        public string publisher { get; set; }
        public List<object> labels { get; set; }
        public bool subscriptionAvailable { get; set; }
        public DateTime newsItemCreationDate { get; set; }
        public int state { get; set; }
        public bool encrypted { get; set; }
        public double currencyPrice { get; set; }
        public double currencyBeforeOffPrice { get; set; }
    }
}
