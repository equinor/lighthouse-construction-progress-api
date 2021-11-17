using lighthouse_construction_progress_api.Application.TodoLists.Queries.ExportTodos;

namespace lighthouse_construction_progress_api.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
