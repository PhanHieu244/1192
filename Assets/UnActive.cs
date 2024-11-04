using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnActive : MonoBehaviour
{
    public void SetUnActive(bool active)
    {
        gameObject.SetActive(!active);
    }
}
