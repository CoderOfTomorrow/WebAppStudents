namespace WebAppForNoobs.Common
{
    public class Author
    {
        public Author(int id, string name)
        {
            Id = id;
            Name = name;
            Biography = new Biography(Id);
            Books = [];
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public Biography Biography { get; private set; }
        public List<Book> Books { get; private set; }

        public void ModifyBiography(string newBiography)
        {
            Biography.Details = newBiography;
        }
    }
}