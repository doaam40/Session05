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
            //Console.WriteLine(book.copiesInStock);
            //it compiles because internal access modifier is accessable in the same assembly (project)
            #endregion

            #region Q3
            //book.title = "Clean Code";
            //Console.WriteLine(book.title);
            #endregion

            #region Q4
            //Console.WriteLine(book.Genre);
            #endregion

            #region Q5
            //Console.WriteLine((Genre)0);
            //Console.WriteLine((Genre)1);
            //Console.WriteLine((Genre)2);
            #endregion

            #region Q6
            //int genreNumber = 1;
            //Console.WriteLine((Genre)genreNumber);
            #endregion

            #region Q7
            //Genre genre = Genre.Fiction;
            //Console.WriteLine(genre.ToString());
            #endregion

            #region Q8
            Genre genre;
            string genreText = "Science";
            bool flag = Enum.TryParse(genreText, out genre);
            if(flag)
                Console.WriteLine(genre);
            #endregion
        }
    }
}
