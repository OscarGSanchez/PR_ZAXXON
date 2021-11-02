using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMov : MonoBehaviour
{

    [SerializeField] float speed;
    InitGame initGame;

    void Start()
    {
        initGame = GameObject.Find("InitGame").GetComponent<InitGame>();
    }
    // Start is called before the first frame update
    void Update()
    {
        speed = initGame.spaceshipSpeed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        float posZ = transform.position.z;

        if (posZ < -60)
        {
            Destroy(gameObject);
        }

    }





}
