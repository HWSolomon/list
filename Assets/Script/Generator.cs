using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;


public class Generator : MonoBehaviour
{
    public Image im;
    public Text tName;
    public Text job;

    private string finalName;
    private string finalJob;
    public Sprite[] images;

    void Start()
    {
        GenerateNJ();
        tName.text = finalName;
        job.text = finalJob;
    }

    public void GenerateNJ()//generates name and jobs by putting in in pieces of names and job titles and then putting them together for a name or job
    {
        Random r = new Random();
        //nc = name component
        string[] nc1 = new string[] { "Abd", "Ad", "Aleks", "Alex", "Anth", "Art", "Benj"};
        string[] nc2 = new string[] { "ull", "am", "ams", "and", "andr", "on", "em"};
        string[] nc3 = new string[] { "ah.", "ik.", "se.", "er.", "e.", "as.", "a.", "in.", "y.", "iy.", "en." };

        finalName = nc1[r.Next(0, nc1.Length)] + nc2[r.Next(0, nc1.Length)] + nc3[r.Next(0, nc1.Length)];
        //jc = job component
        string[] jc1 = new string[] { "Junior ", "Intermediate ", "Senior ", "Chief "};
        string[] jc2 = new string[] { "Control ", "Safety ", "Office ", "Marketing ", "Finance ", "Executive "};
        string[] jc3 = new string[] { "Manager.", "Accountant.", "Officer.", "Assistant."};

        finalJob = jc1[r.Next(0, jc1.Length)] + jc2[r.Next(0, jc1.Length)] + jc3[r.Next(0, jc1.Length)];

        im.sprite = images[r.Next(0, images.Length)];//chooses image at random to be displayed
    }

}
