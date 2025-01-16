using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore{

    public static class SeedData{

        public static void TestVerileriniDoldur(IApplicationBuilder app){
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if(context != null){
                if(context.Database.GetPendingMigrations().Any()){
                    context.Database.Migrate();
                }

                if(!context.Tags.Any()){
                    context.Tags.AddRange(
                        new Tag { Text = "web programlama", Url = "web-programlama", Colors = TagColors.primary},
                        new Tag { Text = "backend", Url = "backend", Colors = TagColors.danger},
                        new Tag { Text = "frontend", Url = "fronded", Colors = TagColors.secondary},
                        new Tag { Text = "fullstack", Url = "full-stack", Colors = TagColors.success},
                        new Tag { Text = "unity", Url = "unity", Colors = TagColors.warning}
                    );
                    context.SaveChanges();
                }

                if(!context.Users.Any()){
                    context.Users.AddRange(
                        new User { UserName = "ahmetkaya", Image = "p1.jpg", Name = "Ahmet Kaya", Email="admin@ahmet.com",Password = "123456"},
                        new User { UserName = "alicansarigul", Image = "p2.jpg", Name= "Alican Sarıgül", Email= "alican@sarigul.com", Password = "123456"}
                    );
                    context.SaveChanges();
                }
                if(!context.Posts.Any()){
                    context.Posts.AddRange(
                        new Post {
                            Title = "asp.net Core",
                            Content = "Eğitim başlayacak",
                            IsActive = true,
                            Url = "asp-net-core",
                            Image = "1.png",
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            UserId = 1,
                            Comments = new List<Comment>{
                                new Comment {Text = "başarılı bir içerik", PublishedOn = new DateTime(), UserId = 1},
                                new Comment {Text = "güzel bir içerik", PublishedOn = new DateTime(), UserId = 2}
                            }
                        },
                        new Post {
                            Title = "Unity Game",
                            Content = "Eğitim başlayacak",
                            Url = "unity-game",
                            IsActive = true,
                            Image = "2.png",
                            PublishedOn = DateTime.Now.AddDays(-15),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 1
                        },
                        new Post {
                            Title = "Javascript Eğitimi ",
                            Content = "Eğitim başlayacak",
                            Url = "javascript-egitimi",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-18),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId = 2
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}