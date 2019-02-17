using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseDocumentati
{
    class Program
    {
        /// <summary> 
        /// The GetZero method. Always returns zero.
        /// </summary> 
        /// <example>  
        /// This sample shows how to call the <see cref="GetZero"/> method.
        /// <code> 
        /// class TestClass  
        /// { 
        ///     static int Main()  
        ///     { 
        ///         return GetZero(); 
        ///     } 
        /// } 
        /// </code> 
        /// </example>
        /// <returns>Always returns zero</returns>
        
        public static int GetZero()
        {
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetZero());
            int Zero = GetZero();

            
        }
    }
}
