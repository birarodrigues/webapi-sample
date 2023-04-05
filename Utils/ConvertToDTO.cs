using TodoApi.Dtos;
using TodoApi.Models;

namespace TodoApi.Utils;

public static class ConvertToDTO
{
    public static TodoItemDTO TodoItemDTO(TodoItem todoItem) =>
     new TodoItemDTO
     {
         Id = todoItem.Id,
         Name = todoItem.Name,
         IsComplete = todoItem.IsComplete
     };
}