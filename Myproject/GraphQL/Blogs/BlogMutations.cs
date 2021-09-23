using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;
using Myproject.Data;
using Myproject.Extensions;
using Myproject.Models;

namespace Myproject.GraphQL.Blogs
{
    [ExtendObjectType(name: "Mutation")]
    public class BlogMutations
    {
        [UseAppDbContext]
        public async Task<Blog> AddBlogAsync(AddBlogInput input,
        [ScopedService] AppDbContext context, CancellationToken cancellationToken)
        {
            var blog = new Blog
            {
                Name = input.Name,
                Author = input.Author,
                ImageUrl = input.ImageUrl,
                Address = input.Address,
                Description = input.Description,
                Positive = 0,
                Negative = 0
            };

            context.Blogs.Add(blog);
            await context.SaveChangesAsync(cancellationToken);

            return blog;
        }

        [UseAppDbContext]
        public async Task<Blog> EditBlogAsync(EditBlogInput input,
        [ScopedService] AppDbContext context, CancellationToken cancellationToken)
        {
            var blog = context.Blogs.SingleOrDefault(b => b.BlogId == input.BlogId);
            if (blog != null)
            {
                blog.Positive += input.Positive;
                blog.Negative -= input.Negative;
                await context.SaveChangesAsync(cancellationToken);
            }


            return blog;
        }

    }
}