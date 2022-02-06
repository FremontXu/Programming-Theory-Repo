using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Father : MonoBehaviour
{

    protected GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Debug.Log("Get GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        ShowInf();
        Destroy(gameObject);
    }

    protected virtual void ShowInf()
    {
        gameManager.console.text = "Father Object";
    }



}
