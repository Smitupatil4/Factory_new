using factory.business;
using Factory.Interface;

namespace User;
public class UserManager : IInvoke
{
    public Task<string> Invoke(DTO dto)
    {
        string result = string.Empty;
            switch (dto.RequestType)
            {

                case 11:
                    result="User_1";
                    break;
                case 12:
                    result="User_2";
                    break;

            }
            return Task.FromResult(result);
    }
}
