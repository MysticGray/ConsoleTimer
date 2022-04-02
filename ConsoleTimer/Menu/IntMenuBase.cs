namespace ConsoleTimer
{
    internal class IntMenuBase : IIntMenuBase
    {
        protected int _integerResponse;
        protected string _title;
        protected string _getIntegerPrompt;
        public IntMenuBase(string title, string integerPrompt)
        {
            _title = title;
            _getIntegerPrompt = integerPrompt;
            _integerResponse = 0;
        }

        public int GetIntegerResponse()
        {
            return _integerResponse;
        }

        public virtual void Run()
        {

        }
    }
}