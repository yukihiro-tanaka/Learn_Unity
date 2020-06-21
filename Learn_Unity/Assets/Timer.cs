using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private float countTime = 10.0f;
    public bool isTimeUp { private set; get; } = false;

    // Update is called once per frame
    void Update () {
        if (countTime > 0) {
            countTime -= Time.deltaTime;
            if (countTime <= 0) {
                // Adjust extend time
                countTime = 0.0f;
                OnTimeUp();
            }
            GetComponent<Text>().text = countTime.ToString("F2");
        }
    }

    void OnTimeUp () {
        isTimeUp = true;
    }
}
