using System;
namespace calculator_api.Services
{
    public abstract class BaseService
    {
        protected readonly LogService logService;

        public BaseService()
        {
            logService = new LogService();
        }
    }
}
