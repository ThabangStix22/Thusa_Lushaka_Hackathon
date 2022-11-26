using Microsoft.AspNetCore.Identity;

namespace WebAPI.Interface
{
    public interface IAction
    {
        public int Login(string strEmail, string strPassword);
    }
}
