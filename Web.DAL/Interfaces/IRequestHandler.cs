
namespace Web.DAL.Interfaces
{
    public interface IRequestHandler
    {
        void Post<T>(string operationPath, T postContent);
    }
}
