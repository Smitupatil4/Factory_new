using Admin;
using Dashboard;
using Factory.Business;
using Factory.Interface;
using User;

namespace Factory.API
{
    public class factory1
    {
        private readonly IServiceProvider serviceProvider;
        public factory1 (IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public IInvoke GetModuleService(int value)
        {
            switch (value)
            {
                
                case (int)ModuleTypes.Admin://33
                    return (IInvoke)serviceProvider.GetService(typeof(AdminManager));
                
                case (int)ModuleTypes.User://33
                    return (IInvoke)serviceProvider.GetService(typeof(UserManager));
                    
                case (int)ModuleTypes.Dashboard://33
                    return (IInvoke)serviceProvider.GetService(typeof(DashboardManager));
            }
              return null;
        }   
    }
}  