using factory.business;
using Factory.Business;

namespace Factory.Interface
{
    public interface IInvoke
    {
        Task<string> Invoke(DTO dto);
    }
}