using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using Myproject.Data;
using Myproject.Extensions;
using Myproject.Models;

namespace Myproject.GraphQL.Blogs
{
    [ExtendObjectType(name: "Query")]
    public class BlogQueries
    {
        [UseAppDbContext]
        [UsePaging]
        public IQueryable<Blog> GetBlogs([ScopedService] AppDbContext context)
        {
            return context.Blogs;
        }

        [UseAppDbContext]
        public Blog GetBlog(int id, [ScopedService] AppDbContext context)
        {
            return context.Blogs.Find(id);
        }
    }
}
