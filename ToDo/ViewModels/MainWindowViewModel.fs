namespace ViewModels
open Services
open ReactiveUI
open System;
open System.Reactive.Linq;
open Models;

type MainWindowViewModel(data :Database) =
    inherit ViewModelBase()  

    let list = new ToDoListViewModel(data.GetItems()) 

    let mutable content:ViewModelBase = upcast list

    member __.ToDoList with get() = list 

    member __.Content       
        with get():ViewModelBase = content
        and set(value:ViewModelBase) = __.RaiseAndSetIfChanged(&content, value) |> ignore
  
    member this.AddItem() =
        let vm = new AddItemViewModel()
        Observable.Merge(vm.Ok,vm.Cancel.Select(fun _ -> ToDoItem.defaultItem))
                    .Take(1)
                    .Subscribe(fun model -> 
                        if model <> ToDoItem.defaultItem then
                            this.ToDoList.Items.Add(model);
                        this.Content <- this.ToDoList
                    ) |> ignore
        this.Content <- vm
        
            
    
