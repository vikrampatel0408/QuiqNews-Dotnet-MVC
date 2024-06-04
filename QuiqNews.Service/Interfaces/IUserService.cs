using QuiqNews.Data.Models;
using System.Threading.Tasks;

namespace QuiqNews.Service.Interfaces {
    public interface IUserService {
        ApplicationUser Get(string id);
        Task<ApplicationUser> Update(ApplicationUser applicationUser);
    }
}