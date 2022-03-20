// Requires Microsoft.Toolkit.Uwp.Notifications NuGet package version 7.0 or greater
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.Foundation.Collections;

// Listen to notification activation
ToastNotificationManagerCompat.OnActivated += toastArgs =>
{
    // Obtain the arguments from the notification
    ToastArguments args = ToastArguments.Parse(toastArgs.Argument);

    // Obtain any user input (text boxes, menu selections) from the notification
    ValueSet userInput = toastArgs.UserInput;

    Console.WriteLine("Toast activated. Args: " + toastArgs.Argument);
};

new ToastContentBuilder()
    .AddArgument("action", "viewConversation")
    .AddArgument("conversationId", 9813)
    .AddText("Andrew sent you a picture")
    .AddText("Check this out, The Enchantments in Washington!")
    .Show(); // Not seeing the Show() method? Make sure you have version 7.0, and if you're using .NET 5, your TFM must be net5.0-windows10.0.17763.0 or greater


Console.WriteLine("Waiting...");
Console.ReadLine();