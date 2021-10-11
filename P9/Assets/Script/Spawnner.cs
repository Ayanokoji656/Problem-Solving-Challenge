using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public GameObject Persegi;
    public float Kiri, Kanan, Atas, Bawah;
    // Start is called before the first frame update
    void Start()
    {
        Muncul();
    }
    void Muncul()
    {
        int PenghitungBarang = Random.Range(5, 10);
        for (int i = 0; i < PenghitungBarang; i++)
        {
            float randomX = Random.Range(Kiri, Kanan);
            float randomY = Random.Range(Atas, Bawah);
            Instantiate(Persegi, new Vector2(randomX, randomY), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
