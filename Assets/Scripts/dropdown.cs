using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class dropdown : MonoBehaviour
{
    [SerializeField] private Material renderer;

    // Start is called before the first frame update
    private void HandleInputData(int val)
    {
    
        if (val == 0)
        {
            renderer.color = Color.green;
        }
        if (val == 1)
        {
            renderer.color = Color.yellow;
        }
        if (val == 2)
        {
            renderer.color = Color.black;
        }
        if (val == 3)
        {
            renderer.color = Color.blue;
        }
    }

}
