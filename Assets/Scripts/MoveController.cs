using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public List<float> steps;
    public int carId;
    float dt;
    int index = 0;
    public int count;

    void Update()
    {
        if (steps == null){
            return;
        }

        dt += Time.deltaTime;

        float currentx = steps[index];
        float currenty = steps[index + 1];

        if (currentx == 0 && currenty == 0 && index > 60){
            currentx = 9999;
            currenty = 9999;
        }
        
        index=index+6;
        count = index;
        if (index > 14004 - 1)
        {
            index = 14004 - 1;

            enabled = false;
        }
            

        Vector3 postion = new Vector3(currentx, 0, currenty);
        transform.localPosition = postion;// Tiene que ser local position para que sea afectado por el GameObject Pivot.
    }
}