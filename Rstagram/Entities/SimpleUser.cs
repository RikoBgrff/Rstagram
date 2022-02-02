using System.Collections.Generic;

namespace Rstagram.Entities
{
    public class SimpleUser :User
    {
        public List<Post>? Posts { get; set; }

    }
}
