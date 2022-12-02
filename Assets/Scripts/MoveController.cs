using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public List<float> steps;
    public int carId;
    float dt;
    int index = 0;
    public int count = 0;

    void Update()
    {
        if (steps == null){
            return;
        }

        dt += Time.deltaTime;

        if (index % 4 == 0){
            float currentx = steps[count];
            float currenty = steps[count + 1];

            if (currentx == 0 && currenty == 0 && count > 60){
                currentx = 9999;
                currenty = 9999;
            }
            
            count = count + 6;

            if (count > 26928 - 1)
            {
                count = 26928 - 1;

                enabled = false;
            }
                
            Vector3 postion = new Vector3(currentx, 0, currenty);
            transform.localPosition = postion;// Tiene que ser local position para que sea afectado por el GameObject Pivot.
        }
        index=index+1;
        

    }
}