using UnityEngine;

public class Orders : MonoBehaviour
{
    [SerializeField] private EmploymentBar employmentBar;
    [SerializeField] private Cup cup;
    [SerializeField] private Donut donut;

    int[] coffeeOrders = { 2, 1, 4, 0, 2, 3 };
    int[] milkOrders = { 2, 3, 0, 4, 2, 1 };
    string[] donutOrders = { "chocolate", "strawberry", "vanilla", "strawberry", "chocolate", "vanilla" };

    int numCustomers = 6;
    int customerIndex = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    Debug.Log($"Customer {customerIndex + 1} has ordered {coffeeOrders[customerIndex]} coffee, {milkOrders[customerIndex]} milk, and {donutOrders[customerIndex]} donuts.");
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

    public void GetOrderScore()
    {
        int numCoffee = cup.coffeeAmt;
        int numMilk = cup.milkAmt;
        string donutType = donut.flavour;

        int score = 0;

        Debug.Log($"Comparing coffee: {numCoffee} (player) vs {coffeeOrders[customerIndex]} (order), milk: {numMilk} (player) vs {milkOrders[customerIndex]} (order)");
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

        Debug.Log($"Comparing donutType: '{donutType}' with order: '{donutOrders[customerIndex]}'");
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

        // Change employment bar based on score
        if (score > 0)
        {
            employmentBar.addEmployment(score);
            Debug.Log($"Employment increased by {score}. Current employment: {employmentBar.employment}");
        }
        else
        {
            employmentBar.reduceEmployment(-score);
            Debug.Log($"Employment decreased by {-score}. Current employment: {employmentBar.employment}");
        }
    }
}
