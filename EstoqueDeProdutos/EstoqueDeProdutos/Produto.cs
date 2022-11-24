using System;
using System.Globalization;

namespace EstoqueDeProduto;

class Produto {
    private string _nome;
    private string _descricao;
    private double _preco;
    private int _quantidade;

    public Produto(string nome, string descricao, int quantidade, double preco) {
        this._nome = nome;
        this._descricao = descricao;
        this._preco = preco;
        this._quantidade = quantidade;
    }
    public void SetNome(string nome) {
        if (nome != null && nome.Length > 1) {
            this._nome = nome;
        }
    }
    public string GetNome() {
        return this._nome;
    }
    public string GetDescricao() { 
        return this._descricao; 
    }
    public void SetDescricao(string descricao) {
        if (descricao != null && descricao.Length > 2) {
            this._descricao = descricao;
        }
    }
    public void SetQuantidade(int quantidade) {
        if(quantidade >= 0) { 
        this._quantidade = quantidade;
        }
    }
    public int GetQuantidade() {
        return this._quantidade; 
    }
    public double GetPreco() {
        return this._preco;
    }

    public void AddProduct(int quantidade) {
        this._quantidade += quantidade;
    }
    public void RemoveProduct(int quantidade) {
        this._quantidade -= quantidade;
    }
    public string ToString() {
        double total = _preco * _quantidade;
        return " Nome: " + _nome +
            "\n Descricao: " + _descricao +
            "\n Quantidade: " + _quantidade +
            "\n Preco R$ " + _preco.ToString("F2",CultureInfo.InvariantCulture)+
            "\n Total em estoque: " + total+ "\n";        
    }
}
