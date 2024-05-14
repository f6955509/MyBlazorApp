using BlazorDemoApp.Models;

namespace BlazorDemoApp.Services
{
    public class MyNoteService : IMyNoteService
    {
        List<MyNote> MyNotes { get; set; }

        public MyNoteService()
        {
            MyNotes = new List<MyNote>()
            {
                new MyNote(){Title="Strawberry"},
                new MyNote(){Title="Watermelon"},
                new MyNote(){Title="Apple"}
            };
        }
        public Task CreateAsync(MyNote newNote)
        {
            MyNotes.Add(newNote);
            return Task.FromResult(0);
        }

        public Task DeleteAsync(MyNote node)
        {
            var findNote = MyNotes.First(x => x.Title == node.Title);
            if (findNote != null)
            {
                MyNotes.Remove(findNote);
            }
            return Task.FromResult(MyNotes);
        }

        public Task UpdateAsync(MyNote originalNote, MyNote newNote)
        {
            var findNote = MyNotes.First(x => x.Title == originalNote.Title);

            if (findNote != null)
            {
                findNote.Title = newNote.Title;
            }
            return Task.FromResult(0);
        }

        public Task<List<MyNote>> RetrieveAsync(MyNote myNote)
        {
            return Task.FromResult(MyNotes);
        }
    }
}
