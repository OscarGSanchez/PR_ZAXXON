using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    [SerializeField] GameObject MyPrefab;
    [SerializeField] GameObject MyPrefabY;
    [SerializeField] GameObject MyPrefabPared;
    [SerializeField] Transform InitPos;
    [SerializeField] Transform InitPosY;
    [SerializeField] Transform InitPosPared;
    [SerializeField] GameObject[] arrayObst;
    [SerializeField] InitGame initGame;

    [SerializeField] Vector3[] shipPos = new Vector3[2];
    public GameObject NaveSaers;

    int level;
    float intervalo;
    

    // Start is called before the first frame update
    void Start()
    {

        //Posiciones de la nave
        Vector3 posRandom1 = new Vector3(-5, 0, 0);
        Vector3 posRandom2 = new Vector3(5, 0, 0);
        shipPos[0] = posRandom1;
        shipPos[1] = posRandom2;

        int randomShipPos = Random.Range(0, 2);
        Instantiate(NaveSaers, shipPos[randomShipPos],Quaternion.identity);






        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();
        intervalo = 1f;
        StartCoroutine("CrearObstaculos");
        /*
        StartCoroutine("CrearObstaculosY");
        StartCoroutine("CrearObstaculosPared");
        */
    }

    public void Parar()
    {
        print("Se han parado la corrutina");
        StopCoroutine("CrearObstaculos");
    }


    IEnumerator CrearObstaculos()
    {
        while (true)
        {
            
            Vector3 instPos = new Vector3(Random.Range(-40f, 40f),Random.Range(5f, 40f), InitPos.position.z);
            int rand = Random.Range(0, arrayObst.Length);

           
            
            if (rand == 0)
            {
                instPos = new Vector3 (Random.Range(-63f, 63f), 20, InitPos.position.z);
                Instantiate(MyPrefab, instPos, Quaternion.identity);
            }
            else if(rand == 1)
            {
                instPos = new Vector3 (Random.Range(-63f, 63f), Random.Range(5f, 40f), InitPos.position.z);
                Instantiate(MyPrefabY, instPos, Quaternion.identity);
            }
            else
            {
                instPos = new Vector3(0, 20, InitPos.position.z);
                Instantiate(MyPrefabPared, instPos, Quaternion.identity);
            }
            



            yield return new WaitForSeconds(intervalo);

        }


    }
    /*
    IEnumerator CrearObstaculosY()
    {

        while (true)
        {

            Vector3 instPos = new Vector3(Random.Range(-40f, 40f), Random.Range(10f, 40f), InitPosY.position.y);
            Instantiate(MyPrefabY, instPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);

        }


    }

    IEnumerator CrearObstaculosPared()
    {

        while (true)
        {

            Vector3 instPos = new Vector3(Random.Range(-40f, 40f), Random.Range(10f, 40f), InitPosY.position.y);
            Instantiate(MyPrefabPared, instPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);

        }


    }
    */
}
