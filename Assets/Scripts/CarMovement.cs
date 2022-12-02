using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class SimulationInfo 
{
    public Dicc dicc;
    
}
[System.Serializable]
public class Dicc 
{
    public Carros carros;
    public Semaforos semaforos;
    
}
[System.Serializable]
public class Carros
    {
        public int cantidad; 
        public Posiciones posiciones;
    }

[System.Serializable]
public class Posiciones
    {
        public Car car1;
        public Car car2;
        public Car car3;
        public Car car4;
        public Car car5;
        public Car car6;
        public Car car7;
        public Car car8;
        public Car car9;
        public Car car10;
        public Car car11;
        public Car car12;
        public Car car13;
        public Car car14;
        public Car car15;
        public Car car16;
        public Car car17;
        public Car car18;
        public Car car19;
        public Car car20;
        public Car car21;
        public Car car22;
        public Car car23;
        public Car car24;
        public Car car25;
        public Car car26;
        public Car car27;
        public Car car28;
        public Car car29;
        public Car car30;
        public Car car31;
        public Car car32;
    }

[System.Serializable]
public class Car
    {
        public List<float> lista;


    }


[System.Serializable]
public class Semaforos
    {
        public Sem sem1;
        public Sem sem2;
        public Sem sem3;
        public Sem sem4;
        public Sem sem5;
        public Sem sem6;
        public Sem sem7;
        public Sem sem8;
        public Sem sem9;
        public Sem sem10;
        public Sem sem11;
        public Sem sem12;
    }
[System.Serializable]
public class Sem
    {
        public int id;
        public List<int> estados; 
    }

public class CarMovement: MonoBehaviour

{

    public string url = "https://agente-tec-hilarious-ardvark.mybluemix.net/";
    public SimulationInfo simulationInfo;
    public TextAsset jsonFile;
    public SpawnManager spawnManager;
    // Start is called before the first frame update
    

    void Start()
    {
        StartCoroutine(GetRequest(url));
    }

    IEnumerator GetRequest(string url){
    using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
    {
        // Request and wait for the desired page.
        yield return webRequest.SendWebRequest();

        string[] pages = url.Split('/');
        int page = pages.Length - 1;

        switch (webRequest.result)
        {
            case UnityWebRequest.Result.ConnectionError:
            case UnityWebRequest.Result.DataProcessingError:
                Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                break;
            case UnityWebRequest.Result.ProtocolError:
                Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                break;
                case UnityWebRequest.Result.Success:

                string jsonString = webRequest.downloadHandler.text;
                SimulationInfo simulationInfo = JsonUtility.FromJson<SimulationInfo>(jsonString);
                spawnManager.SpawnAgents(simulationInfo);
                break;
        
    }
    }
    }
}
