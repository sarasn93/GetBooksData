using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    //public class Rate
    //{
    //    public double value { get; set; }
    //    public int count { get; set; }
    //}

    //public class RateDetail
    //{
    //    public int id { get; set; }
    //    public string title { get; set; }
    //    public double point { get; set; }
    //}

    //public class Author
    //{
    //    public int id { get; set; }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }
    //    public int type { get; set; }
    //    public string slug { get; set; }
    //}

    //public class File
    //{
    //    public int id { get; set; }
    //    public int size { get; set; }
    //    public int type { get; set; }
    //    public int bookId { get; set; }
    //    public int sequenceNo { get; set; }
    //    public string title { get; set; }
    //}

    //public class Category
    //{
    //    public int id { get; set; }
    //    public int parent { get; set; }
    //    public string title { get; set; }
    //    public string slug { get; set; }
    //}

    public class Book
    {
        public int id { get; set; }
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

    //public class Destination
    //{
    //    public int type { get; set; }
    //    public int order { get; set; }
    //    public int navigationPage { get; set; }
    //    public int operationType { get; set; }
    //    public int bookId { get; set; }
    //    public string pageTitle { get; set; }
    //    public Filters filters { get; set; }
    //}

    //public class CorrespondingBook
    //{
    //    public string title { get; set; }
    //    public string color { get; set; }
    //    public string icon { get; set; }
    //    public Destination destination { get; set; }
    //}

    //public class Label
    //{
    //    public int tagID { get; set; }
    //    public string tag { get; set; }
    //}

    //public class Book2
    //{
    //    public int id { get; set; }
    //    public string title { get; set; }
    //    public int sourceBookId { get; set; }
    //    public int canonicalId { get; set; }
    //    public List<CorrespondingBook> correspondingBooks { get; set; }
    //    public string subtitle { get; set; }
    //    public string description { get; set; }
    //    public string htmlDescription { get; set; }
    //    public int PublisherID { get; set; }
    //    public string publisherSlug { get; set; }
    //    public double price { get; set; }
    //    public int numberOfPages { get; set; }
    //    public List<Rate> rates { get; set; }
    //    public List<RateDetail> rateDetails { get; set; }
    //    public bool hasTemporaryOff { get; set; }
    //    public int beforeOffPrice { get; set; }
    //    public bool isRtl { get; set; }
    //    public bool showOverlay { get; set; }
    //    public int PhysicalPrice { get; set; }
    //    public string ISBN { get; set; }
    //    public string publishDate { get; set; }
    //    public int destination { get; set; }
    //    public string type { get; set; }
    //    public string refId { get; set; }
    //    public string coverUri { get; set; }
    //    public string shareUri { get; set; }
    //    public string shareText { get; set; }
    //    public string publisher { get; set; }
    //    public List<Author> authors { get; set; }
    //    public List<File> files { get; set; }
    //    public List<Label> labels { get; set; }
    //    public List<Category> categories { get; set; }
    //    public bool subscriptionAvailable { get; set; }
    //    public DateTime newsItemCreationDate { get; set; }
    //    public int state { get; set; }
    //    public bool encrypted { get; set; }
    //    public double currencyPrice { get; set; }
    //    public double currencyBeforeOffPrice { get; set; }
    //    public double? rating { get; set; }
    //    public string sticker { get; set; }
    //}

    //public class BookData
    //{
    //    public List<Book> books { get; set; }
    //    public int layout { get; set; }
    //    public bool showPrice { get; set; }
    //}

    //public class List
    //{
    //    public int type { get; set; }
    //    public int value { get; set; }
    //}

    //public class Filters
    //{
    //    public List<List> list { get; set; }
    //    public string refId { get; set; }
    //}

    //public class BackgroundConfig
    //{
    //    public int style { get; set; }
    //}

    //public class RelatedBook
    //{
    //    public int type { get; set; }
    //    public string title { get; set; }
    //    public int backgroundStyle { get; set; }
    //    public BookData bookData { get; set; }
    //    public Destination destination { get; set; }
    //    public BackgroundConfig backgroundConfig { get; set; }
    //}

    //public class Root
    //{
    //    public Book book { get; set; }
    //    public List<object> comments { get; set; }
    //    public int commentsCount { get; set; }
    //    public List<RelatedBook> relatedBooks { get; set; }
    //    public string shareText { get; set; }
    //    public List<object> quotes { get; set; }
    //    public int quotesCount { get; set; }
    //    public bool hideOffCoupon { get; set; }
    //}


}
