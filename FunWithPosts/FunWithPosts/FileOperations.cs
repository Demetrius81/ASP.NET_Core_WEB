using FunWithPosts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FunWithPosts
{
    internal static class FileOperations
    {
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
