# Feedback

Feedback is a .NET MAUI library that allows you to display response messages for executed processes or tasks. It supports different types of feedback such as error, info, success, and warning. You can customize the tag (title) and description, and it uses animations for when the messages appear and disappear.

## Features

- Display feedback messages for processes or tasks
- Support for different feedback types: error, info, success, and warning
- Customizable tag (title) and description
- Animations for appearing and disappearing messages

## Installation

To install Feedback, run the following command in the NuGet Package Manager Console:

```sh
Install-Package Feedback
```

## Icons

To use the feedback icons, copy the SVG icons from the `icons` folder to the `Resources\Images` folder of your main project. Feel free to modify the icons to suit your needs.

## Usage

First, add the namespace to your XAML file:

```xml
xmlns:feedback="clr-namespace:Feedback;assembly=Feedback"
```

Then, you can use the `Feedback` control in your XAML:

```xml
<feedback:Message
  Type="success"
  Tag="Operation Completed"
  Description="The operation was completed successfully." />
```

You can also set the properties programmatically:

```csharp
var feedback = new Feedback.Message
{
  Type = FeedbackType.Success,
  Tag = "Operation Completed",
  Description = "The operation was completed successfully."
};
```

## Message Types

- `Error`: Indicates an error occurred.
- `Info`: Provides informational messages.
- `Success`: Indicates a successful operation.
- `Warning`: Warns about potential issues.

## Customization

You can customize the appearance and behavior of the feedback messages by setting various properties:

- `Tag`: The title of the feedback message.
- `Description`: The detailed description of the feedback message.

## Example

Here is an example of how to use the Feedback library in your .NET MAUI application:

```xml
<feedback:FeedbackControl
  Type="warning"
  Tag="Low Battery"
  Description="Your battery level is below 20%." />
```

## License

This project is licensed under the MIT License.

## Contact

For any questions or feedback, please contact us at [support@freakz.dev](mailto:support@freakz.dev).
