using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeMovement : MonoBehaviour {
    public float force = 5.0f;
    public float speed = 5.0f;

    public Text ScoreText;
    private int score;
    private float timer;

    public Text BonusText;
    private float bonus;

    public Text LifeText;
    private float life;


    // Use this for initialization
    void Start() {
        force = 0;
        score = 0;
        bonus = 0;
        life = 3;
        TextCount();
    }

    // Update is called once per frame
    void Update() {

        TextCount();
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * force);
            force = 5;
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        else
        {

            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * -force);
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

    }
    void TextCount()
    {
        ScoreText.text = "Score : " + score.ToString();
        BonusText.text = "Bonus : " + bonus.ToString();
        LifeText.text = "Life : " + life.ToString();

        timer += 1 * Time.deltaTime;
        if (timer > 1)
        {
            score += 1;
            timer = 0;
        }

        if (score % 5 == 0)
        {
            bonus=score/10;   // цей код дає при кратному 10, +1 бонус. 
            
            
        }

    }

}
