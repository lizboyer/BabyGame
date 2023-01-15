using UnityEngine;

public class ChangingTable:MonoBehaviour {

    private void OnMouseDown() {
        if (GetComponent<TimersandSFX>().ailment == 3) {
            GetComponent<TimersandSFX>().StopCrying();
            GetComponent<TimersandSFX>().cryTimer = 0;
            GetComponent<TimersandSFX>().cooldown = 20;
        }
    }
}