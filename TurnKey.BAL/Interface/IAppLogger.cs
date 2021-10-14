using System;
using System.Collections.Generic;
using System.Text;

namespace TurnKey.BAL.Interface
{
    public interface IAppLogger
    {
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
        void LogError(string message, params object[] args);
    }
}
