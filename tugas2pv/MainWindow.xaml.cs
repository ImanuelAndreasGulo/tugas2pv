< Grid Margin = "0" >
    < !--Display-- >
    < TextBox x: Name = "Display" Text = "0" FontSize = "36" HorizontalAlignment = "Stretch" VerticalAlignment = "Top" Height = "70" Margin = "10,10,10,0" IsReadOnly = "True" TextAlignment = "Right" BorderThickness = "0" Background = "#222" Foreground = "White" />

    < !--Calculator Buttons-- >
    < Grid Margin = "10,90,10,10" >
        < Grid.RowDefinitions >
            < RowDefinition Height = "*" />
            < RowDefinition Height = "*" />
            < RowDefinition Height = "*" />
            < RowDefinition Height = "*" />
            < RowDefinition Height = "*" />
            < RowDefinition Height = "*" />
        </ Grid.RowDefinitions >
        < Grid.ColumnDefinitions >
            < ColumnDefinition Width = "*" />
            < ColumnDefinition Width = "*" />
            < ColumnDefinition Width = "*" />
            < ColumnDefinition Width = "*" />
            < ColumnDefinition Width = "*" />
        </ Grid.ColumnDefinitions >

        < !--Row 0-- >
        < Button Grid.Row = "0" Grid.Column = "0" Content = "2ⁿᵈ" />
        < Button Grid.Row = "0" Grid.Column = "1" Content = "π" />
        < Button Grid.Row = "0" Grid.Column = "2" Content = "e" />
        < Button Grid.Row = "0" Grid.Column = "3" Content = "C" />
        < Button Grid.Row = "0" Grid.Column = "4" Content = "⌫" />

        < !--Row 1-- >
        < Button Grid.Row = "1" Grid.Column = "0" Content = "x²" />
        < Button Grid.Row = "1" Grid.Column = "1" Content = "⅟x" />
        < Button Grid.Row = "1" Grid.Column = "2" Content = "|x|" />
        < Button Grid.Row = "1" Grid.Column = "3" Content = "exp" />
        < Button Grid.Row = "1" Grid.Column = "4" Content = "mod" />

        < !--Row 2-- >
        < Button Grid.Row = "2" Grid.Column = "0" Content = "√x" />
        < Button Grid.Row = "2" Grid.Column = "1" Content = "(" />
        < Button Grid.Row = "2" Grid.Column = "2" Content = ")" />
        < Button Grid.Row = "2" Grid.Column = "3" Content = "n!" />
        < Button Grid.Row = "2" Grid.Column = "4" Content = "÷" />

        < !--Row 3-- >
        < Button Grid.Row = "3" Grid.Column = "0" Content = "xʸ" />
        < Button Grid.Row = "3" Grid.Column = "1" Content = "7" />
        < Button Grid.Row = "3" Grid.Column = "2" Content = "8" />
        < Button Grid.Row = "3" Grid.Column = "3" Content = "9" />
        < Button Grid.Row = "3" Grid.Column = "4" Content = "×" />

        < !--Row 4-- >
        < Button Grid.Row = "4" Grid.Column = "0" Content = "10ˣ" />
        < Button Grid.Row = "4" Grid.Column = "1" Content = "4" />
        < Button Grid.Row = "4" Grid.Column = "2" Content = "5" />
        < Button Grid.Row = "4" Grid.Column = "3" Content = "6" />
        < Button Grid.Row = "4" Grid.Column = "4" Content = "−" />

        < !--Row 5-- >
        < Button Grid.Row = "5" Grid.Column = "0" Content = "log" />
        < Button Grid.Row = "5" Grid.Column = "1" Content = "1" />
        < Button Grid.Row = "5" Grid.Column = "2" Content = "2" />
        < Button Grid.Row = "5" Grid.Column = "3" Content = "3" />
        < Button Grid.Row = "5" Grid.Column = "4" Content = "+" />

        < !--Row 6-- >
        < Button Grid.Row = "6" Grid.Column = "0" Content = "ln" />
        < Button Grid.Row = "6" Grid.Column = "1" Content = "±" />
        < Button Grid.Row = "6" Grid.Column = "2" Content = "0" />
        < Button Grid.Row = "6" Grid.Column = "3" Content = "." />
        < Button Grid.Row = "6" Grid.Column = "4" Content = "=" Background = "#2196F3" Foreground = "White" />
    </ Grid >
</ Grid >