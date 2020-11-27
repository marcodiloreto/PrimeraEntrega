using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace PrimeraEntrega.DAOS
{
    class UsuariosDAO
    {
        
        private static UsuariosDAO instancia;
        private UsuariosDAO() {
        
        }

        // para poder usar unicamente 1 objeto;
        public static UsuariosDAO getInstancia() {
            if (instancia == null) {
                instancia = new UsuariosDAO();
            }
            return instancia;
        }

        public Boolean check(String nom) {
            var client = getClient();

            var request = new RestRequest("api/check?name=" + nom + "&clave=dejamepasarporfavor");
            request.RequestFormat = DataFormat.Json;
            var response = client.Get(request).Content;
            return parse(response);
        }
        public Boolean login(String nom,String pass)
        {
            var client = getClient();

            var request = new RestRequest("api/login?name="+nom+"&pass="+pass+"&clave=dejamepasarporfavor");
            request.RequestFormat = DataFormat.Json;
            //dynamic response = JsonConvert.DeserializeObject(client.Get(request).Content);
            var response = client.Get(request).Content;
            return parse(response);
        }
        public Boolean isPay(String name)
        {
            var client = getClient();

            var request = new RestRequest("api/isPay?name=" + name + "&clave=dejamepasarporfavor");
            request.RequestFormat = DataFormat.Json;
            var response = client.Get(request).Content;
            return parse(response);
        }
        public Boolean validarKey(String key,String usuario) {
            var client = getClient();

            var request = new RestRequest("api/validarKey?name="+usuario+"&key="+key+"&clave=dejamepasarporfavor");
            request.RequestFormat = DataFormat.Json;
            var response = client.Get(request).Content;
            return parse(response);
        }
        private RestClient getClient() { 
        return new RestClient("https://localhost:44337/");
        }

        private Boolean parse(String resp) {
            if (resp.Equals("\"true\"")) {
                return true;
            }
            return false;
        }


       
}
}

