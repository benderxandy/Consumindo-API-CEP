using System.Text.Json.Serialization;
using Newtonsoft.Json;

internal class CEPServices {
    public async Task<CEP> Integracao(string id) {
        HttpClient httpClient = new HttpClient();
        var response = await httpClient.GetAsync($"https://viacep.com.br/ws/{id}/json/");
        var jsonString = await response.Content.ReadAsStringAsync();

        var jsonObject = JsonConvert.DeserializeObject<CEP>(jsonString);
        
        if (jsonObject != null && !string.IsNullOrEmpty(jsonObject.cep)) {
            return jsonObject;
        }
        else {
            return new CEP {
                Verificacao = true
            };
        }
    }
}