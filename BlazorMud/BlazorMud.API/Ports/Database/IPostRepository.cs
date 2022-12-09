using BlazorMud.Core;

namespace BlazorMud.API.Ports.Database;

public interface IPostRepository
{
    Post CreatePost(Post post);
    Post FindPostById(Guid id);
    ICollection<Post> FindAllPosts();
}