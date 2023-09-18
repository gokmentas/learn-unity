using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        Sender.playerDiedInfo += PlayerDiedListener;
    }

    private void OnDisable()
    {
        Sender.playerDiedInfo -= PlayerDiedListener;
    }

    float PlayerDiedListener(Vector3 player, Vector3 target)
    {
        print("Function is called. Distance is " + Vector3.Distance(player, target));
        return Vector3.Distance(player, target);
    }

}
