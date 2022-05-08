﻿using System;

namespace Notes.Domain
{
    public class Note
    {
        public Guid UserId  { get; set; }
        public Guid Id  { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime? EditedAt { get; set; }
        public DateTime? CreationDate { get; set; }

    }
}