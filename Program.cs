using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var BlogManager = new BlogManager();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("WELCOME TO SOFTWORKS BLOG MANAGER, WHAT WOULD YOU LIKE TO DO?");
                Console.WriteLine();
                Console.WriteLine("1: Display all Blogs");
                Console.WriteLine("2: Display all Post");
                Console.WriteLine("3: Create new Blog");
                Console.WriteLine("4: Create new post");
                Console.WriteLine("5: Delete a post");
                Console.WriteLine("6: Manage blog");
                Console.WriteLine("7: Exit");
                Console.WriteLine();

                Console.Write("Enter your choice");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BlogManager.DisplayAllBlog(); break;
                    case "2":
                        BlogManager.DisplayAllPost(); break;
                    case "3":
                        BlogManager.CreateNewBlog(); break;
                    case "4":
                        BlogManager.CreateNewPost(); break;
                    case "5":
                        BlogManager.DeletePost(); break;
                    case "6":
                        BlogManager.ManageBlog(); break;
                    case "7":
                        Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Invalid Command,Please try again "); break;
                }
            }
        }
    }
}
