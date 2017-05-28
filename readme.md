# Builder

Manager Application.

## Introduction

### GenericApplication

- Add Window to Application
    ```C#
    GenericApplication app = new GenericApplication(...);
    
    app.Add(new Window);
    //after this, we add window to an "addlist".
    //after process message, we add it to Application.
    ```
- Remove Window from Application
    ```C#
    GenericApplication app = new GenericApplication(...);
    
    app.Remove(Window);
    //after this, we add window to an "removelist".
    //after process message, we remove it from Application.
    ```

- RunLoop
    ```C#
    GenericApplication app = new GenericApplication(...);
    
    app.RunLoop();

    //The main loop:
        //process window's message.
        //update window's message.
    ```
- Destory
    ```C#
    GenericApplication app = new GenericApplication(...);
    
    app.Destory();
    //after this, the main loop will stop.
    ```

### GenericWindow

- Process Event
    ```C#
    public override void OnMouseMove(object sender, MouseMoveEventArgs e)
    {
        Console.WriteLine(e.X + " " + e.Y);
    }
    ```
- Enable  
    ```C#
    GenericWindow window = new GenericWindow(...);

    window.Enable(...);
    //if Enable is false,Process Event ... will ignore this window.
    ```

- Destory
    ```C#
    GenericWindow window = new GenericWindow(...);

    window.Destory();
    //after this, the window will remove from application.
    ```

## Sample

Look At [**Mico**](https://github.com/LinkClinton/Mico/tree/master/Sample)

## Request
- **.NET 4.7**
- [**APILibrary**](https://github.com/LinkClinton/APILibrary)