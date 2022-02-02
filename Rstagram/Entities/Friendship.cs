namespace Rstagram.Entities
{
    public class Friendship
    {
        public int TargetUserId { get; set; }
        public int DestinationUserId { get; set; }
        public int Status { get; set; }
    }
}
