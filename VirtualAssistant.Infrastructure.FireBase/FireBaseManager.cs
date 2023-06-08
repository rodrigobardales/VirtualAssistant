using Newtonsoft.Json;
using VirtualAssitant.Core.Entities;
using Firebase.Database;
using Firebase.Database.Query;



namespace VirtualAssistant.Infrastructure.FireBase
{

    FirebaseClient firebaseClient;

    public FireBaseManager()
    {
        var firebaseConfig = new FirebaseConfig
        {
            AuthSecret = "tu_auth_secret",
            BasePath = "tu_base_path"
        };

        firebaseClient = new FirebaseClient(firebaseConfig);
    }

}

//string contenidoJson = File.ReadAllText("C:\\Users\\Plex\\Documents\\UNIVERIDAD\\Vanguardia\\proyecto\\VirtualAssistant\\aviation-data.json");
//Root datos = JsonConvert.DeserializeObject<Root>(contenidoJson);
//List<Data> listaDatos = datos.Data;


/* 
 using Firebase.Database;
using Firebase.Database.Query;

// ...

FirebaseClient firebaseClient;

public TuClasePrincipal()
{
    var firebaseConfig = new FirebaseConfig
    {
        AuthSecret = "tu_auth_secret",
        BasePath = "tu_base_path"
    };

    firebaseClient = new FirebaseClient(firebaseConfig);
}

 */