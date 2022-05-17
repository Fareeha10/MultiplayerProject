using System.Collections;
using Mirror;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour
{
    void HandleMovement()
    {
        //check if the script is running on local player so that one player does not control somebody else's movement
        if (isLocalPlayer)  // this term is prov ided by networkbehaviour
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal *0.1f, moveVertical *0.1f, 0);   //adding f here to specify its a float
            transform.position = transform.position + movement;

        }
    }

    void update()
    {
        HandleMovement();
    }

}
