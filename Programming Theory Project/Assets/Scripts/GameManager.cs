using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject fatherPrefab;
    public GameObject[] sonPrefabs;
    public Text console;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateFather()
    {

        Instantiate(fatherPrefab, transform.position, transform.rotation);
    }

    public void GenerateSon()
    {
        int index = Random.Range(0, sonPrefabs.Length);
        Instantiate(sonPrefabs[index], transform.position, transform.rotation);
    }



}
