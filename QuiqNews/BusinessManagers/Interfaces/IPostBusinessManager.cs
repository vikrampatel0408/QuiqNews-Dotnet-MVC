using Microsoft.AspNetCore.Mvc;
using QuiqNews.Data.Models;
using QuiqNews.Models.HomeViewModels;
using QuiqNews.Models.PostViewModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QuiqNews.BusinessManagers.Interfaces {
    public interface IPostBusinessManager {
        IndexViewModel GetIndexViewModel(string searchString, int? page);
        Task<ActionResult<PostViewModel>> GetPostViewModel(int? id, ClaimsPrincipal claimsPrincipal);
        Task<Post> CreatePost(CreateViewModel createViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<Comment>> CreateComment(PostViewModel postViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> UpdatePost(EditViewModel editViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> GetEditViewModel(int? id, ClaimsPrincipal claimsPrincipal);
    }
}