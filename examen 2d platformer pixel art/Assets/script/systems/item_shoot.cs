using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_shoot : MonoBehaviour
{
    player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<player>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<player>())
        {
            col.gameObject.GetComponent<player>().shootingactive = true;

            //player.coins += 1;
            Destroy(this.gameObject);
            Debug.Log("ti");

        }
    }
}
