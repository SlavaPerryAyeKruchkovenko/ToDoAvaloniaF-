﻿namespace Views

open Avalonia.Controls
open Avalonia.Markup.Xaml

type ToDoListView () as self = 
    inherit UserControl ()
    do AvaloniaXamlLoader.Load self
    
    
        
