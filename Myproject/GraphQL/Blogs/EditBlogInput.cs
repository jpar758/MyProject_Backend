namespace Myproject.GraphQL.Blogs
{
    public record AddBlogInput(

        string Name,
        string Author,
        string ImageUrl,
        string Address,
        string Description);
}

