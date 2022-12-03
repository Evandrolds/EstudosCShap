



using ExempleCommnets;
using Posts;

namespace ExemplosStringBuilder;

  class Program
{
    public static void Main(string[] args) {

        Post pt = new Post("Viajando pata o Canadá!", DateTime.Parse("22/12/2022"), " Estou indo a trabalho!", 352);
        Comments c1 = new Comments("Que legallll, espero que dudo corra bem! sucessoooooo!");
        Comments c2 = new Comments("Uhuuuu, torço muito por você! sucessoooooo!");
        pt.AddComent(c1);
        pt.AddComent(c2);
        Console.WriteLine(pt);
    }
}