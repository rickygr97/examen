﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



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
    public Text textcoins;

    public int health;
    public GameObject health_hearts1;
    public GameObject health_hearts2;
    public GameObject health_hearts3;
    public int hearts;

    private float waitbtwattacks;
    public float starttimebtwattack;
    public Transform attackpos;
    public float attackrange;
    public LayerMask whatisEnemy;
    public int damage;

    public GameObject shoot;
    public Transform shootpos;
    public bool shootingactive;
    public int speeddrop;
    public einde einde;
    public GameObject splash;
    public AudioSource smak1;
    public AudioSource smak111;
    public float runtime;
    public float jumpinput;
    bool jumpbool = true;






















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
        shootingactive = false;
        speeddrop = 4;
        einde = GameObject.FindObjectOfType(typeof(einde)) as einde;
        runtime = 1.5f;









    }

    // Update is called once per frame
    void Update()
    {
        textcoins.text = " "+coins + " /8 ";
        if(coins == 8)
        {
          //  einde.end();
            einde.GetComponent<einde>().end();


        }

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
            SceneManager.LoadScene(0);



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
        if (shootingactive && waitbtwattacks <= 0)
        {
            shooting();

        }
        if(waitbtwattacks <= 0)
        {
            if(Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButtonDown(0) || Input.GetAxisRaw("Fire3") == 1)
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackpos.position,attackrange, whatisEnemy);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    if (enemiesToDamage[i].GetComponent<enemies>())
                    {
                            enemiesToDamage[i].GetComponent<enemies>().health -= damage;
                    }
                    if (enemiesToDamage[i].GetComponent<boss1>())
                    {
                        enemiesToDamage[i].GetComponent<boss1>().health -= damage;
                    }
                    smak();

                    

                   var clone = Instantiate(splash, attackpos.position,Quaternion.identity);
                    Destroy(clone, 0.4f);


                    //enemiesToDamage[i].GetComponent<milkshake>().health -= damage;
                    //enemiesToDamage[i].GetComponent<cubcake>().health -= damage;
                    waitbtwattacks = starttimebtwattack;
                }
            }
            

        }
        else
        {
            waitbtwattacks -= Time.deltaTime;

        }
        isopgrond = Physics2D.OverlapCircle(grondok.position, okradius, grondwatis);
        //if(jumpinput < Input.GetAxis("Vertical") && jumpsjumpies >= 0)
        //{
        //    rb.velocity = Vector2.up * jumpforce;
        //    jumpsjumpies--;
        //}else if (jumpinput <  Input.GetAxis("Vertical") && jumpsjumpies <= 0 && isopgrond == true)
        //{
        //    rb.velocity = Vector2.up * jumpforce;
        //}

            if (Input.GetKeyDown(KeyCode.W) && jumpsjumpies > 0 || Input.GetKeyDown(KeyCode.UpArrow) && jumpsjumpies > 0 ||/* jumpinput < Input.GetAxis("Vertical")*/ Input.GetAxisRaw("Jump") ==1 && jumpsjumpies > 0 && jumpbool == true)
        {
            rb.velocity = Vector2.up * jumpforce;
            jumpsjumpies--;
                jumpbool = false;
                StartCoroutine(waitforjump());


            }
        else if (Input.GetKeyDown(KeyCode.W) && jumpsjumpies <= 0 && isopgrond == true || Input.GetKeyDown(KeyCode.UpArrow) && jumpsjumpies <= 0 && isopgrond == true || /*jumpinput < Input.GetAxis("Vertical")*/  Input.GetAxisRaw("Jump") == 1 && jumpsjumpies <= 0 && jumpsjumpies <=0 && isopgrond ==true && jumpbool == true)
        {
            rb.velocity = Vector2.up * jumpforce;
                jumpbool = false;
            StartCoroutine(waitforjump());



        }

        if (isopgrond == true)
        {
            jumpsjumpies = extrajump;

        }

        #region movement
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetAxisRaw("Fire2") ==1)
        {
            moveinput = Input.GetAxis("Horizontal")*runtime;
        }
        else
        {
                moveinput = Input.GetAxis("Horizontal");
        }
        
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
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(attackpos.position, attackrange);

    }
    public void shooting()
    {
        if(Input.GetMouseButtonDown(1)|| Input.GetKeyDown(KeyCode.B) || Input.GetAxisRaw("Fire1") ==1)
        {
            if(facingleft == true)
            {
           var clone = Instantiate(shoot, shootpos.position, Quaternion.Euler(0,0,90));
            clone.GetComponent<Rigidbody2D>().velocity = Vector2.right * speeddrop;
            }
            if (facingleft == false)
            {
                var clone = Instantiate(shoot, shootpos.position, Quaternion.Euler(0,0,270));
                clone.GetComponent<Rigidbody2D>().velocity = Vector2.left * speeddrop;
            }


            waitbtwattacks = starttimebtwattack;

        }
    }
    public void smak()
    {
        smak1.Play();
       // smak111.Play();


    }
    IEnumerator waitforjump()
    {
        yield return new WaitForSeconds(0.5f);
        jumpbool = true;

    }
}
