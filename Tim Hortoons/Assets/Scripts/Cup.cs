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

    void AddCoffee()
    {
        coffeeAmt++;
    }

    void addMilk()
    {
        milkAmt++;
    }
}
