using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject[] food;
    public Text price;

    public void OpenPizza()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
        food[0].SetActive(true);
        price.text = "Price : 15 GBP";
    }
    public void OpenChicken()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
        food[1].SetActive(true);
        price.text = "Price : 10 GBP";
    }
    public void OpenCoffee()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
        food[2].SetActive(true);
        price.text = "Price : 6 GBP";
    }
    public void OpenFries()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
        food[3].SetActive(true);
        price.text = "Price : 5 GBP";
    }
    public void OpenTofu()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].SetActive(false);
        }
        food[4].SetActive(true);
        price.text = "Price : 12 GBP";
    }
}
