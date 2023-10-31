// METODY HERMETYZACJA (2023.11.01)
// Chcemy całą historię punktów przechowywać wewnątrz
//


User user1 = new User("Adam", "123");
User user2 = new User("Zula", "123");
User user3 = new User("Pola", "123");
User user4 = new User("Olek", "123");

user1.AddScore(5);

class User
{
    private List<int> score = new List<int>();  

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }
    public string Login { get; private set; }
    public string Password { get; private set; }

    public void AddScore(int number)
    {
        this.score.Add(number);
    }



}