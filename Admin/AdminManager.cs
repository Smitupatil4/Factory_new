using factory.business;
using Factory.Business;
using Factory.Interface;

namespace Admin
{
    public class AdminManager : IInvoke
    {
           public  Task<string> Invoke(DTO dto)
        {
            string result = string.Empty;
            switch (dto.RequestType)
            {
                case 12:
                    result="Admin_1";
                    break;
                case 13:
                    result="Admin_2";
                    break;

            }
            return Task.FromResult(result);
        }
    }
}
