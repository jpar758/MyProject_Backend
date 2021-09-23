using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HotChocolate;
using HotChocolate.Types;
using Myproject.Data;
using Myproject.Models;

namespace Myproject.GraphQL.Blogs { 
    public class BlogType : ObjectType<Blog>
    {
        protected override void Configure(IObjectTypeDescriptor<Blog> descriptor)
        {
            descriptor.Field(b => b.BlogId).Type<NonNullType<IdType>>();
            descriptor.Field(b => b.Name).Type<NonNullType<StringType>>();
            descriptor.Field(b => b.Address).Type<NonNullType<StringType>>();
            descriptor.Field(b => b.Description).Type<NonNullType<StringType>>();
            descriptor.Field(b => b.Author).Type<NonNullType<StringType>>();
            descriptor.Field(b => b.Positive).Type<NonNullType<IntType>>();
            descriptor.Field(b => b.Negative).Type<NonNullType<IntType>>();


        }
    }
}