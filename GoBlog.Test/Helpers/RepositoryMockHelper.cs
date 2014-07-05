﻿using FakeDbSet;
using GoBlog.Infrastructure.Persistence;
using GoBlog.Infrastructure.Persistence.Entities;
using Moq;

namespace GoBlog.Test.Helpers
{
    internal static class RepositoryMockHelper
    {
        internal static Mock<IRepository> MockRepository()
        {
            var repository = new Mock<IRepository>();

            var posts = new InMemoryDbSet<Post>()
            {
                new Post {
                    Slug    = "dynamic-contagion-part-one",
                    Title   = "Dynamic contagion, part one",
                    Summary = "Suppose you're an epidemiologis",
                    Content = "Suppose you're an epidemiologis"
                },
                new Post {
                    Slug    = "dynamic-contagion-part-two",
                    Title   = "Dynamic contagion, part two",
                    Summary = "Last time I discussed how ",
                    Content = "Last time I discussed how"
                },               
                new Post {
                    Slug    = "when-should-i-write-a-property",
                    Title   = "When should I write a property?",
                    Summary = "One of the questions I’m asked",
                    Content = "One of the questions I’m asked"
                },
                new Post {
                    Slug    = "lowering-in-langauge-design-part-two",
                    Title   = "Lowering in language design, part two",
                    Summary = "Last time on FAIC I described how",
                    Content = "Last time on FAIC I described how"
                }
            };

            repository.Setup(db => db.Posts).Returns(posts);

            return repository;
        }
    }
}