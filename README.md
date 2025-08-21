# How to use Xamarin.Forms ListView in Xamarin.Android and Xamarin.iOS platforms
This example demonstrates how to use Xamarin.Forms ListView in Xamarin.Android and Xamarin.iOS platforms.

## Sample

```xaml
<Grid>
    <listView:SfListView x:Name="listView" ItemSpacing="10" AutoFitMode="Height"
                    ItemsSource="{Binding contactsinfo}">
        <listView:SfListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <ViewCell.View>
                        <Grid x:Name="grid" RowSpacing="1" BackgroundColor="#d3d3d3">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="*" />
                                <RowDefinition Height="1" />
                            </Grid.RowDefinitions>
                            <Grid RowSpacing="1">
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="*" />
                                    <ColumnDefinition Width="70" />
                                </Grid.ColumnDefinitions>

                                <Grid Grid.Column="0"
                                        RowSpacing="1"
                                        Padding="10,0,0,0"
                                        VerticalOptions="Center">
                                    <Grid.RowDefinitions>
                                        <RowDefinition Height="*" />
                                        <RowDefinition Height="*" />
                                    </Grid.RowDefinitions>

                                    <Label 
                                        Text="{Binding ContactName}">
                                    </Label>
                                    <Label Grid.Row="1"
                                            Grid.Column="0"
                                            TextColor="#474747"
                                            LineBreakMode="NoWrap"
                                            Text="{Binding ContactNumber}">
                                        <Label.FontSize>
                                            <OnPlatform x:TypeArguments="x:Double">
                                                <OnPlatform.WinPhone>
                                                    <OnIdiom x:TypeArguments="x:Double" Phone="12" Tablet="12" />
                                                </OnPlatform.WinPhone>
                                                <OnPlatform.Android>
                                                    <OnIdiom x:TypeArguments="x:Double"
                                                            Phone="12"
                                                            Tablet="14" />
                                                </OnPlatform.Android>
                                                <OnPlatform.iOS>
                                                    <OnIdiom x:TypeArguments="x:Double"
                                                                        Phone="12"
                                                                        Tablet="14" />
                                                </OnPlatform.iOS>
                                            </OnPlatform>
                                        </Label.FontSize>
                                    </Label>
                                </Grid>
                                <Grid Grid.Row="0"
                                        Grid.Column="1"
                                        RowSpacing="0"
                                        HorizontalOptions="End"
                                        Padding="0,10,10,0">
                                    <Label LineBreakMode="NoWrap"
                                            TextColor="#474747"
                                            Text="{Binding ContactType}">
                                        <Label.FontSize>
                                            <OnPlatform x:TypeArguments="x:Double">
                                                <OnPlatform.WinPhone>
                                                    <OnIdiom x:TypeArguments="x:Double" Phone="10" Tablet="11" />
                                                </OnPlatform.WinPhone>
                                                <OnPlatform.Android>
                                                    <OnIdiom x:TypeArguments="x:Double"
                                                            Phone="10"
                                                            Tablet="12" />
                                                </OnPlatform.Android>
                                                <OnPlatform.iOS>
                                                    <OnIdiom x:TypeArguments="x:Double"
                                                            Phone="10"
                                                            Tablet="12" />
                                                </OnPlatform.iOS>
                                            </OnPlatform>
                                        </Label.FontSize>
                                    </Label>
                                </Grid>
                            </Grid>
                            <StackLayout Grid.Row="1" BackgroundColor="Gray" HeightRequest="1"/>
                        </Grid>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </listView:SfListView.ItemTemplate>
    </listView:SfListView>
</Grid>
```

See [How to use Xamarin.Forms ListView in Xamarin.Android and Xamarin.iOS platforms](https://www.syncfusion.com/kb/9392/how-to-use-xamarin-forms-listview-in-xamarin-android-and-xamarin-ios-platforms) for more details.
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
