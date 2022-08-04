using FunWithPosts;
using FunWithPosts.Model;

const int FROM_NUMBER = 4;
const int TO_NUMBER = 13;
const string STRING_URI = $"https://jsonplaceholder.typicode.com/posts";

PostsController controller = new PostsController(FROM_NUMBER, TO_NUMBER, STRING_URI);

IEnumerable<Post> posts = await controller.GetPostsAsync();

foreach (var post in posts)
{
    Console.WriteLine(post.ToString());
}

FileOperations.WriteToFile(posts);

Console.ReadKey(true);

