using System.Collections;
using UnityEngine;

public class SteamSafe : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
