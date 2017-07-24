# Builder

Manager Application.

## Introduction

### Application

- Add Window to Application
    ```C#
    Application.Add(new Window);
    //after this, we add window to an "addlist".
    //after process message, we add it to Application.
    ```
- Remove Window from Application
    ```C#
    Application.Remove(new Window)
    //after this, we add window to an "removelist".
    //after process message, we remove it from Application.
    ```

- RunLoop
    ```C#
    Application.RunLoop();

    //The main loop:
        //process window's message.
        //update window's message.
        //if no window in Application -> End
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
    GenericWindow window = new Window(...);

    window.Enable(...);
    //if Enable is false,Process Event ... will ignore this window.
    ```

- Destory
    ```C#
    GenericWindow window = new Window(...);

    window.Destory();
    //after this, the window will remove from application.
    ```

## Sample

Look At [**SampleSet**](https://github.com/LinkClinton/SampleSet)

## Request
- **.NET 4.6.2**
- [**APILibrary**](https://github.com/LinkClinton/APILibrary)