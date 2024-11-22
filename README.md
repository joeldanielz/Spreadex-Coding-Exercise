# Spreadex Coding Exercise
## Design Decisions
### 1. **Project Structure**
The project is divided into multiple folders to separate concerns and improve usability and maintainability.

### 2. **Inheritance and Polymorphism**
The `Widget` class is designed as an abstract base class, which is inherited by various specific widget types like `Circle`, `Square`, `Rectangle`, `Textbox`, and `Ellipse`. This allows for polymorphic behavior, enabling the `Drawing` class to manage a collection of different widget types uniformly.

### 3. **Encapsulation**
Properties such as `X`, `Y`, `Diameter`, `Width`, `Height`, and `Text` are encapsulated within their respective classes. This ensures that the internal state of each widget is protected and can only be accessed or modified through well-defined interfaces.

### 4. **Mocking for Testing**
A `MockWidget` class is created to facilitate unit testing. This mock class inherits from `Widget` and provides a simple implementation of the `GetDetails` method. This allows for testing the `Drawing` class without relying on the actual implementations of the various widget types.

### 5. **Unit Testing**
The `DrawingTests` class contains unit tests to verify the functionality of the `Drawing` class. Tests such as `AddWidget_ShouldAddWidgetToList` and `Print_ShouldPrintAllWidgetDetails` ensure that widgets are correctly added to the drawing and that their details are printed as expected.

## Further Work

### 1. **Error Handling**
Include validating the coordinates and dimensions of widgets to ensure they are within acceptable ranges.

### 2. **Create GUI**
Create a GUI to draw these objects, whether through a Nuget package, manually drawing the widgets on the console. Or even creating a webpage to display this data.

### 3. **Additional Widget Types**
Creating more widget types to allow for more complex drawings.

### 4. **Colours**
Adding colour properties to the widget and the ability to print these to the console with other colours.