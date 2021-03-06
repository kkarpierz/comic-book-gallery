﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicGallery.Models {
    public class ComicBook {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favourite { get; set; }

        public string DisplayText {
            get {
                return SeriesTitle + " # " + IssueNumber;
            }
        }

        public string CoverImageFile {
            get {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }

        public string FavouriteTxt {
            get {
                if (Favourite)
                    return "Yes";
                return "No";
            }
        }

    }
}
