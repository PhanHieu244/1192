using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    public Image image;
    public Sprite[] cars;

    public void SetUpCar(int id)
    {
        try
        {
            image.sprite = cars[id];
        }
        catch (Exception e)
        {
            Debug.LogError(e);
            throw;
        }
    }
}
