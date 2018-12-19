using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeAll : MonoBehaviour {

    public static FreezeAll current;
    public bool stop;

    public FreezeAll()
    {
        current = this;
    }

}
