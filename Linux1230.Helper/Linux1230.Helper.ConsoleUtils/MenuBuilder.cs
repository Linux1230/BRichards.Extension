using System;
using System.Collections.Generic;

namespace Linux1230.Helper.ConsoleUtils;

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
    /// <param name="title">Az első sorban, két kötőjel között jelenik meg.</param>
    /// <returns></returns>
    public MenuBuilder SetTitle(string title)
    {
        this.title = title;
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
    /// <param name="onAfterItemSelected"></param>
    /// <returns></returns>
    public MenuBuilder SetOnAfterItemSelected(Action<MenuBuilder, string> onAfterItemSelected)
    {
        this.onAfterItemSelected = onAfterItemSelected;
        return this;
    }

    /// <summary>
    /// Kiírja a menüt a képernyőre és választ vár a felhasználótól.
    /// </summary>
    public void Show()
    {
        // Write menu
        Console.Clear();
        Console.WriteLine($" - {title} - ");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i].Text}");
        }
        // Get selection
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int selection))
        {
            Show();
            return;
        }

        if (selection < 1 || selection > items.Count)
        {
            Show();
            return;
        }

        // Execute selected item
        if (items[selection - 1].Action is null || items[selection - 1] is null)
            return;

        items[selection - 1].Action();
        onAfterItemSelected?.Invoke(this, items[selection - 1].Text);
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
