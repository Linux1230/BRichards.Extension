namespace BRichards.Helper.ConsoleUtils;

public class MenuBuilder
{
    private string? title;
    private List<MenuItem> items = new();
    private Action<MenuBuilder, string>? onAfterItemSelected;

    public MenuBuilder() { }

    public MenuBuilder(string title)
    {
        this.title = title;
    }

    /// <summary>
    /// Beállítja a menü első sorát / címét.
    /// </summary>
    /// <param name="value">Az első sorban, két kötőjel között jelenik meg.</param>
    /// <returns></returns>
    public MenuBuilder SetTitle(string value)
    {
        title = value;
        return this;
    }

    /// <summary>
    /// Új menü elem hozzáadása.
    /// </summary>
    /// <param name="text">Ez az elem szövege, ami megjelenik a képernyőn egy sorszám után.</param>
    /// <param name="action">Ez a kód, ami lefut, ha ezt a menü elemet választja a felhasználó.</param>
    /// <returns></returns>
    public MenuBuilder AddItem(string text, Action action)
    {
        items.Add(new MenuItem(text, action));
        return this;
    }

    /// <summary>
    /// Beállítja a kódot, ami egy menü elem választása UTÁN történik.
    /// Például itt lehet megadni, hogy elem választása után a program visszatérjen ide a menübe.
    /// </summary>
    /// <param name="onAfterItemSelectedAction"></param>
    /// <returns></returns>
    public MenuBuilder SetOnAfterItemSelected(Action<MenuBuilder, string> onAfterItemSelectedAction)
    {
        onAfterItemSelected = onAfterItemSelectedAction;
        return this;
    }

    /// <summary>
    /// Kiírja a menüt a képernyőre és választ vár a felhasználótól.
    /// </summary>
    public void Show()
    {
        while (true)
        {
            // Write menu
            Console.Clear();
            Console.WriteLine($" - {title} - ");
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Text}");
            }

            // Get selection
            var input = Console.ReadLine();

            if (!int.TryParse(input, out var selection))
            {
                continue;
            }

            if (selection < 1 || selection > items.Count)
            {
                continue;
            }

            // Execute selected item
            //if (items[selection - 1] is null)
            //{
            //    return;
            //}

            if (items[selection - 1].Action is null)
            {
                return;
            }

            items[selection - 1].Action!();
            onAfterItemSelected?.Invoke(this, items[selection - 1].Text ?? "");
            break;
        }
    }

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
}
