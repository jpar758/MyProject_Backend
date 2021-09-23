using System.Reflection;
using Myproject.Data;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;

namespace Myproject.Extensions
{
    public class UseAppDbContextAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(
            IDescriptorContext context,
            IObjectFieldDescriptor descriptor,
            MemberInfo member)
        {
            descriptor.UseDbContext<AppDbContext>();
        }
    }
}