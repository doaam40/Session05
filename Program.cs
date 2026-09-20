namespace Session05_AssignmentC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Book book = new Book();
            //Console.WriteLine(book.Password);
            //it makes error because private access modifier is accessable inside the same class only
            #endregion

            #region Q2
            Console.WriteLine(book.copiesInStock);
            //it compiles because internal access modifier is accessable in the same assembly (project)
            #endregion
        }
    }
}
