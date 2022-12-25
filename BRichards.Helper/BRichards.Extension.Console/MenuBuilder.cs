namespace BRichards.Extension.ConsoleUtils;

/// <summary>
/// 
/// </summary>
public class MenuBuilder
{
    private class MenuItem
    {
        public string? Text { get; set; }
        public Action? Action { get; set; }

        public MenuItem() { }
        public MenuItem(string text, Action action)
        {
            Text = text;
            Action = action;
        }
    }

    private string? title;
    private readonly List<MenuItem> items = new();
    private Action<MenuBuilder, string>? onAfterItemSelected;

    /// <summary>
    /// Sets the first line of a menu as a title
    /// </summary>
    /// <param name="value">This text will be printed in the first line</param>
    /// <returns></returns>
    public MenuBuilder SetTitle(string value)
    {
        title = value;
        return this;
    }

    /// <summary>
    /// Adds a new menu entry
    /// </summary>
    /// <param name="text">Text of the item.</param>
    /// <param name="action">Action that will be Invoked on item selection</param>
    /// <returns></returns>
    public MenuBuilder AddItem(string text, Action action)
    {
        items.Add(new MenuItem(text, action));
        return this;
    }

    /// <summary>
    /// Sets an action witch is invoked on any menu item selection
    /// </summary>
    /// <param name="onAfterItemSelectedAction"></param>
    /// <returns></returns>
    public MenuBuilder SetOnAfterItemSelected(Action<MenuBuilder, string> onAfterItemSelectedAction)
    {
        onAfterItemSelected = onAfterItemSelectedAction;
        return this;
    }

    /// <summary>
    /// Writes the MenuBuilders output to the console, and waits for input
    /// </summary>
    public void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($" - {title} - ");
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Text}");
            }

            var input = Console.ReadLine();

            if (!int.TryParse(input, out var selection))
            {
                continue;
            }

            if (selection < 1 || selection > items.Count)
            {
                continue;
            }

            if (items[selection - 1].Action is null)
            {
                return;
            }

            items[selection - 1].Action!();
            onAfterItemSelected?.Invoke(this, items[selection - 1].Text ?? "");
            break;
        }
    }
}
