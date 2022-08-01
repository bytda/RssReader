﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RSSreaderMVC.Models
{
    public class RssFeed
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        
        public string PubDate { get; set; }
    }
}

