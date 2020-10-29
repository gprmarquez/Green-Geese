using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public Sprite Level1;
    public Sprite Level2;
    public Sprite Level3;
    public Sprite Level4;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 50)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Level1;
        }

        if (transform.position.y >= 100)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Level2;
        }

        if (transform.position.y >= 150)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Level3;
        }

        if (transform.position.y >= 225)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Level4;
        }

    }
}
