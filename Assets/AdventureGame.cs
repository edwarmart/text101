using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;         //from the UnityEngine.UI library

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = ("Welcome to the Temple of the First. You have journeyed a long way to reach here, surely, and now, the journey has just begun. I know these words may read mysteriously to you at the moment, but fear not. You have arrived at your destination.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 