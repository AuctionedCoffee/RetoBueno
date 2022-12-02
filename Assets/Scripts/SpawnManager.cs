using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnManager : MonoBehaviour
{
    public CarAgent[] agentsPrefabs;
    //public TrafficLightAgent trafficLightPrefab;
    public MoveController moveControllerPrefab;
    SimulationInfo simulationInfo;



    
    public Transform pivot;

    public class Agent{
        public int id;
        public int type;
        public List<float> steps;
    }




    public void SpawnAgents(SimulationInfo simulationInfo)
    {
        this.simulationInfo = simulationInfo;        
        
        for (int i = 0; i < 32; i++) 
        {
            AgentComponent agentComponent = null;
            Agent agent = new Agent();
            agent.id = i;
            agent.type = 0;
            
            BuildCar(ref agentComponent, agent);
            
            agentComponent.agentId = i;
            agentComponent.type = 0;
        }

    }

    void BuildCar(ref AgentComponent agentComponent, Agent agent)
    {
        int randomInt = UnityEngine.Random.Range(0, agentsPrefabs.Length);
        agentComponent = Instantiate(agentsPrefabs[randomInt], pivot, false);
        agentComponent.name = agentsPrefabs[randomInt].name + " ID: " + agent.id;
        MoveController moveController = Instantiate(moveControllerPrefab, pivot, false);
        moveController.name = "Move Controller ID " + agent.id;
        agentComponent.GetComponent<CarAgent>().target = moveController.transform;
        moveController.steps = GetSteps(agent.id);
        agentComponent.transform.position = new Vector3 (moveController.steps[0]+pivot.position.x, 0, moveController.steps[1]+pivot.position.z);
        moveController.carId = agent.id;
        //Debug.Log("Steps: "+moveController.carId +" "+ moveController.steps.Count);
        //Vector3 position = new Vector3(moveController.steps[0].StepInfo.positionX, 0, moveController.steps[0].StepInfo.positionY);
        //agentComponent.transform.localPosition = position;
        //Debug.Log(string.Join(",", moveController.steps.Select(s => s.Stepinfo.positionY.ToString()).ToArray()));
        moveController.enabled = true;
    }

    /*void BuildTrafficLight(ref AgentComponent agentComponent, Agent agent)
    {
        agentComponent = Instantiate(trafficLightPrefab, pivot, false);
        agentComponent.name = "Traffic Light ID: " + agent.id;
        var steps = GetSteps(agent.id);
        //Vector3 position = new Vector3(steps[0].StepInfo.positionX, 0, steps[0].StepInfo.positionY);
        //agentComponent.transform.localPosition = position;
        agentComponent.GetComponent<TrafficLightAgent>().steps = steps;
    }*/

    List<float> GetSteps(int id)
    {
        var steps = simulationInfo.dicc.carros.posiciones.car1;
        switch(id){
        case 0:
            steps = simulationInfo.dicc.carros.posiciones.car1;
            break;
        case 1:
            steps = simulationInfo.dicc.carros.posiciones.car2;
            break;
        case 2:
            steps = simulationInfo.dicc.carros.posiciones.car3;
            break;
        case 3:
            steps = simulationInfo.dicc.carros.posiciones.car4;
            break;
        case 4: 
            steps = simulationInfo.dicc.carros.posiciones.car5;
            break;  
        case 5:
             steps = simulationInfo.dicc.carros.posiciones.car6;
            break;
        case 6:
             steps = simulationInfo.dicc.carros.posiciones.car7;
            break;
        case 7:
             steps = simulationInfo.dicc.carros.posiciones.car8;
            break;
        case 8:
             steps = simulationInfo.dicc.carros.posiciones.car9;
            break;
        case 9:
             steps = simulationInfo.dicc.carros.posiciones.car10;
            break;
        case 10:
             steps = simulationInfo.dicc.carros.posiciones.car11;
            break;
        case 11:
             steps = simulationInfo.dicc.carros.posiciones.car12;
            break;
        case 12:
             steps = simulationInfo.dicc.carros.posiciones.car13;
            break;
        case 13:
             steps = simulationInfo.dicc.carros.posiciones.car14;
            break;
        case 14:
             steps = simulationInfo.dicc.carros.posiciones.car15;
            break;
        case 15:
             steps = simulationInfo.dicc.carros.posiciones.car16;
            break;
        case 16:
             steps = simulationInfo.dicc.carros.posiciones.car17;
            break;
        case 17:
             steps = simulationInfo.dicc.carros.posiciones.car18;
            break;
        case 18:
             steps = simulationInfo.dicc.carros.posiciones.car19;
            break;
        case 19:
             steps = simulationInfo.dicc.carros.posiciones.car20;
            break;
        case 20:
             steps = simulationInfo.dicc.carros.posiciones.car21;
            break;
        case 21:
             steps = simulationInfo.dicc.carros.posiciones.car22;
            break;
        case 22:
             steps = simulationInfo.dicc.carros.posiciones.car23;
            break;
        case 23:
             steps = simulationInfo.dicc.carros.posiciones.car24;
            break;
        case 24:
             steps = simulationInfo.dicc.carros.posiciones.car25;
            break;
        case 25:
             steps = simulationInfo.dicc.carros.posiciones.car26;
            break;
        case 26:
             steps = simulationInfo.dicc.carros.posiciones.car27;
            break;
        case 27:
             steps = simulationInfo.dicc.carros.posiciones.car28;
            break;
        case 28:
             steps = simulationInfo.dicc.carros.posiciones.car29;
            break;
        case 29:
             steps = simulationInfo.dicc.carros.posiciones.car30;
            break;
        case 30:
             steps = simulationInfo.dicc.carros.posiciones.car31;
            break;
        case 31:
             steps = simulationInfo.dicc.carros.posiciones.car32;
            break;
        default:
             steps = simulationInfo.dicc.carros.posiciones.car1;
            break;
        }

        return steps.lista;
    }
}