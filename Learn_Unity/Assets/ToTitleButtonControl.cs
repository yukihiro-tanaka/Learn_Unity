using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTitleButtonControl : MonoBehaviour
{
    [SerializeField] private Timer timer = default;
    [SerializeField] private GameObject toTitleButton = default;

    // Update is called once per frame
    void Update () {
        if (timer.isTimeUp) {
            toTitleButton.SetActive(true);
        }
    }
}
