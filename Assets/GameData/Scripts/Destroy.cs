using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Start()
    {
        Invoke("destroy", 1.5f);
    }
    void destroy()
    {
        Destroy(this.gameObject);

    }

}
