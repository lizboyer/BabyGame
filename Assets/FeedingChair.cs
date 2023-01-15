using UnityEngine;

public class FeedingChair:MonoBehaviour {

    private void OnMouseDown() {
        if (GetComponent<TimersandSFX>().ailment == 2) {
            GetComponent<TimersandSFX>().StopCrying();
            GetComponent<TimersandSFX>().cryTimer = 0;
            GetComponent<TimersandSFX>().cooldown = 20;
        }
    }
}