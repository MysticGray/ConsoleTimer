using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTimer
{
    public class MultiChoiceMenuBase : IMultiChoiceMenuBase
    {
        protected static string[] _options;
        protected int _selectedIndex;
        protected string _menuTitle;
        public MultiChoiceMenuBase(string[] o, string t)
        {
            _menuTitle = t;
            _selectedIndex = 0;
            _options = o;
        }
        public virtual void Run()
        {

        }
    }
}
