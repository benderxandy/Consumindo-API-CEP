internal class CEP {
    public string cep { get; set; }
    public string logradouro { get; set; }        
    public string bairro { get; set; }
    public string localidade { get; set; }
    public string uf { get; set; }
    public int ddd { get; set; }
    public bool Verificacao = false;
}