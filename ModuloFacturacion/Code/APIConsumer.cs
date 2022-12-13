namespace ModuloFacturacion.Code
{
    public class APIConsumer
    {
        public static Models.FactClient[] Clients(string apiUrl)
        {
            var api = new System.Net.WebClient();
            api.Headers.Add("Content-Type", "application/json");
            var json = api.DownloadString(apiUrl);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Models.FactClient[]>(json);
        }

        public static Models.FactClient Client(string apiUrl, int id)
        {
            var api = new System.Net.WebClient();
            api.Headers.Add("Content-Type", "application/json");
            var json = api.DownloadString(apiUrl + "/" + id);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Models.FactClient>(json);
        }

        public static void GuardarPais(string apiUrl, int id, Models.FactClient client)
        {
            var api = new System.Net.WebClient();
            api.Headers.Add("Content-Type", "application/json");
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(client);
            api.UploadString(apiUrl + "/" + id, "PUT", json);
        }

        public static Models.FactClient CrearPais(string apiUrl, Models.FactClient client)
        {
            var api = new System.Net.WebClient();
            api.Headers.Add("Content-Type", "application/json");
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(client);
            json = api.UploadString(apiUrl, "POST", json);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Models.FactClient>(json);
        }

        public static void BorrarPais(string apiUrl, int id)
        {
            var api = new System.Net.WebClient();
            api.Headers.Add("Content-Type", "application/json");
            api.UploadString(apiUrl + "/" + id, "DELETE", "");
        }
    }
}
