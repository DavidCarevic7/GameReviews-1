using System;
using EfDataAccess;
using Domain;

namespace Console
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            var context = new GamesContext();

            //uloge
            context.Roles.Add(new Role {
                  IsDeleted=false,
                  RoleName="Admin",
                  ModifiedOn=null
                  
            });
            context.Roles.Add(new Role
            {
                IsDeleted = false,
                RoleName = "Journalist",
                ModifiedOn = null,
               
            });
            context.Roles.Add(new Role
            {
                IsDeleted = false,
                RoleName = "User",
                ModifiedOn = null
            });

            context.SaveChanges();

            //tagovi 

            context.Tags.Add(new Tag { 
                IsDeleted= false,
                Name = "Tag1",
                ModifiedOn = null
            });
            context.Tags.Add(new Tag
            {
                IsDeleted = false,
                Name = "Tag2",
                ModifiedOn = null

            });
            context.Tags.Add(new Tag
            {
                IsDeleted = false,
                Name = "Tag3",
                ModifiedOn = null
            });


            //useri

            context.Users.Add(new User
            {
                Email = "david.carevic.159.14@ict.edu.rs",
                Password = "david",
                FirstName = "David",
                LastName = "Carevic",
                ModifiedOn = null,
                IsDeleted = false,
                RoleId = 1
                

            });
            context.Users.Add(new User
            {
                Email = "killsword78@gmail.com,",
                Password = "david",
                FirstName = "David",
                LastName = "Carevic",
                ModifiedOn = null,
                IsDeleted = false,
                RoleId = 2

            });

            context.Users.Add(new User
            {
                Email = "davidcarevic.biz",
                Password = "david",
                FirstName = "David",
                LastName = "Carevic",
                ModifiedOn = null,
                IsDeleted = false,
                RoleId = 3

            });

            context.SaveChanges();
            //postovi i slike

            context.PostImages.Add(new PostImage
            {
                ImageName="slika.jpg",
                IsDeleted=false,
                ModifiedOn=null

            });
            context.PostImages.Add(new PostImage
            {
                ImageName = "slika2.jpg",
                IsDeleted = false,
                ModifiedOn = null

            });
            context.PostImages.Add(new PostImage
            {
                ImageName = "slika3.jpg",
                IsDeleted = false,
                ModifiedOn = null

            });

            context.SaveChanges();

            context.Posts.Add(new Post {
                ModifiedOn=null,
                IsDeleted=false,
                Title="Title",
                Description="asdkjaskjdjasdklasjdklasdklasdjasdj",
                PostImageId=1,
                Rating=4,
                UserId=2
                
            });
            context.Posts.Add(new Post
            {
                ModifiedOn = null,
                IsDeleted = false,
                Title = "Title",
                Description = "asdkjaskjdjasdklasjdklasdklasdjasdj",
                PostImageId = 2,
                Rating = 4,
                UserId = 2

            });
            context.Posts.Add(new Post
            {
                ModifiedOn = null,
                IsDeleted = false,
                Title = "Title",
                Description = "asdkjaskjdjasdklasjdklasdklasdjasdj",
                PostImageId = 3,
                Rating = 4,
                UserId = 2

            });
            context.SaveChanges();
            //komentari

            context.Commnets.Add(new Comment {

                IsDeleted=false,
                ModifiedOn=null,
                Text="Komentar komentar",
                UserId=1,
                PostId=1
            });
            context.Commnets.Add(new Comment
            {

                IsDeleted = false,
                ModifiedOn = null,
                Text = "Komentar komentar",
                UserId = 1,
                PostId = 1
            });
            context.Commnets.Add(new Comment
            {

                IsDeleted = false,
                ModifiedOn = null,
                Text = "Komentar komentar",
                UserId = 1,
                PostId = 1
            });

            context.Commnets.Add(new Comment
            {

                IsDeleted = false,
                ModifiedOn = null,
                Text = "Komentar komentar",
                UserId = 1,
                PostId = 2
            });

            context.Commnets.Add(new Comment
            {

                IsDeleted = false,
                ModifiedOn = null,
                Text = "Komentar komentar",
                UserId = 1,
                PostId = 2
            });

            context.SaveChanges();

            //post-tag
            context.PostTags.Add(new PostTag { 
                IsDeleted = false,
                ModifiedOn = null,
                PostId = 1,
                TagId = 1
            });

            context.PostTags.Add(new PostTag
            {
                IsDeleted = false,
                ModifiedOn = null,
                PostId = 1,
                TagId = 2
            });

            context.PostTags.Add(new PostTag
            {
                IsDeleted = false,
                ModifiedOn = null,
                PostId = 1,
                TagId = 3
            });

            context.PostTags.Add(new PostTag
            {
                IsDeleted = false,
                ModifiedOn = null,
                PostId = 2,
                TagId = 1
            });

            context.PostTags.Add(new PostTag
            {
                IsDeleted = false,
                ModifiedOn = null,
                PostId = 2,
                TagId = 2
            });

            context.SaveChanges();






        }

    }
}