using UnityEngine;
using UnityEngine.UI;


public class DisplayCollectable : MonoBehaviour {
    public DataContainer appleCounter;
    public Text displayAppleCount;

    void Update () {

        displayAppleCount.text = appleCounter.apples.ToString();
    }
}
