using Bloger.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bloger.Repository.Context
{
    public class BlogDbContextDataSeed
    {
        public static async Task SeedAsync(BlogDbContext blogDbContext)
        {
            await SeedCategoriesAsync(blogDbContext);
            await SeedUsersAsync(blogDbContext);
            await SeedPostsAsync(blogDbContext);
            await SeedCommentsAsync(blogDbContext);
            await SeedTagsAsync(blogDbContext); // Ensure Tags are seeded before PostTags
            await SeedPostTagsAsync(blogDbContext);
            await SeedPostReactionsAsync(blogDbContext);
        }

        private static async Task SeedCategoriesAsync(BlogDbContext blogDbContext)
        {
            if (!blogDbContext.Categories.Any())
            {
                var filePath = Path.Combine("..", "Bloger.Repository", "DataSeed", "Categories.json");
                var categoriesData = await File.ReadAllTextAsync(filePath);
                var categories = JsonSerializer.Deserialize<List<Category>>(categoriesData);

                if (categories?.Count > 0)
                {
                    await blogDbContext.Categories.AddRangeAsync(categories);
                    await blogDbContext.SaveChangesAsync();
                }
            }
        }

        private static async Task SeedUsersAsync(BlogDbContext blogDbContext)
        {
            if (!blogDbContext.Users.Any())
            {
                var filePath = Path.Combine("..", "Bloger.Repository", "DataSeed", "Users.json");
                var usersData = await File.ReadAllTextAsync(filePath);
                var users = JsonSerializer.Deserialize<List<User>>(usersData);

                if (users?.Count > 0)
                {
                    await blogDbContext.Users.AddRangeAsync(users);
                    await blogDbContext.SaveChangesAsync();
                }
            }
        }

        private static async Task SeedPostsAsync(BlogDbContext blogDbContext)
        {
            if (!blogDbContext.Posts.Any())
            {
                var filePath = Path.Combine("..", "Bloger.Repository", "DataSeed", "Posts.json");
                var postsData = await File.ReadAllTextAsync(filePath);
                var posts = JsonSerializer.Deserialize<List<Post>>(postsData);

                if (posts?.Count > 0)
                {
                    await blogDbContext.Posts.AddRangeAsync(posts);
                    await blogDbContext.SaveChangesAsync();
                }
            }
        }

        private static async Task SeedCommentsAsync(BlogDbContext blogDbContext)
        {
            if (!blogDbContext.Comments.Any())
            {
                var filePath = Path.Combine("..", "Bloger.Repository", "DataSeed", "Comments.json");
                var commentsData = await File.ReadAllTextAsync(filePath);
                var comments = JsonSerializer.Deserialize<List<Comment>>(commentsData);

                if (comments?.Count > 0)
                {
                    await blogDbContext.Comments.AddRangeAsync(comments);
                    await blogDbContext.SaveChangesAsync();
                }
            }
        }

        private static async Task SeedTagsAsync(BlogDbContext blogDbContext)
        {
            if (!blogDbContext.Tags.Any())
            {
                var filePath = Path.Combine("..", "Bloger.Repository", "DataSeed", "Tags.json");
                var tagsData = await File.ReadAllTextAsync(filePath);
                var tags = JsonSerializer.Deserialize<List<Tag>>(tagsData);

                if (tags?.Count > 0)
                {
                    await blogDbContext.Tags.AddRangeAsync(tags);
                    await blogDbContext.SaveChangesAsync();
                }
            }
        }

        private static async Task SeedPostTagsAsync(BlogDbContext blogDbContext)
        {
            if (!blogDbContext.PostTags.Any())
            {
                var filePath = Path.Combine("..", "Bloger.Repository", "DataSeed", "PostTags.json");
                var postTagsData = await File.ReadAllTextAsync(filePath);
                var postTags = JsonSerializer.Deserialize<List<PostTag>>(postTagsData);

                if (postTags?.Count > 0)
                {
                    await blogDbContext.PostTags.AddRangeAsync(postTags);
                    await blogDbContext.SaveChangesAsync();
                }
            }
        }

        private static async Task SeedPostReactionsAsync(BlogDbContext blogDbContext)
        {
            if (!blogDbContext.PostReactions.Any())
            {
                var filePath = Path.Combine("..", "Bloger.Repository", "DataSeed", "PostReactions.json");
                var postReactionsData = await File.ReadAllTextAsync(filePath);
                var postReactions = JsonSerializer.Deserialize<List<PostReaction>>(postReactionsData);

                if (postReactions?.Count > 0)
                {
                    await blogDbContext.PostReactions.AddRangeAsync(postReactions);
                    await blogDbContext.SaveChangesAsync();
                }
            }
        }
    }
}
