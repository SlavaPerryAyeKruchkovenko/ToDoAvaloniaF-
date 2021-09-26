namespace Models
open System

type ToDoItem =
    {
        Description:string
        mutable IsChecked :bool
    }
module ToDoItem =
    let defaultItem =
        { 
          Description = String.Empty
          IsChecked = false 
        }    