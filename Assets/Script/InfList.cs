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
    public RectTransform master;
    public int Transf;

    void Start()
    {
        infiniteL = 1;
        maxCount = 1;
        change = 0;
        count.text = infiniteL.ToString();
    }

    void Update()
    {
        count.text = infiniteL.ToString();

        if (change <= 2)
        {
            change += 1;

            GameObject cloneDown = Instantiate(original, new Vector3(0, change * -Transf, 0), Quaternion.identity);
            cloneDown.transform.SetParent(transform, false);
            cloneDown.SetActive(true);
            _list.Add(cloneDown);
            infiniteL += 1;

            GameObject cloneUp = Instantiate(original, new Vector3(0, change * Transf, 0), Quaternion.identity);
            cloneUp.transform.SetParent(transform, false);
            cloneUp.SetActive(true);
            _list.Add(cloneUp);
            infiniteL += 1;
        }

        if (transform.localPosition.y >= maxCount * 80 || transform.localPosition.y <= maxCount * -80)
        {
            maxCount += 1;
            change += 1;
            GameObject cloneDown = Instantiate(original, new Vector3(0, change * -Transf, 0), Quaternion.identity);
            cloneDown.transform.SetParent(transform, false);
            cloneDown.SetActive(true);
            _list.Add(cloneDown);
            infiniteL += 1;

            GameObject cloneUp = Instantiate(original, new Vector3(0, change * Transf, 0), Quaternion.identity);
            cloneUp.transform.SetParent(transform, false);
            cloneUp.SetActive(true);
            _list.Add(cloneUp);
            infiniteL += 1;

        }
    }

    public void GenerateBottom()
    {
        GameObject clone = Instantiate(original, new Vector3(0, maxCount * -Transf, 0), Quaternion.identity);
        clone.transform.SetParent(transform, false);
        clone.SetActive(true);
        _list.Add(clone);
    }
}
