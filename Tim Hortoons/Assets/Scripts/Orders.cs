using UnityEngine;

public class Orders : MonoBehaviour
{

    int[] coffeeOrders = { 2, 1, 4, 0, 2, 3 };
    int[] milkOrders = { 2, 3, 0, 4, 2, 1 };
    string[] donutOrders = { "chocolate", "strawberry", "vanilla", "strawberry", "chocolate", "vanilla" };

    int numCustomers = 6;
    int customerIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       }

    // Update is called once per frame
    void Update()
    {

    }


    public void GetCustomer()
    {
        customerIndex = Random.Range(0, numCustomers);
        Debug.Log($"Customer {customerIndex + 1} has ordered {coffeeOrders[customerIndex]} coffee, {milkOrders[customerIndex]} milk, and {donutOrders[customerIndex]} donuts.");
    }

    public int GetOrderScore(int numCoffee, int numMilk, string donutType)
    {
        int score = 0;

        if (numCoffee == coffeeOrders[customerIndex] && numMilk == milkOrders[customerIndex])
        {
            score += 5;
            Debug.Log($"Coffee is correct for Customer {customerIndex + 1}. Score: {score}");
        }
        else
        {
            score -= 5;
            Debug.Log($"Coffee is wrong for Customer {customerIndex + 1}. Score: {score}");
        }

        if (donutType == donutOrders[customerIndex])
        {
            score += 5;
            Debug.Log($"Donut is correct for Customer {customerIndex + 1}. Score: {score}");
        }
        else
        {
            score -= 5;
            Debug.Log($"Donut is wrong for Customer {customerIndex + 1}. Score: {score}");
        }

        return score;
    }
}
