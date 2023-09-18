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

    void PlayerDiedListener()
    {
        print("Event has called this function to execute");
    }

}
