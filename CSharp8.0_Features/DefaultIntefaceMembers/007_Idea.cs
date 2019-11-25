using System;

namespace DefaultIntefaceMembers._007_Idea
{
    public interface ISample
    {
        public event Action<int> ActivityChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        public int this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int MyProperty
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void Foo(string message)
        {
            throw new NotImplementedException();
        }
    }
}
