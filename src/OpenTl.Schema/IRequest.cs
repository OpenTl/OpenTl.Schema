
namespace OpenTl.Schema
{
    public interface IRequest : IObject
    {
    }

    public interface IRequest<TResult> : IRequest 
    {
    }
}