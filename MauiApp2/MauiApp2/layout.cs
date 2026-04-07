<? xml version = "1.0" encoding = "utf-8" ?>
< ContentPage xmlns = "http://schemas.microsoft.com/dotnet/2021/maui"
             x: Class = "LayoutExample.MainPage" >

    < Grid RowDefinitions = "*,*"
          ColumnDefinitions = "*"
          Padding = "20" >

        < !-- 🔸 Vertical Layout -->
        <VerticalStackLayout Grid.Row="0" Spacing="10">
            <Label Text="Vertical Layout"
                   FontSize="20"
                   HorizontalOptions="Center"/>

            <Button Text="Button 1"/>
            <Button Text="Button 2"/>
            <Button Text="Button 3"/>
        </VerticalStackLayout>

        <!-- 🔸 Horizontal Layout -->
        <HorizontalStackLayout Grid.Row="1" Spacing="10">
            <Label Text="Horizontal Layout"
                   VerticalOptions="Center"/>

            <Button Text="A"/>
            <Button Text="B"/>
            <Button Text="C"/>
        </HorizontalStackLayout>

    </Grid>

</ContentPage>
