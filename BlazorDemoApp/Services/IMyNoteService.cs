using BlazorDemoApp.Models;

namespace BlazorDemoApp.Services
{
    public interface IMyNoteService
    {
        Task CreateAsync(MyNote myNote);
        Task DeleteAsync(MyNote myNote);
        Task<List<MyNote>> RetrieveAsync(MyNote myNote);
        Task UpdateAsync(MyNote originalNote, MyNote newNote);
    }
}
