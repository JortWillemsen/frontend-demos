using BlazorMud.Core;

namespace BlazorMud.Agents;

public interface IPostAgent
{
    Task<Post> CreatePost(Post post);
    Task<ICollection<Post>> GetAllPosts();
}