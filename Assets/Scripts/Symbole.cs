using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Symbole : MonoBehaviour
{
    public TypeSymbole[] symboleType;

    public GameObject[] position;
    public Material symboleToAppear;
    public GameObject positionToAppear;
    public int indexPosition;
    public int indexSymbole;
    public int numberOfButton;
    public int whichMaterial;
    public int numberOfMaterial;
    public Material symboleBase;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Wave1");
        StartCoroutine("ChooseButton");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

        }

        Wave1();
    }

    IEnumerator Wave1()
    {
        WaitForSeconds wait = new WaitForSeconds(2);
        numberOfButton = 3;
        //Random.Range(1, 3);
        for (int i = 0; i < numberOfButton; i++)
        {
            indexSymbole = Random.Range(0, symboleType.Length);
            indexPosition = Random.Range(0, position.Length);
            whichMaterial = Random.Range(0, 2);
            positionToAppear = position[indexPosition];
            
            ChooseButton();
            symboleType[indexSymbole].isActive = true;

            Debug.Log(indexPosition);
            
            yield return wait;
        }

        Wave1();
        
        
    }

    IEnumerator ChooseButton() 
    {
        WaitForSeconds wait1 = new WaitForSeconds(2);
        symboleToAppear = symboleType[indexSymbole].symbole[whichMaterial];
        
        positionToAppear.GetComponent<Renderer>().material = symboleToAppear;
        yield return wait1;
        symboleType[indexSymbole].isActive = false;
        positionToAppear.GetComponent<Renderer>().material = symboleBase;

    }

}
