# Customer System Setup Guide

## Overview
This customer system creates a Papa's Pizzeria-style experience where customers come in, place random orders, and you need to serve them correctly before they get impatient.

## Components Created

### 1. Customer.cs (Updated)
- **Purpose**: Individual customer behavior and order management
- **Features**:
  - Random customer sprites and names
  - Random orders (coffee/milk combinations + donut flavors)
  - Satisfaction system based on wait time
  - Movement to order position and exit
  - Order validation

### 2. CustomerManager.cs (New)
- **Purpose**: Manages customer spawning and game flow
- **Features**:
  - Spawns customers at random intervals
  - Tracks score and statistics
  - Manages maximum customer count
  - Game start/stop functionality

### 3. OrderSystem.cs (New)
- **Purpose**: Handles serving orders to customers
- **Features**:
  - Validates orders against customer requests
  - Clears tray after serving
  - Provides feedback on correct/incorrect orders
  - Spacebar input for serving

### 4. Tray.cs (Updated)
- **Purpose**: Enhanced tray functionality
- **Features**:
  - Visual feedback (color changes when full)
  - Better integration with customer system
  - Helper methods for checking contents

## Setup Instructions

### Step 1: Create Customer Prefab
1. Create a new GameObject in your scene
2. Add the `Customer` script to it
3. Add a `SpriteRenderer` component
4. Add an `Animator` component (optional)
5. Create a child GameObject for the order bubble UI
6. Add UI elements to the order bubble:
   - Text for coffee order
   - Text for milk order  
   - Text for donut order
   - Text for customer name
7. Assign all the UI references in the Customer script inspector
8. Assign customer sprites to the `customerSprites` array
9. Create a prefab from this GameObject

### Step 2: Set Up Customer Manager
1. Create an empty GameObject called "CustomerManager"
2. Add the `CustomerManager` script to it
3. Assign the customer prefab to `customerPrefab`
4. Create empty GameObjects for:
   - `spawnPoint` (where customers appear)
   - `orderPoint` (where customers wait for orders)
   - `exitPoint` (where customers leave)
5. Assign these transforms in the inspector
6. Create UI elements for:
   - Score display
   - Customers served counter
   - Customers lost counter
7. Assign UI references in the inspector

### Step 3: Set Up Order System
1. Create an empty GameObject called "OrderSystem"
2. Add the `OrderSystem` script to it
3. Assign your tray GameObject to the `tray` field
4. Assign the CustomerManager to the `customerManager` field
5. Create a UI button for serving orders (optional)
6. Assign UI references in the inspector

### Step 4: Update Your Tray
1. Make sure your tray GameObject has both a `Cup` and `Donut` as children
2. Assign these in the `Tray` script inspector
3. Add a `SpriteRenderer` to the tray for visual feedback
4. Assign the renderer in the inspector

### Step 5: Connect to Start Button
Update your `StartButton.cs` to call the CustomerManager:

```csharp
public class StartButton : MonoBehaviour
{
    [SerializeField] private CustomerManager customerManager;
    
    public void StartGame()
    {
        if (customerManager != null)
        {
            customerManager.StartGame();
        }
    }
}
```

## How It Works

1. **Customer Spawning**: Customers spawn at random intervals (10-20 seconds by default)
2. **Order Generation**: Each customer gets a random order:
   - Coffee: 0-4 units
   - Milk: 0-4 units (total drink ≤ 4)
   - Donut: vanilla, chocolate, strawberry, or none
3. **Customer Movement**: Customers move to the order position and wait
4. **Order Preparation**: You prepare drinks and donuts using your existing systems
5. **Serving**: Press SPACE or use the serve button to serve orders
6. **Validation**: The system checks if the order matches what the customer requested
7. **Scoring**: Points awarded based on satisfaction and speed
8. **Customer Exit**: Customers leave happy or unhappy based on service

## Customization

### Timing
- Adjust `minSpawnTime` and `maxSpawnTime` in CustomerManager
- Change `maxWaitTime` in Customer script
- Modify `maxCustomers` for difficulty

### Scoring
- Correct orders: 100 points × satisfaction level
- Wrong orders: -50 points
- Customer leaves: -50 points

### Visuals
- Add more customer sprites to the array
- Customize order bubble appearance
- Add particle effects for correct/incorrect orders
- Add sound effects for various events

## Tips

1. **Test the System**: Start with 1-2 customers max to test the flow
2. **UI Feedback**: Add visual indicators for customer satisfaction
3. **Sound Design**: Add audio cues for order completion, customer arrival, etc.
4. **Difficulty Progression**: Increase spawn rate and reduce wait time as the game progresses
5. **Special Customers**: The system includes a 10% chance for "Raccoon" customers - you can expand this with special behaviors

## Troubleshooting

- **Customers not spawning**: Check if CustomerManager has the prefab assigned
- **Orders not validating**: Ensure Cup and Donut components are properly assigned to the tray
- **UI not updating**: Verify all Text components are assigned in the inspector
- **Movement issues**: Check that spawn, order, and exit points are assigned

This system provides a solid foundation for a restaurant management game similar to Papa's Pizzeria, with room for expansion and customization! 