using Microsoft.AspNetCore.DataProtection;
using System.Net;
using Newtonsoft.Json;

namespace DECK_OF_CARDS_API.Models
{
    public class DeckDAL
    {
        public static DeckModel GetCards(int numberOfCards)//Adjust here
        {
            //adjust
            //setup
            string apiKey = Secret.apiKey;
            string url = $"https://deckofcardsapi.com/api/deck/{apiKey}/draw/?count={numberOfCards}";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();

            //Adjust
            //Convert to c#
            //Install Newtonsoft.json
            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(json);
            return result;
        }
        public static void ResetCards()//Adjust here
        {
            //adjust
            //setup
            string apiKey = Secret.apiKey;
            string url = $"https://deckofcardsapi.com/api/deck/{apiKey}/shuffle/";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();

            //Adjust
            //Convert to c#
            //Install Newtonsoft.json
            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(json);
            
        }
    }
}
