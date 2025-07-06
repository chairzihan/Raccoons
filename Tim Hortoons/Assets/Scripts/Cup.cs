using UnityEngine;
using UnityEngine.UI; // Add this for Image

public class Cup : MonoBehaviour
{

    public bool isFull = false;
    public int coffeeAmt = 0;
    public int milkAmt = 0;
    public int totalAmt = 0;

    public float coffeeToMilkRatio;
    public Color drinkColor;

    private Image fillBarImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the FillBar image in the scene
        GameObject fillBarObj = GameObject.Find("CoffeeScreen/Cup2/FillBar");
        if (fillBarObj != null)
        {
            fillBarImage = fillBarObj.GetComponent<Image>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        totalAmt = coffeeAmt + milkAmt;
        // If cup is full, then update variable
        if (totalAmt >= 4)
        {
            isFull = true;
        }

        if (coffeeAmt == 0 && milkAmt == 0)
        {
            ColorUtility.TryParseHtmlString("#FFFFFF", out drinkColor); // Empty cup, treat as milk only
        }
        else if (coffeeAmt == 0 && milkAmt == 1)
        {
            ColorUtility.TryParseHtmlString("#FFFFFF", out drinkColor); // Only milk
        }
        else if (coffeeAmt == 0 && milkAmt == 2)
        {
            ColorUtility.TryParseHtmlString("#FFFFFF", out drinkColor);
        }
        else if (coffeeAmt == 0 && milkAmt == 3)
        {
            ColorUtility.TryParseHtmlString("#FFFFFF", out drinkColor);
        }
        else if (coffeeAmt == 0 && milkAmt == 4)
        {
            ColorUtility.TryParseHtmlString("#FFFFFF", out drinkColor);
        }
        else if (coffeeAmt == 1 && milkAmt == 0)
        {
            ColorUtility.TryParseHtmlString("#000000", out drinkColor); // Only coffee (black)
        }
        else if (coffeeAmt == 1 && milkAmt == 1)
        {
            ColorUtility.TryParseHtmlString("#E28F48", out drinkColor); // 1:1 ratio
        }
        else if (coffeeAmt == 1 && milkAmt == 2)
        {
            ColorUtility.TryParseHtmlString("#EEBB7A", out drinkColor); // 0.5 ratio
        }
        else if (coffeeAmt == 1 && milkAmt == 3)
        {
            ColorUtility.TryParseHtmlString("#F5E3CB", out drinkColor); // 0.33 ratio
        }
        else if (coffeeAmt == 2 && milkAmt == 0)
        {
            ColorUtility.TryParseHtmlString("#000000", out drinkColor); // Only coffee (black)
        }
        else if (coffeeAmt == 2 && milkAmt == 1)
        {
            ColorUtility.TryParseHtmlString("#6C3225", out drinkColor); // 2:1 ratio
        }
        else if (coffeeAmt == 2 && milkAmt == 2)
        {
            ColorUtility.TryParseHtmlString("#E28F48", out drinkColor); // 1:1 ratio
        }
        else if (coffeeAmt == 2 && milkAmt == 3)
        {
            ColorUtility.TryParseHtmlString("#EEBB7A", out drinkColor); // 0.67 ratio (closest: 0.5)
        }
        else if (coffeeAmt == 3 && milkAmt == 0)
        {
            ColorUtility.TryParseHtmlString("#000000", out drinkColor); // Only coffee (black)
        }
        else if (coffeeAmt == 3 && milkAmt == 1)
        {
            ColorUtility.TryParseHtmlString("#1A1512", out drinkColor); // 3:1 ratio
        }
        else if (coffeeAmt == 3 && milkAmt == 2)
        {
            ColorUtility.TryParseHtmlString("#6C3225", out drinkColor); // 1.5 ratio (closest: 2)
        }
        else if (coffeeAmt == 4 && milkAmt == 0)
        {
            ColorUtility.TryParseHtmlString("#000000", out drinkColor); // Only coffee (black)
        }



        // try
        // {
        //     coffeeToMilkRatio = (float)System.Math.Round((double)coffeeAmt / milkAmt, 2);

        //     switch (coffeeToMilkRatio)
        //     {
        //         case 0:
        //             ColorUtility.TryParseHtmlString("#FFFFFF", out drinkColor); // White color for milk only
        //             Debug.Log("No coffee added, only milk present.");
        //             break;
        //         case 0.33:
        //             ColorUtility.TryParseHtmlString("#F5E3CB", out drinkColor);
        //             Debug.Log("One third as much coffee as milk.");
        //             break;
        //         case 0.5:
        //             ColorUtility.TryParseHtmlString("#EEBB7A", out drinkColor);
        //             Debug.Log("Half as much coffee as milk.");
        //             break;
        //         case 1:
        //             ColorUtility.TryParseHtmlString("#E28F48", out drinkColor);
        //             Debug.Log("Equal amounts of coffee and milk.");
        //             break;
        //         case 2:
        //             ColorUtility.TryParseHtmlString("#6C3225", out drinkColor);
        //             Debug.Log("Twice as much coffee as milk.");
        //             break;
        //         case 3:
        //             ColorUtility.TryParseHtmlString("#1A1512", out drinkColor);
        //             Debug.Log("Three times as much coffee as milk.");
        //             break;
        //     }
        // }
        // catch (System.DivideByZeroException)
        // {
        //     Debug.Log("No milk added, coffee to milk ratio cannot be calculated.");
        //     ColorUtility.TryParseHtmlString("#000000", out drinkColor);
        // }

        // Debug.Log(drinkColor);

        // Update FillBar color if reference found
        if (fillBarImage != null)
        {
            fillBarImage.color = drinkColor;
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
