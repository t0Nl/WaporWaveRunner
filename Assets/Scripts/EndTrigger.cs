using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gm;

    void OnTriggerEnter (Collider colliderInfo)
    {
        if (colliderInfo.gameObject.tag == "Player")
        {
            gm.EndLevel();
        }
    }
}
