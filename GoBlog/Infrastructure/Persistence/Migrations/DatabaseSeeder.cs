﻿using System.Data.Entity;
using GoBlog.Infrastructure.Persistence.Entities;

namespace GoBlog.Infrastructure.Persistence.Migrations
{
    public class DatabaseSeeder : DropCreateDatabaseAlways<BlogDatabase>
    {
        protected override void Seed(BlogDatabase context)
        {
            context.Posts.Add(new Post
            {
                Slug    = "how-to-debug-small-problems", 
                Title   = "How to debug small programs", 
                Summary = "If you’re reading this, odds are good it’s because I or someone else linked here",
                Content = @"If you’re reading this, odds are good it’s because I or someone else linked here 
                            from your StackOverflow question shortly before it was closed and deleted. (If 
                            you’re reading this and you’re not in that position, consider leaving your 
                            favourite tips for debugging small programs in the comments.)"
            });

            context.Posts.Add(new Post
            {
                Slug    = "living-with-unchecked-exceptions",
                Title   = "Living with unchecked exceptions",
                Summary = "Hey there fabulous readers: I’d like to get your opinions on unchecked.",
                Content = @"Hey there fabulous readers: I’d like to get your opinions on unchecked 
                            exceptions. Before you run off down to the comments and start typing a short 
                            novel, I want to make sure that we’re all on the same page here."
            });

            context.SaveChanges();
        }
    }
}