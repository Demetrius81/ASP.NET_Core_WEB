using FunWithPosts.Model;
using Newtonsoft.Json;

namespace FunWithPosts
{
    /// <summary>
    /// Класс контроллера постов
    /// </summary>
    internal class PostsController
    {
        private readonly int _fromNumber;
        private readonly int _toNumber;
        private readonly string _stringUri;
        private static readonly HttpClient httpClient = new();

        public PostsController(int fromNumber, int toNumber, string stringUri)
        {
            _fromNumber = fromNumber;
            _toNumber = toNumber;
            _stringUri = stringUri;
        }

        /// <summary>
        /// Метод возвращает коллекцию постов
        /// </summary>
        /// <returns></returns>
        internal async Task<IEnumerable<Post>> GetPostsAsync()
        {
            List<Post> posts = new();

            List<Task<Post>> tasks = new();

            for (int i = _fromNumber; i <= _toNumber; i++)
            {
                tasks.Add(GetPostAsync(i));
            }

            await Task.WhenAll(tasks);

            tasks.ForEach(async t =>
            {
                var p = await t;

                posts.Add(p);
            });

            return posts;
        }

        /// <summary>
        /// Метод получает пост по идентификатору
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private async Task<Post> GetPostAsync(int i)
        {
            var currentStringUri = $"{_stringUri}/{i}";

            Uri responseUri = new Uri(currentStringUri);

            HttpResponseMessage response = await httpClient.GetAsync(responseUri);

            if (!response.IsSuccessStatusCode)
            {
                return default;
            }

            string content = await response.Content.ReadAsStringAsync();

            var post = JsonConvert.DeserializeObject<Post>(content);

            return post;
        }
    }
}
