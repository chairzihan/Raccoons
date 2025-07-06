using UnityEngine;
using UnityEngine.UI;

public class Cup : MonoBehaviour
{
    public bool isFull = false;
    public int coffeeAmt = 0;
    public int milkAmt = 0;
    public int totalAmt = 0;

    public float coffeeToMilkRatio;
    public Color drinkColor;

    [SerializeField] private Image fillBarImage;
    [SerializeField] private Slider cupSlider;

    void Start()
    {
        // No need to find objects in code; assign fillBarImage and cupSlider in the Inspector.
    }

    void Update()
    {

        totalAmt = coffeeAmt + milkAmt;

        if (totalAmt >= 4)
        {
            isFull = true;
        }
        else
        {
            isFull = false;
        }

        if (cupSlider != null)
        {
            cupSlider.value = totalAmt;
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

    public void ClearCup()
    {
        coffeeAmt = 0;
        milkAmt = 0;
        totalAmt = 0;
        isFull = false;
        Debug.Log("Cup cleared");
        if (cupSlider != null)
        {
            cupSlider.value = totalAmt;
        }
    }
}
