namespace Views

open Avalonia
open Avalonia.Controls
open Avalonia.Markup.Xaml

type AddItemView () as self = 
    inherit UserControl ()

    do AvaloniaXamlLoader.Load self
