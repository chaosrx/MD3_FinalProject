using UnityEngine;
using System.Collections;

public class gameEndingFade : MonoBehaviour
{

    public float fadeSpeed = 0.0f;

    private bool ready = false;
    private bool run = false;
    private bool kuk = false;

    //Sprite
    private GameObject theSprite;
    private SpriteRenderer spRen;
    private Color col;

    //Sprite 2 End credits
    private GameObject endSprite;
    private SpriteRenderer spEndRen;
    private Color colEnd;

    //Collider
    private GameObject theCollider;

    public float killApp = 10.0f;


    void Start()
    {


        theSprite = GameObject.FindGameObjectWithTag("endSprite");
        theCollider = GameObject.FindGameObjectWithTag("endCollider");
        endSprite = GameObject.FindGameObjectWithTag("endSprite2");


        spEndRen = endSprite.GetComponent<SpriteRenderer>();
        spRen = theSprite.GetComponent<SpriteRenderer>();

        col = spRen.color;
        colEnd = spEndRen.color;

    }


    void Update()
    {
        if (run && !ready)
        {
            fadeIn();
        }
        if (ready && !kuk)
        {
            fadeIn2();
        }
        if (kuk)
        {
            killApp -= Time.deltaTime;
            if (killApp < 0)
            {
                Application.Quit();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        print("------------------ COLLIDER ------------------------");
        run = true;
    }


    void fadeIn()
    {
        print("fadeIn");
        col.a = Mathf.Lerp(col.a, 1, Time.deltaTime * fadeSpeed);
        spRen.color = col;
        if (col.a >= 0.99f)
        {
            ready = true;
        }
    }

    void fadeIn2()
    {
        print("fadeIn");
        colEnd.a = Mathf.Lerp(colEnd.a, 1, Time.deltaTime * fadeSpeed);
        spEndRen.color = colEnd;
        if (colEnd.a >= 0.99f)
        {
            kuk = true;
        }
    }

}
