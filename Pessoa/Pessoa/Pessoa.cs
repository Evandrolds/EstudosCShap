namespace dados_de_pessoa;

class Pessoa {

    public Pessoa() { }
    public Pessoa(string nome, int idade) {
        this.nome = nome;
        this.idade = idade;
    }
    private string nome;
    private int idade;

    public string GetNome() {
        return nome;
    }
    public int GetIdade() {
        return idade;
    }
    public void SetNome(String nome) {
        this.nome = nome;
    }
    public void SetIdade(int idade) {
        this.idade = idade;
    }

    public override string? ToString() {
        return "Nome: " + nome + "\nIdade: " + idade;
    }
   
}