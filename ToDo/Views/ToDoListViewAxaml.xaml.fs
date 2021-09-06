namespace Views

open Avalonia
open Avalonia.Controls
open Avalonia.Markup.Xaml

type ToDoListViewAxaml () as self = 
    inherit UserControl ()

    do AvaloniaXamlLoader.Load self
