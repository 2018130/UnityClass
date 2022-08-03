using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    [SerializeField]
    bool state = false;
    [SerializeField]
    GameObject[] LightEffects;

    public void LightSetting(int number)
    {
        state = !state;
        LightEffects[number].SetActive(state);
    }
}
