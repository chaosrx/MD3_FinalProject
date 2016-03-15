using UnityEngine;
using System.Collections;

public class fadingPictures : MonoBehaviour
{
    public GameObject Sprite;

    public Sprite bild1;
    public Sprite bild2;
    public Sprite bild3;
    public Sprite bild4;
    public Sprite bild5;

    public float fadespeed = 2;
    public SpriteRenderer ren;
    public Color ma;
    public bool readyA;
    public bool readyB;
    public bool initRun;

    public float tajm;


    void Start()
    {
        ren = Sprite.GetComponent<SpriteRenderer>();
        ren.sprite = bild1;
        ma = ren.color;
        ma.a = 0.0f;
        initRun = true;
    }

    void Update()
    {
        tajm = Time.time;


        if (tajm >= 7)
        {

            if (ren.sprite == bild1)
            {
                if (initRun)
                {
                    fadeIn();
                }

                if (readyA)
                {
                    fadeOut();
                }
                if (readyB)
                {
                    ren.sprite = bild2;
                    initRun = true;
                    readyB = false;
                }
            }

            if (ren.sprite == bild2)
            {
                if (initRun)
                {
                    fadeIn();
                }

                if (readyA)
                {
                    fadeOut();
                }
                if (readyB)
                {
                    ren.sprite = bild3;
                    initRun = true;
                    readyB = false;
                }
            }

            if (ren.sprite == bild3)
            {
                if (initRun)
                {
                    fadeIn();
                }

                if (readyA)
                {
                    fadeOut();
                }
                if (readyB)
                {
                    ren.sprite = bild4;
                    initRun = true;
                    readyB = false;
                }
            }

            if (ren.sprite == bild4)
            {
                if (initRun)
                {
                    fadeIn();
                }

                if (readyA)
                {
                    fadeOut();
                }
                if (readyB)
                {
                    ren.sprite = bild5;
                    initRun = true;
                    readyB = false;
                }
            }

            if (ren.sprite == bild5)
            {
                if (initRun)
                {
                    fadeIn();
                }

                if (readyA)
                {
                    fadeOut();
                }
                if (readyB)
                {
                    initRun = false;
                    readyB = false;
                    Destroy(this);
                }
            }

        }

    }

    void fadeIn()
    {
        ma.a = Mathf.Lerp(ma.a, 1, Time.deltaTime * fadespeed);
        ren.color = ma;
        if (ma.a >= 0.90f)
        {
            readyA = true;
            initRun = false;
        }
    }

    void fadeOut()
    {
        ma.a -= Mathf.Lerp(0, 1, Time.deltaTime * fadespeed);
        ren.color = ma;
        if (ma.a < 0.001f)
        {
            readyA = false;
            readyB = true;
        }
    }
}





/*


     if (ren.color.a < 0.90f)
            {
                print("fadeIn");
                fadeIn();
            }

            if (ren.color.a >= 0.90f)
            {
                print("fadeOut");
                fadeOut();
            }







    */
