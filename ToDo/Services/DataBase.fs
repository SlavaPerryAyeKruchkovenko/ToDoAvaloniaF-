namespace Services
open Models
type Database() = 
    member this.GetItems() =
        seq{
            yield { ToDoItem.defaultItem with Description = "Walk the dog" }
            yield { ToDoItem.defaultItem with Description = "Buy some milk" }
            yield { ToDoItem.defaultItem with Description = "Learn Avalonia"; IsChecked = true }
            }