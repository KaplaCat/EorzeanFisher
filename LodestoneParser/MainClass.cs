using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;

namespace LodestoneParser
{
    public class MainClass
    {
        static MainClass instance = null;


        public static MainClass GetInstance()
        {
            if (instance == null)
                instance = new MainClass();
            return instance;
        }

        public async void StartRequestAsync()
        {


        }

       
       
    }
}
