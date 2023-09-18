using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{

    public delegate void PlayerDied();
    public static event PlayerDied playerDiedInfo;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ExexuteEvent", 5f);
    }

    void ExexuteEvent()
    {
        if (playerDiedInfo != null)
        {
            playerDiedInfo();
        }
    }


} // class
