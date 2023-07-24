using Enumeration;

public class Program
{
    public static void Main(string[] args)
    {
        List<User> userList = new List<User>
        {
            new User("Doe", "John", Color.ROUGE),
            new User("Landt", "May", Color.JAUNE),
            new User("Madrickson", "Maurice", Color.ROUGE),
            new User("Yonos", "Jack", Color.VERT),
            new User("Parker", "Tony", Color.VERT),
            new User("Dolodo", "Lucie", Color.BLEU),
            new User("Antack", "Fulis", Color.VERT)
        };

        foreach(User user in userList)
        {
            Console.WriteLine("Prénom : " + user.Prenom);
            Console.WriteLine("Nom : " + user.Nom);
            Console.WriteLine("Couleur : " + user.Couleur);
        }

        int countRouge = userList.FindAll(u => u.Couleur == Color.ROUGE).Count();
        int countVert = userList.FindAll(u => u.Couleur == Color.VERT).Count();
        int countJaune = userList.FindAll(u => u.Couleur == Color.JAUNE).Count();
        int countBleu = userList.FindAll(u => u.Couleur == Color.BLEU).Count();

        Console.WriteLine("ROUGE : " + countRouge + " Utilisateurs");
        Console.WriteLine("VERT : " + countVert + " Utilisateurs");
        Console.WriteLine("JAUNE : " + countJaune + " Utilisateurs");
        Console.WriteLine("BLEU : " + countBleu + " Utilisateurs");
    }
}