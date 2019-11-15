using System;

// #nullable enable                    // Sets the nullable annotation context and nullable warning context to enabled.
// #nullable disable                   // Sets the nullable annotation context and nullable warning context to disabled.
// #nullable restore                   // Restores the nullable annotation context and nullable warning context to the project settings.
// #nullable disable warnings          // Set the nullable warning context to disabled.
// #nullable enable warnings           // Set the nullable warning context to enabled.
// #nullable restore warnings          // Restores the nullable warning context to the project settings.
// #nullable disable annotations       // Set the nullable annotation context to disabled.
// #nullable enable annotations        // Set the nullable annotation context to enabled.
// #nullable restore annotations       // Restores the annotation warning context to the project settings.
namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = Type.GetType("abracadabra");
            Console.WriteLine(t.Assembly.FullName);

            #region examples
            //Test_Not_NullableRefType(null);
            //Test_NullableRefType(null);
            //Test_NullableRefType_With_Null_Forgiving_Operator(null);
            #endregion
        }


        static void Test_Not_NullableRefType(string p)
        {
            Console.WriteLine("The Length is - {0}.", p.Length);
        }

        static void Test_NullableRefType(string? p)
        {
            Console.WriteLine("The Length is - {0}.", p?.Length);
        }

        static void Test_NullableRefType_With_Null_Forgiving_Operator(string? p)
        {
            Console.WriteLine("The Length is - {0}.", p!.Length);
        }

    }
}
