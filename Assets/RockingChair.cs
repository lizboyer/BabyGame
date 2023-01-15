using UnityEngine;

public class RockingChair:MonoBehaviour {

    private void OnMouseDown() {
        if (GetComponent<TimersandSFX>().ailment == 1) {
            GetComponent<TimersandSFX>().StopCrying();
            GetComponent<TimersandSFX>().cryTimer = 0;
            GetComponent<TimersandSFX>().cooldown = 20;
        }
    }
}