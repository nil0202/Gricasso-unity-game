using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private object box;
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    public GameObject[] blueBoxes;
    public GameObject[] redBoxes;
    public GameObject[] greenBoxes;
    public GameObject[] orangeBoxes;
    public GameObject[] purpleBoxes;
    private int color;
    public int numGlasses;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        color = 0;
        numGlasses = 5;
    }

    private void SwitchGlasses(bool back = false)
    {
        redBoxes = GameObject.FindGameObjectsWithTag("RED");
        blueBoxes = GameObject.FindGameObjectsWithTag("BLUE");
        greenBoxes = GameObject.FindGameObjectsWithTag("GREEN");
        orangeBoxes = GameObject.FindGameObjectsWithTag("ORANGE");
        purpleBoxes = GameObject.FindGameObjectsWithTag("PURPLE");

        if (back)
        {
            if (color == 0)
            {
                color = numGlasses - 1;
            }
            else
            {
                color--;
            }
        }
        else
        {
            if (color == numGlasses - 1)
            {
                color = 0;
            }
            else
            {
                color++;
            }
        }



        if (color == 0)
        {
            foreach (GameObject blueBoxes in blueBoxes)
            {
                blueBoxes.GetComponent<Collider2D>().enabled = true;
                blueBoxes.GetComponent<Renderer>().enabled = true;
            }
            foreach (GameObject redBoxes in redBoxes)
            {
                redBoxes.GetComponent<Collider2D>().enabled = false;
                redBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject greenBoxes in greenBoxes)
            {
                greenBoxes.GetComponent<Collider2D>().enabled = false;
                greenBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject orangeBoxes in orangeBoxes)
            {
                orangeBoxes.GetComponent<Collider2D>().enabled = false;
                orangeBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject purpleBoxes in purpleBoxes)
            {
                purpleBoxes.GetComponent<Collider2D>().enabled = false;
                purpleBoxes.GetComponent<Renderer>().enabled = false;
            }
        }
        else if (color == 1)
        {
            foreach (GameObject blueBoxes in blueBoxes)
            {
                blueBoxes.GetComponent<Collider2D>().enabled = false;
                blueBoxes.GetComponent<Renderer>().enabled = false;
            }

            foreach (GameObject redBoxes in redBoxes)
            {
                redBoxes.GetComponent<Collider2D>().enabled = true;
                redBoxes.GetComponent<Renderer>().enabled = true;
            }
            foreach (GameObject greenBoxes in greenBoxes)
            {
                greenBoxes.GetComponent<Collider2D>().enabled = false;
                greenBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject orangeBoxes in orangeBoxes)
            {
                orangeBoxes.GetComponent<Collider2D>().enabled = false;
                orangeBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject purpleBoxes in purpleBoxes)
            {
                purpleBoxes.GetComponent<Collider2D>().enabled = false;
                purpleBoxes.GetComponent<Renderer>().enabled = false;
            }
        }
        else if (color == 2)
        {
            foreach (GameObject blueBoxes in blueBoxes)
            {
                blueBoxes.GetComponent<Collider2D>().enabled = false;
                blueBoxes.GetComponent<Renderer>().enabled = false;
            }

            foreach (GameObject redBoxes in redBoxes)
            {
                redBoxes.GetComponent<Collider2D>().enabled = false;
                redBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject greenBoxes in greenBoxes)
            {
                greenBoxes.GetComponent<Collider2D>().enabled = true;
                greenBoxes.GetComponent<Renderer>().enabled = true;
            }
            foreach (GameObject orangeBoxes in orangeBoxes)
            {
                orangeBoxes.GetComponent<Collider2D>().enabled = false;
                orangeBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject purpleBoxes in purpleBoxes)
            {
                purpleBoxes.GetComponent<Collider2D>().enabled = false;
                purpleBoxes.GetComponent<Renderer>().enabled = false;
            }
        }
        else if (color == 3)
        {
            foreach (GameObject blueBoxes in blueBoxes)
            {
                blueBoxes.GetComponent<Collider2D>().enabled = false;
                blueBoxes.GetComponent<Renderer>().enabled = false;
            }

            foreach (GameObject redBoxes in redBoxes)
            {
                redBoxes.GetComponent<Collider2D>().enabled = false;
                redBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject greenBoxes in greenBoxes)
            {
                greenBoxes.GetComponent<Collider2D>().enabled = false;
                greenBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject orangeBoxes in orangeBoxes)
            {
                orangeBoxes.GetComponent<Collider2D>().enabled = true;
                orangeBoxes.GetComponent<Renderer>().enabled = true;
            }
            foreach (GameObject purpleBoxes in purpleBoxes)
            {
                purpleBoxes.GetComponent<Collider2D>().enabled = false;
                purpleBoxes.GetComponent<Renderer>().enabled = false;
            }
        }
        else if (color == 4)
        {
            foreach (GameObject blueBoxes in blueBoxes)
            {
                blueBoxes.GetComponent<Collider2D>().enabled = false;
                blueBoxes.GetComponent<Renderer>().enabled = false;
            }

            foreach (GameObject redBoxes in redBoxes)
            {
                redBoxes.GetComponent<Collider2D>().enabled = false;
                redBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject greenBoxes in greenBoxes)
            {
                greenBoxes.GetComponent<Collider2D>().enabled = false;
                greenBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject orangeBoxes in orangeBoxes)
            {
                orangeBoxes.GetComponent<Collider2D>().enabled = false;
                orangeBoxes.GetComponent<Renderer>().enabled = false;
            }
            foreach (GameObject purpleBoxes in purpleBoxes)
            {
                purpleBoxes.GetComponent<Collider2D>().enabled = true;
                purpleBoxes.GetComponent<Renderer>().enabled = true;
            }
        }
    }


    private void Update()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        moveDelta = new Vector3(x, y, 0);

        if (moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);


        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        }

        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
        }

        redBoxes = GameObject.FindGameObjectsWithTag("RED");
        blueBoxes = GameObject.FindGameObjectsWithTag("BLUE");


        if (Input.GetKeyDown("e"))
        {
            SwitchGlasses();
        }

        if (Input.GetKeyDown("q"))
        {
            SwitchGlasses(true);
        }
    }
}