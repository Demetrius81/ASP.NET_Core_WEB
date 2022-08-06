using FunWithPosts.Model;
using System.Text;

namespace FunWithPosts
{
    /// <summary>
    /// Класс для работы с файлом
    /// </summary>
    internal static class FileOperations
    {
        /// <summary>
        /// Метод записывает коллекцию постов в файл
        /// </summary>
        public static void WriteToFile(IEnumerable<Post> posts)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Post post in posts)
            {
                sb.Append(post.ToString());
                sb.Append("\n");
            }
                        
            using (StreamWriter sw = new StreamWriter("posts.txt", false))
            {
                sw.WriteLine(sb.ToString());
            }
            
        }
    }
}
