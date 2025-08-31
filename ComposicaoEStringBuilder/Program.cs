using ComposicaoEStringBuilder.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment comment1Post1 = new Comment("Have a nice trip");
            Comment comment2Post1 = new Comment("Wow that's awesome!");
            Post post1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Travelling to New Zealand", "I'm going to visit this wonderful country", 12);
            post1.AddComment(comment1Post1);
            post1.AddComment(comment2Post1);

            Comment comment1Post2 = new Comment("Good night");
            Comment comment2Post2 = new Comment("May the Force be with you");
            Post post2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5);
            post2.AddComment(comment1Post2);
            post2.AddComment(comment2Post2);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}