namespace ClassLibraryHelloUser
{
    public interface IHelloUser
    {
        string Greetings { get; }

        void Init(string userName, string userEmail);
    }
}
