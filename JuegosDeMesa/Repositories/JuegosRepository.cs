using JuegosDeMesa.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods; 
namespace JuegosDeMesa.Repositories
{
    public class JuegosRepository
    {
        string urlApi = "https://prueba-f77e.restdb.io/rest/juegosdemesa";
        HttpClient client = new HttpClient();

        public JuegosRepository()
        {
            //configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "0a088a25d849efa20181322f4ad03c27334b1");
        }

        public async Task<ObservableCollection<Juegos?>> ObtenerAsync()//Lee los juegos desde la api
        {

            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Juegos>>(response);

        }

        public async Task<Juegos?> AgregarAsync(string nombre, string tiempodejuego, string cantidadDeJugadores, string editorial)
        {
            Juegos juego = new Juegos()
            {
                nombre = nombre,
                tiempodejuego = tiempodejuego,
                CantidadDeJugadores = cantidadDeJugadores,
                editorial = editorial
            };
            //creamos un objeto del tipo Libro con los parámetros que llegan
            
           


            //enviamos por POST el objeto que creamos a la URL de la API
            var juegojson = new StringContent(JsonConvert.SerializeObject(juego), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(urlApi, juegojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Juegos>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Juegos?> ActualizarAsync(string nombre, string tiempodejuego, string cantidadDeJugadores, string editorial, string id)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Juegos juego = new Juegos()
            {
                nombre = nombre,
                tiempodejuego = tiempodejuego,
                CantidadDeJugadores = cantidadDeJugadores,
                editorial = editorial,
            };

            //enviamos por POST el objeto que creamos a la URL de la API
            var juegojson = new StringContent(
                JsonConvert.SerializeObject(juego),
                Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, juegojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Juegos>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Juegos> ObtenerId(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Juegos>(response);
        }

        public async Task<bool> EliminarAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }
    }
}
