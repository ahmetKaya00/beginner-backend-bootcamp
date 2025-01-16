using BlogApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.ViewComponents{

    public class NewPosts : ViewComponent{

        private IPostRepository _PostRepository;
        public NewPosts(IPostRepository PostRepository){
            _PostRepository = PostRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(){
            return View(
                await
                _PostRepository
                .Posts
                .OrderByDescending(p=>p.PublishedOn)
                .Take(5)
                .ToListAsync());
        }
    }
}