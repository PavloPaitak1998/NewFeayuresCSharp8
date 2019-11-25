namespace DefaultIntefaceMembers
{
    interface A
    {
        void m();
    }

    interface B : A
    {
        void A.m() { System.Console.WriteLine("interface B"); }
    }

    interface C : A
    {
        void A.m() { System.Console.WriteLine("interface C"); }
    }

    class D : B, C
    {
        static void Main()
        {
            C c = new D();
            c.m();
        }
    }

    //class D : B, C
    //{
    //    // Now the compiler will use the most specific override, which is defined in the class ‘D’
    //    void A.m()
    //    {
    //        System.Console.WriteLine("I am in class D");
    //    }

    //    static void Main()
    //    {
    //        A a = new D();
    //        a.m();
    //    }
    //}
}
