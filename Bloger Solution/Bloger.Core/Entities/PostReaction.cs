﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger.Core.Entities
{
    public class PostReaction : BaseEntity
    {
        public int PostId { get; set; }
        public int? UserId { get; set; } // Make UserId nullable
        public string Reaction { get; set; }
        public DateTime CreatedAt { get; set; }

        public Post Post { get; set; }
        public User User { get; set; }
    }
}
