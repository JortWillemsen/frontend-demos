using BlazorMud.Core;
using DotnetCute.Exceptions.Http.Client;
using Flurl.Http;

namespace BlazorMud.Agents;

public class PostAgent : IPostAgent
{
    private static readonly string ApiPath = "http://localhost:5125/api";
    public async Task<Post> CreatePost(Post post)
    {
        var response = await $"{ApiPath}/post".PostJsonAsync(post);

        var result = response.GetJsonAsync<Post>().Result;
        
        if (result == null)
            throw new NotFoundException(nameof(result));
        
        return result;
    }

    public async Task<ICollection<Post>> GetAllPosts()
    {
        var response = await $"{ApiPath}/post".GetJsonAsync<ICollection<Post>>();

        if (response == null)
            throw new NotFoundException(nameof(response));

        return response;
    }
}