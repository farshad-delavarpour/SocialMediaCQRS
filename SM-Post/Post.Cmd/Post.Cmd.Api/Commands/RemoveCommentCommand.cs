using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class RemoveCommentCommand : BaseCommand
    {
        public Guid CommandId { get; set; }
        public string Username { get; set; } = string.Empty;
    }
}