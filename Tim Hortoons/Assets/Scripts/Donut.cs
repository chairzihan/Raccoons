using UnityEngine;

public class Donut : MonoBehaviour
{
    public string flavour = "";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddVanillaDonut()
    {
        if (flavour == "")
        {
            flavour = "vanilla";
            Debug.Log("added vanilla donut");
        }
        else
        {
            Debug.Log("can't add vanilla, donut already selected");
        }
    }

    public void AddChocolateDonut()
    {
        if (flavour == "")
        {
            flavour = "chocolate";
            Debug.Log("added chocolate donut");
        }
        else
        {
            Debug.Log("can't add chocolate, donut already selected");
        }
    }

    public void AddStrawberryDonut()
    {
        if (flavour == "")
        {
            flavour = "strawberry";
            Debug.Log("added strawberry donut");
        }
        else
        {
            Debug.Log("can't add strawberry, donut already selected");
        }
    }
}
