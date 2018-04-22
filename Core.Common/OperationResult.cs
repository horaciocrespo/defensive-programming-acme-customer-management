using System.Collections.Generic;

namespace Core.Common
{
    // The purpose of this class is to be used as return value
    // of methods that are validating.
    public class OperationResult
    {
        public bool Success { get; set; }

        public List<string> MessageList { get; private set; }

        public OperationResult()
        {
            MessageList = new List<string>();
            Success = true;
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }
    }
}
