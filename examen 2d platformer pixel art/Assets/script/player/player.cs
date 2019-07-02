using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour
{
    SpriteRenderer komkommer;
    int speed;
    Rigidbody2D rb;
    float moveinput;
    bool facingleft;

    bool isopgrond;
    public Transform grondok;
    public float okradius;
    public LayerMask grondwatis;

    public int jumpsjumpies;
    int jumpforce;

   public int extrajump;
    Animator an;

    public int coins;
    public int health;
    public GameObject health_hearts1;
    public GameObject health_hearts2;
    public GameObject health_hearts3;
    public int hearts;








    // Start is called before the first frame update
    void Start()
    {
        komkommer = this.gameObject.GetComponent<SpriteRenderer>();
        speed = 5;
        rb = GetComponent<Rigidbody2D>();
        extrajump = 0;
        jumpforce = 7;
        an = this.gameObject.GetComponent<Animator>();


        health = 3;
        hearts = 3;



    }

    // Update is called once per frame
    void Update()
    {
        if(hearts == 3 && health ==2 )
        {
            health_hearts3.SetActive(false);
            hearts = 2;


        }
        if (hearts == 2 && health == 1)
        {
            health_hearts2.SetActive(false);
            hearts = 1;


        }
        if (hearts == 1 && health == 0)
        {
            hearts = 0;

            health_hearts1.SetActive(false);
            Debug.Log("0lives");


        }
        if(hearts == 2 && health == 2)
        {
            health_hearts2.SetActive(true);
        }
        if (hearts == 3 && health == 3)
        {
            health_hearts3.SetActive(true);
        }
        if(hearts >= 3 && health >= 3)
        {
            hearts = 3;
            health = 3;

        }
        isopgrond = Physics2D.OverlapCircle(grondok.position, okradius, grondwatis);

        if(Input.GetKeyDown(KeyCode.W) && jumpsjumpies >0|| Input.GetKeyDown(KeyCode.UpArrow) && jumpsjumpies >0)
        {
            rb.velocity = Vector2.up * jumpforce;
            jumpsjumpies--;

        }
        else if (Input.GetKeyDown(KeyCode.W) && jumpsjumpies<=0 && isopgrond == true|| Input.GetKeyDown(KeyCode.UpArrow) && jumpsjumpies <= 0 && isopgrond == true)
        {
            rb.velocity = Vector2.up * jumpforce;
            

        }
        if (isopgrond == true)
        {
            jumpsjumpies = extrajump;

        }

        #region movement
        moveinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveinput * speed, rb.velocity.y);
        #endregion
        #region characterleft
        if (facingleft == true && moveinput < 0)
        {
           // an.SetBool("walks",true);

            flipcharacter();

        }
        if (facingleft == false && moveinput > 0)
        {
           // an.SetBool("walks", true);
            flipcharacter();

        }
        if(moveinput > 0 || moveinput < 0)
        {
            an.SetBool("walks", true);
        }
        if(moveinput == 0)
        {
            an.SetBool("walks", false);
        }
        #endregion
        #region firstwhatif

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.left * speed * Time.deltaTime;
        //    komkommer.flipX = false;

        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right * speed * Time.deltaTime;
        //    komkommer.flipX = true;
        #endregion

        //}
    }
    void flipcharacter()
    {
        facingleft = !facingleft;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;

    }
}
