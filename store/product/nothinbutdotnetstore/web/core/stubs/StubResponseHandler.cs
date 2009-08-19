using System;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubResponseHandler : ResponseHandler
    {
        public void Write<T>(ViewModel<T> model)
        {
            throw new NotImplementedException();
        }
    }
}