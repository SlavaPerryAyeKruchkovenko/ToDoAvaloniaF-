namespace ViewModels
open System.Reactive
open ReactiveUI
open Models;
open System;

type AddItemViewModel() as this=    
    inherit ViewModelBase()

    let mutable description:string = String.Empty
    let okEnabled = this.WhenAnyValue(
                                        (fun (x) -> x.Description) , 
                                        (fun(x) -> String.IsNullOrWhiteSpace(x) |> not)
                                     )
    let ok = lazy (ReactiveCommand.Create<_>((fun () -> {ToDoItem.defaultItem with Description = this.Description}), okEnabled))

    member this.Description 
        with get () = description
        and set(value) = this.RaiseAndSetIfChanged(&description,value)|> ignore

    member __.Ok with get() = ok.Force()
    member val Cancel = ReactiveCommand.Create(fun () -> ())

