using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_App.Helpers.Commands
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
