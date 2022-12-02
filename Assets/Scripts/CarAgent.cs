using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAgent : AgentComponent
{
    public Transform target;
    public float speed = 1;
    public float rotationSpeed = 999;
    Vector3 lastPosition;
    public UIIdentifier uiIdentifier;

    public override void Update()
    {
        if (target == null)
        {
            return;
        }

        float distance = Vector3.Distance(transform.position, target.position);
        if (distance > 1000)
        {
            transform.position = target.position;
        }

        float delta = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            delta
        );

        var movementDirection = lastPosition - transform.position;
        if(movementDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(-movementDirection),
                //Time.deltaTime * rotationSpeed
                1
                );
        }

        

        lastPosition = transform.position;
    }
}
