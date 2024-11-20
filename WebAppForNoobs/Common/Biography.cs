﻿namespace WebAppForNoobs.Common
{
    public class Biography
    {
        public Biography(int authorId)
        {
            AuthorId = authorId;
        }

        public int AuthorId { get; private set; }
        public string Details { get; set; } = string.Empty;
    }
}