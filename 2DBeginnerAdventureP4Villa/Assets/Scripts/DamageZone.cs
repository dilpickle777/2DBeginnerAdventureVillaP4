using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void OnTriggerEndter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if(controller != null )
        {
            controller.ChangeHealth(-1);
        }
    }


}
