using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SimulacionCarro 
{
    public Porfa porfa;
    
}
[System.Serializable]
public class Porfa 
{
    public Carros carros;
    public Semaforos semaforos;
    
}
[System.Serializable]
public class Carros 
{
    public List<List<float>> a;
    
}
[System.Serializable]
public class Semaforos 
{
    
    public List<List<float>> a;
}
public class CarMovement: MonoBehaviour

{
    public SimulacionCarro simulacionCarro;
    // Start is called before the first frame update
    void Start()
    {
        string jsonString = jsonFile.text;
        SimulacionCarro simulacionCarro = JsonUtility.FromJson<SimulacionCarro>(jsonString);
        Debug.Log(simulacionCarro.porfa.carros.a);
    }

    public TextAsset jsonFile;

    // Update is called once per frame
    void Update()
    {
        
    }
}
