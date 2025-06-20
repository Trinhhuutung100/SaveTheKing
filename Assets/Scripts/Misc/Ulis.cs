using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ulis : MonoBehaviour
{
    public static void randomArray<T>(T[] array) {
        for (int i = 0; i < array.Length; i++) {
            int r = Random.Range(0, array.Length);
            T temp = array[i];
            array[i] = array[r];
            array[r] = temp;
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
