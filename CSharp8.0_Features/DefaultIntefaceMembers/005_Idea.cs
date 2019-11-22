using System;

namespace DefaultIntefaceMembers
{
    public interface ISample
    {
        event Action<int> ActivityChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        public int this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        int MyProperty
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        void Foo(string message)
        {
            throw new NotImplementedException();
        }
    }
}
