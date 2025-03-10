﻿namespace CoursesProviderAPI
{
    public class CourseModel
    {
        public int Id { get; set; }
        public bool IsBestseller { get; set; }
        public string Image { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Price { get; set; } = null!;
        public string? DiscountPrice { get; set; }
        public string Hours { get; set; } = null!;
        public string LikesInPercent { get; set; } = null!;
        public string LikesInNumbers { get; set; } = null!;
    }
}
