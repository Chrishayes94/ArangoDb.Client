using System.Threading;
using System.Threading.Tasks;

namespace ArangoDb.Client.Http.Interfaces
{
    public interface IClientHandler
    {
        Task<TResponse> PostAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default)
            where TRequest : BaseRequest where TResponse : class, IBaseResponse;

        Task<TResponse> GetAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default)
            where TRequest : BaseRequest where TResponse : class, IBaseResponse;

        Task<TResponse> DeleteAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default)
            where TRequest : BaseRequest where TResponse : class, IBaseResponse;
    }
}