using Microsoft.AspNetCore.Http;
using QuiqNews.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace QuiqNews.Models.PostViewModels {
    public class EditViewModel {
        [Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }
        public Post Post { get; set; }
    }
}