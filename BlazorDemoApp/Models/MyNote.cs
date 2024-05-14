using System.ComponentModel.DataAnnotations;

namespace BlazorDemoApp.Models
{
    public class MyNote : ICloneable
    {
        [Required(ErrorMessage ="Title can't be empty.")]
        public string Title { get; set; }

        public MyNote Clone()
        {
            return ((ICloneable)this).Clone() as MyNote;
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
