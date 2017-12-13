using System;

namespace TestingProgramBusinessLogic
{
    public class TestingEventArgs : EventArgs
    {
        public TestingEventArgs(TestStatus status, string message)
        {
            this.TestStatus = status;
            this.Message = message;
        }

        public TestStatus TestStatus { get; private set; }
        public string Message { get; private set; }
    }
}
