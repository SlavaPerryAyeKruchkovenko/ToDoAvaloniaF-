namespace ToDo

open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Markup.Xaml
open ViewModels
open Views
open ViewModels
open Services

type App() as self =
    inherit Application()

    do AvaloniaXamlLoader.Load self

    override x.OnFrameworkInitializationCompleted() =
        match x.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktop ->
             let data = new Database()
             desktop.MainWindow <- new MainWindow(DataContext=MainWindowViewModel(data))
        | _ -> ()

        base.OnFrameworkInitializationCompleted()
