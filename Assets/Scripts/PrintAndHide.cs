using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i;
    public Renderer rend;
    private int randInt;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        randInt = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + " : " + i);
        i++;

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue" && i == randInt)
        {
            rend.enabled = false;
        }
    }
}
