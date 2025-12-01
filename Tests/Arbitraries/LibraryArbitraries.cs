using FsCheck;
using FsCheck.Fluent;
using Library_Book_Borrowing_System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Book_Borrowing_System.Tests.Arbitraries
{
    public class LibraryArbitraries
    {

        public static Arbitrary<string> Isbn()
        {
            throw new NotImplementedException();
        }


        private static Gen<string> Title()
        {
            throw new NotImplementedException();

        }


        public static Arbitrary<Book> Book()
        {
            throw new NotImplementedException();

        }


        public static Arbitrary<User> User()
        {
            throw new NotImplementedException();

        }


        public static Arbitrary<LibraryOperation> Operation()
        {
            throw new NotImplementedException();

        }


        public enum OperationType { Borrow, Return }

        public record LibraryOperation(OperationType Type, string Isbn);

    }
}
