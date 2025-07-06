using UnityEngine;

public class Cup : MonoBehaviour
{

    public bool isFull = false;
    public int coffeeAmt = 0;
    public int milkAmt = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If cup is full, then update variable
        if (coffeeAmt + milkAmt >= 4)
        {
            isFull = true;
        }
    }

    public void AddCoffee()
    {
        if (!isFull)
        {
            coffeeAmt++;
            Debug.Log("added coffee");
        }
        else
        {
            Debug.Log("coffee not added, cup already full");
        }
    }

    public void AddMilk()
    {
        if (!isFull)
        {
            milkAmt++;
            Debug.Log("added milk");
        }
        else
        {
            Debug.Log("milk not added, cup already full");
        }
    }
}
