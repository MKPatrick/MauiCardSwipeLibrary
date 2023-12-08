Original code from: https://github.com/robinmanuelthiel/swipecards

Making some changes to make it stable for .net maui.



**Add the control**
```xml
        <swipe:CardStackView  LoadNextItemsCommand="{Binding LoadNewItemsCommand}" SwipedLeftCommand="{Binding MoveLeftCommand}" SwipedRightCommand="{Binding MoveRightCommand}"  Grid.Column="1" ItemsSource="{Binding Movies}" >
        <swipe:CardStackView.ItemTemplate>
            <DataTemplate>
                        <Grid >
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition/>
                            <ColumnDefinition/>
                            <ColumnDefinition/>
                        </Grid.ColumnDefinitions>
                        <Grid Grid.Column="1" >
                            <Grid.RowDefinitions>
                                <RowDefinition/>
                                <RowDefinition Height="30"/>
                            </Grid.RowDefinitions>
                            <Image Aspect="Fill" Grid.Column="1"  Source="rick.png" ZIndex="0"/>
                            <Label Grid.Row="1" Text="{Binding MovieTitle}" ZIndex="4"/>
                        </Grid>
                        </Grid>
                </DataTemplate>
        </swipe:CardStackView.ItemTemplate>
    </swipe:CardStackView>
```


## API Reference
| Method | Description |
|-|-|
| Reset() | Resets the whole card stack |

| Property | Default | Description |
|-|-|-|
| CardMoveDistance | null | How far the card has to be dragged to trigger the swipe. Default is 30% of the control |

| Command | Parameter | Description |
|-|-|-|
| SwipedLeftCommand | Selected Item | Triggered, when card got swiped to the left |
| SwipedRightCommand | Selected Item | Triggered, when card got swiped to the right |
| LoadNextItemsCommand | null | Triggered, when all items from itemsource are swiped successfully |

| Event | Arguments | Description |
|-|-|-|
| Swiped | Swiped Item, Swipe direction | Triggered, when card got swiped to the left or right |
| StartedDragging | Dragged Item | Triggered, when card got dragged |
| FinishedDragging | Dragged Item | Triggered, when dragging finished |
