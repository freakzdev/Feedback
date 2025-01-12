# Feedback

Feedback is a .NET MAUI library that allows you to display response messages for executed processes or tasks. It supports different types of feedback such as error, info, success, and warning. You can customize the title and description, and it uses animations for when the messages appear and disappear.

## Features

- Display feedback messages for processes or tasks
- Support for different feedback types: error, info, success, and warning
- Customizable title and description
- Animations for appearing and disappearing messages

## Version

Current version: 1.0.2

## Icons

To use the feedback icons, copy the SVG icons from the `icons` folder to the `Resources\Images` folder of your main project. Feel free to modify the icons to suit your needs.

## Properties

| Property   | Description                                                                 | Default Value |
|------------|-----------------------------------------------------------------------------|---------------|
| **Size**   | Defines the size of the control. Based on this value, the size of the icon, title, and description is determined. | 100           |
| **Type**   | Determines the type of icon: error, info, success, warning.                 | info          |
| **Title**  | The title of the message.                                                   | Empty string  |
| **Description** | The description of the message.                                        | Empty string  |
| **IsVisible**   | Determines the visibility of the control.                              | false         |

## Usage

First, add the namespace to your XAML file:

```xml
xmlns:feedback="clr-namespace:FreakzDEV.Feedback;assembly=FreakzDEV.Feedback"
```

Then, you can use the `Feedback` control in your XAML:

```xml
<feedback:Message
  Type="success"
  Title="Operation Completed"
  Description="The operation was completed successfully."
  isVidible="True" />
```

You can also set the properties programmatically:

```csharp
var feedback = new Feedback.Message
{
  Type = FeedbackType.Success,
  Title = "Operation Completed",
  Description = "The operation was completed successfully.",
  isVisible = true
};
```

## Message Types

- `Error`: Indicates an error occurred.
- `Info`: Provides informational messages.
- `Success`: Indicates a successful operation.
- `Warning`: Warns about potential issues.

## Customization

You can customize the appearance and behavior of the feedback messages by setting various properties:

- `Title`: The title of the feedback message.
- `Description`: The detailed description of the feedback message.

## Example

Here is an example of how to use the Feedback library in your .NET MAUI application:

```xml
<feedback:FeedbackControl
  Type="warning"
  Title="Low Battery"
  Description="Your battery level is below 20%."
  isVidible="True" />
```

## License

This project is licensed under the MIT License.

## Contact

For any questions or feedback, please contact us at [support@freakz.dev](mailto:support@freakz.dev).
