using System;
using System.Collections.Generic;

namespace Csn.Public.Dto
{
    public class Media
    {
        public List<Photo> Photos { get; set; }
        public List<Video> Videos { get; set; }
        public List<Link> Links { get; set; }
    }

    public class MediaItem
    {
        public Guid? Identifier { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string ThumbUrl { get; set; }
        public string Caption { get; set; }
        public DateTime? LastModifiedUtc { get; set; }
        public int Order { get; set; }
        public List<Tag> Tags { get; set; }
    }

    public class Photo : MediaItem
    {
        public string Angle { get; set; }
    }

    public class Video : MediaItem
    {
        public List<VideoEncoding> Encodings { get; set; }
    }

    public class VideoEncoding 
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
    }

    public class Link : MediaItem
    {
        public string Name { get; set; }
        public DateTime ExpiryDateUtc { get; set; }
        public DateTime IssueDateUtc { get; set; }
    }
}
