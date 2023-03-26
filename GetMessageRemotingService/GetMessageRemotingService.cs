using System;

namespace GetMessageRemotingService
{
    public class GetMessageRemotingService : MarshalByRefObject, IGetMessageRemotingService.IGetMessageRemotingService
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }
    }
}