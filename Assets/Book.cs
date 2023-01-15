using UnityEngine;

public class Book:MonoBehaviour {

    private void OnMouseDown() {
        GetComponent<TimersandSFX>().StopCrying();
        GetComponent<TimersandSFX>().cryTimer = 0;
        GetComponent<TimersandSFX>().cooldown = 20;
    }
}