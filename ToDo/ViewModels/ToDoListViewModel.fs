namespace ViewModels
open System.Collections.Generic
open Models
open System.Collections.ObjectModel

type ToDoListViewModel(items : IEnumerable<ToDoItem>) =
    inherit ViewModelBase()     
    member val Items = new ObservableCollection<ToDoItem>(items) with get