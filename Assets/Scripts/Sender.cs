using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{

    //public delegate void PlayerDied();
    //public static event PlayerDied playerDiedInfo;

    //public delegate void PlayerDied(bool isAlive);
    //public static PlayerDied playerDiedInfo;

    public delegate float PlayerDied(Vector3 player, Vector3 target);
    public static PlayerDied playerDiedInfo;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ExexuteEvent", 3f);
    }

    void ExexuteEvent()
    {
        if (playerDiedInfo != null)
        {
            playerDiedInfo(new Vector3(1f, 1f, 1f), new Vector3(2f, 2f, 2f));
            
        }
    }


} // class
