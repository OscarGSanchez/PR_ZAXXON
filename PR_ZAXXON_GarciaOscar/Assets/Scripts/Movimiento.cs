using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento : MonoBehaviour
{
    float despx;
    float despy;
    [SerializeField] float speed;
    float finaldrch = 70;
    float finalizq = -70;
    float finaldown = 6;
    float finalup = 25;
    bool limith = true;
    bool limitv = true;

    [SerializeField] GameObject navePrefab;
    InitGame initGame;

   


    // Start is called before the first frame update
    void Start()
    {
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
    }

    void movimiento()
    {
        float posx = transform.position.x;
        float posy = transform.position.y;


        despx = Input.GetAxis("Horizontal");

        if (limith)
        {
            transform.Translate(Vector3.right * despx * speed * Time.deltaTime);
        }



        despy = Input.GetAxis("Vertical");

        if (limitv)
        {
            transform.Translate(Vector3.up * despy * speed * Time.deltaTime);
        }

        if (posx > finaldrch && despx > 0 || posx < finalizq && despx < 0)
        {
            limith = false;
        }

        else
        {
            limith = true;
        }

        if (posy > finalup && despy > 0 || posy < finaldown && despy < 0)
        {
            limitv = false;
        }

        else
        {
            limitv = true;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        print("Ostia");
        if (other.gameObject.layer == 6)
        {

            initGame.SendMessage("Morir");
            navePrefab.SetActive(false);

        }
    }




}
