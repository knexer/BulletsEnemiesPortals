using UnityEngine;
using System.Collections;

public class HandleWinAndLose : MonoBehaviour {

    public static HandleWinAndLose instance { get; private set; }

    private int nWins = 0;
    private int nLosses = 0;

    void Start() {
        instance = this;
    }

    public void recordWin() {
        nWins++;
        HandleNewUnlocks.instance.registerUnlock("More Portals");
    }

    public void recordLoss() {
        nLosses++;
        HandleNewUnlocks.instance.registerUnlock("More Health");
    }
}
