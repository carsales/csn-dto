using System;
using System.Collections.Generic;

namespace Csn.Public.Dto.Misc
{
    public class Media
    {
        public List<Photo> Photos { get; set; }
        public List<Video> Videos { get; set; }
        public List<Link> Links { get; set; }
    }

    public class Photo
    {
        public int? Id { get; set; }
        public string PhotoPath { get; set; }
        public string Caption { get; set; }
        public string Angle { get; set; }
        public string Type { get; set; }
        public DateTime? LastModified { get; set; }
    }

    public class Video
    {
        public string ServiceName { get; set; }
        public string VideoUrl { get; set; }
        public string ThumbSmallUrl { get; set; }
        public string ThumbLargeUrl { get; set; }
        public string Type { get; set; }
        public List<VideoEncoding> Encodings { get; set; }
    }

    public class VideoEncoding
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
    }

    public class Link
    {
        public string Identifier { get; set; }
        public string Type { get; set; }

        public string Name { get; set; }

        public string Caption { get; set; }
        public string Url { get; set; }
        public string ThumbUrl { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
