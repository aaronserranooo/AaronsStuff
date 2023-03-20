using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    PlayerMovement playerMovement;
    public int coinCount;
    
    //Start is called before the first frame update
    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    public bool PickupItem(GameObject obj)
    {
        switch (obj.tag)
        {
            case "Currency":
        coinCount++;
                return true;
            case "Speed+":
                playerMovement.SpeedPowerUp();
                return true;
            default:
                Debug.Log("Item tag or reference not set.");
                return false;

        }
    }
}
