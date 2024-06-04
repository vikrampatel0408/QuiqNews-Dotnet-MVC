using PagedList.Core;
using QuiqNews.Data.Models;

namespace QuiqNews.Models.HomeViewModels {
    public class IndexViewModel {
        public IPagedList<Post> Posts { get; set; }
        public string SearchString { get; set; }
        public int PageNumber { get; set; }
    }
}