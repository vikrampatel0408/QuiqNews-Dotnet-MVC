using QuiqNews.Data.Models;
using System.Collections.Generic;

namespace QuiqNews.Models.AdminViewModels {
    public class IndexViewModel {
        public IEnumerable<Post> Posts { get; set; }
    }
}