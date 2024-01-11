using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ConsoleApp
{
    class blog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public string Desc { get; set; }   
    }

    public class BlogManager
    {
        private List<blog> blogs = new List<blog>(); //hold all blogs
        private List<post> posts = new List<post>(); // hold all posts

        public void DisplayAllBlog() 
        {
            if (blogs.Count == 0)
            {
                Console.WriteLine("No blogs found" );
            }
            else
            {
                Console.WriteLine("All Blogs: ");
                foreach (var blog in blogs)
                {
                    Console.WriteLine($"Id: {blog.ID}, Title: {blog.Name}, Description: {blog.Desc}");
                }
            }
        }

        public void DisplayAllPost()
        {
            if (posts.Count == 0)
            {
                Console.WriteLine("No posts found");
            }
            else
            {
                Console.WriteLine("All posts: ");
                foreach (var post in posts)
                {
                    Console.WriteLine($"Id: {post.ID}, Blog ID: {post.BlogID}, Post Date: {post.Date}, Post Title: {post.Title}, Content: {post.Content}");
                }
            }
        }

        public void CreateNewBlog()
        {
            int id = blogs.Count + 1; //auto increment blog id

            Console.WriteLine("Enter Title of blog: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter blog description: ");
            string desc = Console.ReadLine();

            var blog = new blog { ID = id, Name = title, Desc = desc };
            blogs.Add(blog);

            Console.WriteLine("Blog created Successfully");
        }

        public void CreateNewPost()
        {
            int id = posts.Count + 1; //auto increment post id

            Console.WriteLine("Enter the BlogId the post belongs to");
            int BlogId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Title of post: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter post Content: ");
            string content = Console.ReadLine();

            Console.WriteLine("Enter Date of post (yyyy-mm-dd) " );
            string date = Console.ReadLine();

            var post = new post { ID = id, BlogID = BlogId, Date = date, Title = title, Content = content };
            posts.Add(post);

            Console.WriteLine("Post created Successfully");
        }

        public void ManageBlog()
        {
            Console.WriteLine("Enter ID of Blog to Manage" );
            int BlogId = Convert.ToInt32(Console.ReadLine());

            blog blog = blogs.Find(b => b.ID == BlogId);
            if (blog == null)
            {
                Console.WriteLine("Blog not Found  ");
            }
            else
            {
                // Manage Blog
                Console.WriteLine("What do you want to do on Blog" + BlogId);
                Console.WriteLine($"Id: {blog.ID}, Title: {blog.Name}, Description: {blog.Desc}");
                Console.WriteLine();

                Console.WriteLine("Select Action:" );
                Console.WriteLine("1: Update Title" );
                Console.WriteLine("2: Update Description");
                Console.WriteLine("3: Delete Blog");
                Console.WriteLine( );

                Console.WriteLine("ENter your choice");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter new Title: "  );
                        string newTitle = Console.ReadLine();
                        blog.Name = newTitle;
                        Console.WriteLine("BLog Title Updated Successfully" );
                        break;
                    case "2":
                        Console.WriteLine("Enter new Description: ");
                        string newDesc = Console.ReadLine();
                        blog.Desc = newDesc;
                        Console.WriteLine("BLog Title Updated Successfully");
                        break;
                    case "3":
                        // Blog delete confirmation
                        Console.WriteLine($"Are you sure you want to delete Blog {blog.Name}");
                        Console.WriteLine("tye 'DELETE' to confirm");
                        string finalchoice = Console.ReadLine();
                        if (finalchoice == "DELETE")
                        {
                            blogs.Remove(blog);
                            Console.WriteLine("Blog deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Blog deletion Cancelled");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                 
            }
        }

        public void DeletePost()
        {
            Console.WriteLine("Select the Id of the post to delete");
            int postId = Convert.ToInt32(Console.ReadLine());

            post post = posts.Find(p => p.ID == postId);

            if(post == null)
            {
                Console.WriteLine("Post not foudnd" );
            }
            else
            {
                posts.Remove(post);
                Console.WriteLine("Post Deleted Succcessfully" );
            }
        }

    }
}
