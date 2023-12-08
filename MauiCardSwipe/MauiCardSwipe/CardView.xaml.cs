using System.ComponentModel;

namespace MauiCardSwipe;

public partial class CardView : ContentView
{
    public CardView(DataTemplate itemTemplate)
    {
        InitializeComponent();
        Container.Content = itemTemplate.CreateContent() as View;
    }

    public void Update(object item)
    {
        //Container.IsVisible = false;
        Container.Content.BindingContext = item;
        //Container.IsVisible = true;
    }
}