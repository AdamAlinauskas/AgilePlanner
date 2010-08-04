using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class HiddenFieldAttribute : UIHintAttribute
    {
        public HiddenFieldAttribute() : base("HiddenField")
        {
        }
    }
}