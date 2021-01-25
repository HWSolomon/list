using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfList : MonoBehaviour
{

    public int infiniteL;
    public Text count;
    public GameObject original;
    public float maxCount;
    public List<GameObject> _list;
    public int change;


    void Start()
    {
        infiniteL = 1;
        maxCount = 2;
        change = 0;
        count.text = infiniteL.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))// used to generate new list parts when at the end and used to deactivate and activate when scrolling through the list itself
        {
            infiniteL += 1;
            count.text = infiniteL.ToString();
            if (infiniteL == maxCount)
            {
                maxCount += 1;
                GameObject clone = Instantiate(original);
                clone.transform.SetParent(transform, false);
                clone.SetActive(true);
                _list.Add(clone);

            }

            for (int i = 0; i < infiniteL - 1; i++)
            {
                _list[i].SetActive(false);
            }

            change = infiniteL;
            change -= 1;

            _list[change].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.W) && infiniteL > 1)//used to scroll up into the list by activating and deactivating the list parts
        {

            for (int i = 0; i < maxCount - 1; i++)
            {
                _list[i].SetActive(false);
            }

            infiniteL -= 1;
            change = infiniteL;
            change -= 1;

            count.text = infiniteL.ToString();
            _list[change].SetActive(true);


        }
    }
}
