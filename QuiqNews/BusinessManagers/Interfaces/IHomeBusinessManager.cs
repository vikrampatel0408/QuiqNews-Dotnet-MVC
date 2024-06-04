using Microsoft.AspNetCore.Mvc;
using QuiqNews.Models.HomeViewModels;

namespace QuiqNews.BusinessManagers.Interfaces {
    public interface IHomeBusinessManager {
        ActionResult<AuthorViewModel> GetAuthorViewModel(string authorId, string searchString, int? page);
    }
}