using Microsoft.AspNetCore.Mvc;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;

namespace MusicShopApplication.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult AddComment(int id)
        {
            return View(new Comment()
            {
                UserName = User.Identity.Name,
                ProductId = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            comment.Id = 0;
            DataBaseResponse<Comment> response = await _commentService.Add(comment);
            if (response.Status == MusicShop.Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("Product", "Products", new { id = comment.ProductId });
            }
            return Redirect("Error");
        }
    }
}
