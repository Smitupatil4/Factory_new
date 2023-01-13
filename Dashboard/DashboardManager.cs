using Factory.Interface;
using Factory.Business;
using factory.business;

namespace Dashboard;
public class DashboardManager:IInvoke
{
       public  Task<string> Invoke(DTO dto)
        {
            string result = string.Empty;
            switch (dto.RequestType)
            {
                case 11:
                    result="Dash_1";
                    break;
                case 12:
                    result="Dash_2";
                    break;

            }
            return Task.FromResult(result);
        }

}
